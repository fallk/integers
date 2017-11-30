using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A279763
{
public static readonly long[] Value={ 1L,1L,21L,105L,535L,2670L,12996L,59546L,266875L,1161894L,4939778L,20528320L,83636061L,334496221L,1315381029L,5091782355L,19424086781L,73092029218L,271537720562L,996656173345L,3616680935702L,12983391870459L,46133749660407L,162337625047433L,565962994479384L,1955721907216420L,6701061533668542L,22774651422340672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279763Inst : IEnumerable<long>
{
public static readonly long[] Value=A279763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279763.Bytes);
public long this[int i]=>Value[i];

public static A279763Inst Instance=new A279763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279764
{
public static readonly long[] Value={ 5L,10L,39L,203L,604L,670L,874L,1643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279764Inst : IEnumerable<long>
{
public static readonly long[] Value=A279764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279764.Bytes);
public long this[int i]=>Value[i];

public static A279764Inst Instance=new A279764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279765
{
public static readonly long[] Value={ 5L,13L,19L,23L,59L,79L,83L,89L,103L,149L,233L,269L,283L,349L,373L,409L,419L,439L,443L,499L,523L,569L,593L,653L,709L,773L,829L,839L,859L,863L,929L,1039L,1069L,1259L,1279L,1399L,1423L,1559L,1699L,1753L,1823L,1949L,1979L,2039L,2063L,2089L,2113L,2309L,2333L,2393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279765Inst : IEnumerable<long>
{
public static readonly long[] Value=A279765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279765.Bytes);
public long this[int i]=>Value[i];

public static A279765Inst Instance=new A279765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279766
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,8L,9L,11L,12L,14L,15L,17L,18L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,26L,28L,29L,31L,32L,34L,35L,37L,38L,40L,40L,41L,41L,42L,42L,43L,43L,44L,44L,45L,46L,48L,49L,51L,52L,54L,55L,57L,58L,60L,60L,61L,61L,62L,62L,63L,63L,64L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279766Inst : IEnumerable<long>
{
public static readonly long[] Value=A279766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279766.Bytes);
public long this[int i]=>Value[i];

public static A279766Inst Instance=new A279766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279767
{
public static readonly long[] Value={ 3L,5L,11L,17L,18L,29L,33L,41L,50L,54L,55L,59L,71L,85L,91L,93L,101L,107L,137L,141L,143L,149L,159L,179L,183L,185L,191L,197L,201L,203L,213L,215L,217L,219L,227L,235L,239L,242L,247L,248L,265L,269L,281L,299L,301L,303L,306L,311L,319L,321L,327L,339L,340L,347L,348L,391L,393L,411L,413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279767Inst : IEnumerable<long>
{
public static readonly long[] Value=A279767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279767.Bytes);
public long this[int i]=>Value[i];

public static A279767Inst Instance=new A279767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279768
{
public static readonly long[] Value={ 11L,47L,56L,74L,83L,92L,101L,110L,119L,137L,146L,173L,182L,191L,209L,218L,227L,245L,272L,281L,299L,308L,317L,326L,335L,344L,353L,398L,407L,416L,434L,443L,452L,470L,479L,488L,506L,524L,533L,542L,551L,560L,569L,578L,605L,614L,632L,641L,659L,668L,677L,695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279768Inst : IEnumerable<long>
{
public static readonly long[] Value=A279768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279768.Bytes);
public long this[int i]=>Value[i];

public static A279768Inst Instance=new A279768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279769
{
public static readonly long[] Value={ 11L,21L,22L,31L,32L,33L,41L,42L,43L,44L,51L,52L,53L,54L,55L,61L,62L,63L,64L,65L,66L,71L,72L,73L,74L,75L,76L,77L,81L,82L,83L,84L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,97L,98L,99L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,121L,122L,131L,132L,133L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279769Inst : IEnumerable<long>
{
public static readonly long[] Value=A279769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279769.Bytes);
public long this[int i]=>Value[i];

public static A279769Inst Instance=new A279769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279770
{
public static readonly long[] Value={ 11L,38L,47L,56L,65L,74L,83L,92L,101L,110L,119L,155L,164L,182L,191L,209L,218L,236L,245L,263L,272L,299L,308L,317L,326L,335L,344L,353L,362L,380L,389L,416L,434L,452L,461L,470L,479L,488L,506L,515L,533L,560L,578L,587L,596L,605L,623L,632L,650L,659L,686L,722L,731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279770Inst : IEnumerable<long>
{
public static readonly long[] Value=A279770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279770.Bytes);
public long this[int i]=>Value[i];

public static A279770Inst Instance=new A279770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279771
{
public static readonly long[] Value={ 19L,28L,37L,46L,55L,64L,73L,82L,190L,280L,370L,460L,550L,640L,730L,820L,919L,928L,937L,946L,955L,964L,973L,982L,991L,1819L,1828L,1837L,1846L,1855L,1864L,1873L,1882L,1891L,1900L,2728L,2737L,2746L,2755L,2764L,2773L,2782L,2791L,2800L,3637L,3646L,3655L,3664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279771Inst : IEnumerable<long>
{
public static readonly long[] Value=A279771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279771.Bytes);
public long this[int i]=>Value[i];

public static A279771Inst Instance=new A279771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279772
{
public static readonly long[] Value={ 2L,11L,20L,56L,65L,101L,110L,155L,200L,506L,515L,551L,560L,605L,650L,1001L,1010L,1055L,1100L,1505L,1550L,2000L,5006L,5015L,5051L,5060L,5105L,5150L,5501L,5510L,5555L,5600L,6005L,6050L,6500L,10001L,10010L,10055L,10100L,10505L,10550L,11000L,15005L,15050L,15500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279772Inst : IEnumerable<long>
{
public static readonly long[] Value=A279772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279772.Bytes);
public long this[int i]=>Value[i];

public static A279772Inst Instance=new A279772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279773
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,35L,38L,41L,44L,47L,50L,68L,71L,74L,77L,80L,101L,104L,107L,110L,134L,137L,140L,167L,170L,200L,335L,338L,341L,344L,347L,350L,368L,371L,374L,377L,380L,401L,404L,407L,410L,434L,437L,440L,467L,470L,500L,668L,671L,674L,677L,680L,701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279773Inst : IEnumerable<long>
{
public static readonly long[] Value=A279773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279773.Bytes);
public long this[int i]=>Value[i];

public static A279773Inst Instance=new A279773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279774
{
public static readonly long[] Value={ 2L,11L,20L,29L,38L,56L,65L,83L,101L,110L,128L,155L,200L,254L,263L,281L,290L,308L,326L,335L,353L,380L,425L,506L,515L,533L,551L,560L,578L,605L,650L,758L,776L,785L,803L,830L,875L,1001L,1010L,1028L,1055L,1100L,1253L,1280L,1325L,1505L,1550L,1775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279774Inst : IEnumerable<long>
{
public static readonly long[] Value=A279774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279774.Bytes);
public long this[int i]=>Value[i];

public static A279774Inst Instance=new A279774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279775
{
public static readonly long[] Value={ 11L,29L,38L,47L,56L,65L,74L,83L,92L,101L,110L,128L,146L,164L,182L,209L,218L,227L,236L,245L,254L,263L,272L,281L,290L,308L,326L,344L,362L,380L,407L,416L,425L,434L,443L,452L,461L,470L,488L,506L,524L,542L,560L,605L,614L,623L,632L,641L,650L,668L,686L,704L,722L,740L,803L,812L,821L,830L,848L,866L,884L,902L,920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279775Inst : IEnumerable<long>
{
public static readonly long[] Value=A279775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279775.Bytes);
public long this[int i]=>Value[i];

public static A279775Inst Instance=new A279775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279776
{
public static readonly long[] Value={ 8L,11L,14L,23L,26L,29L,32L,38L,41L,44L,47L,53L,56L,59L,62L,65L,68L,71L,74L,77L,80L,86L,89L,92L,95L,101L,104L,107L,110L,119L,122L,125L,134L,137L,140L,152L,155L,173L,176L,179L,182L,188L,191L,194L,197L,203L,206L,209L,212L,215L,218L,221L,224L,227L,230L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279776Inst : IEnumerable<long>
{
public static readonly long[] Value=A279776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279776.Bytes);
public long this[int i]=>Value[i];

public static A279776Inst Instance=new A279776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279777
{
public static readonly long[] Value={ 111L,211L,221L,222L,311L,321L,322L,331L,332L,333L,411L,421L,422L,431L,432L,433L,441L,442L,443L,444L,511L,521L,522L,531L,532L,533L,541L,542L,543L,544L,551L,552L,553L,554L,555L,611L,621L,622L,631L,632L,633L,641L,642L,643L,644L,651L,652L,653L,654L,655L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279777Inst : IEnumerable<long>
{
public static readonly long[] Value=A279777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279777.Bytes);
public long this[int i]=>Value[i];

public static A279777Inst Instance=new A279777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279778
{
public static readonly long[] Value={ 1L,-2L,1L,0L,-1L,3L,-3L,1L,1L,-5L,9L,-7L,1L,7L,-19L,25L,-15L,-5L,33L,-63L,65L,-25L,-43L,129L,-191L,155L,-7L,-215L,449L,-537L,317L,201L,-879L,1435L,-1391L,433L,1281L,-3193L,4261L,-3215L,-415L,5755L,-10647L,11737L,-6015L,-6585L,22157L,-33031L,29489L,-5445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279778Inst : IEnumerable<long>
{
public static readonly long[] Value=A279778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279778.Bytes);
public long this[int i]=>Value[i];

public static A279778Inst Instance=new A279778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279779
{
public static readonly long[] Value={ 1L,-2L,0L,3L,-3L,0L,4L,-7L,5L,5L,-16L,15L,2L,-26L,39L,-19L,-37L,88L,-73L,-28L,160L,-207L,61L,249L,-484L,339L,258L,-950L,1063L,-99L,-1593L,2628L,-1469L,-1996L,5492L,-5287L,-763L,9837L,-14008L,5671L,14034L,-31042L,25319L,11389L,-59053L,73040L,-16961L,-92844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279779Inst : IEnumerable<long>
{
public static readonly long[] Value=A279779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279779.Bytes);
public long this[int i]=>Value[i];

public static A279779Inst Instance=new A279779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279780
{
public static readonly long[] Value={ 1L,-3L,5L,-9L,17L,-30L,52L,-90L,154L,-262L,446L,-758L,1286L,-2182L,3702L,-6278L,10646L,-18054L,30614L,-51910L,88022L,-149254L,253078L,-429126L,727638L,-1233798L,2092054L,-3547334L,6014934L,-10199046L,17293718L,-29323590L,49721686L,-84309126L,142956310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279780Inst : IEnumerable<long>
{
public static readonly long[] Value=A279780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279780.Bytes);
public long this[int i]=>Value[i];

public static A279780Inst Instance=new A279780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279781
{
public static readonly long[] Value={ 1L,-3L,4L,-4L,4L,-3L,-1L,8L,-16L,24L,-30L,28L,-12L,-20L,68L,-128L,184L,-208L,168L,-32L,-224L,592L,-1008L,1344L,-1408L,960L,224L,-2240L,4928L,-7744L,9664L,-9216L,4736L,5120L,-20608L,39936L,-58368L,67840L,-57600L,16384L,63488L,-180224L,315904L,-431104L,463872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279781Inst : IEnumerable<long>
{
public static readonly long[] Value=A279781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279781.Bytes);
public long this[int i]=>Value[i];

public static A279781Inst Instance=new A279781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279782
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,1L,2L,3L,1L,4L,1L,2L,3L,5L,4L,1L,3L,5L,1L,6L,2L,5L,4L,1L,5L,3L,7L,1L,2L,7L,3L,4L,8L,1L,5L,7L,6L,5L,7L,1L,2L,3L,9L,8L,4L,7L,5L,1L,9L,6L,3L,7L,10L,5L,1L,2L,8L,4L,9L,1L,11L,3L,10L,7L,9L,5L,8L,11L,1L,2L,3L,7L,4L,12L,5L,11L,6L,1L,9L,7L,11L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279782Inst : IEnumerable<long>
{
public static readonly long[] Value=A279782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279782.Bytes);
public long this[int i]=>Value[i];

public static A279782Inst Instance=new A279782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279783
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,5L,7L,7L,7L,6L,7L,8L,8L,7L,9L,7L,9L,8L,9L,10L,9L,10L,8L,11L,11L,9L,11L,11L,9L,12L,11L,10L,11L,12L,11L,13L,13L,13L,10L,11L,13L,12L,13L,14L,11L,13L,14L,13L,11L,14L,15L,15L,13L,15L,13L,16L,12L,16L,13L,15L,14L,16L,15L,13L,17L,17L,17L,16L,17L,13L,17L,14L,17L,18L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279783Inst : IEnumerable<long>
{
public static readonly long[] Value=A279783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279783.Bytes);
public long this[int i]=>Value[i];

public static A279783Inst Instance=new A279783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279784
{
public static readonly long[] Value={ 1L,1L,3L,5L,12L,18L,40L,60L,121L,186L,344L,524L,955L,1432L,2484L,3756L,6352L,9493L,15750L,23414L,38128L,56513L,90406L,133312L,211194L,309657L,484214L,708267L,1097159L,1597290L,2454245L,3560444L,5430091L,7854174L,11894335L,17151394L,25838413L,37145198L,55648059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279784Inst : IEnumerable<long>
{
public static readonly long[] Value=A279784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279784.Bytes);
public long this[int i]=>Value[i];

public static A279784Inst Instance=new A279784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279785
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,7L,11L,18L,28L,47L,71L,108L,166L,252L,382L,587L,869L,1282L,1938L,2832L,4153L,6148L,8962L,12965L,18913L,27301L,39380L,56747L,81226L,115907L,166358L,236000L,334647L,475517L,671806L,947552L,1335679L,1875175L,2630584L,3687589L,5150585L,7183548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279785Inst : IEnumerable<long>
{
public static readonly long[] Value=A279785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279785.Bytes);
public long this[int i]=>Value[i];

public static A279785Inst Instance=new A279785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279786
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,9L,16L,22L,28L,49L,69L,94L,138L,187L,257L,374L,479L,639L,886L,1146L,1577L,2103L,2676L,3534L,4620L,5910L,7542L,9816L,12650L,15986L,20538L,25740L,32632L,41442L,51383L,64771L,81281L,100729L,125041L,155557L,192641L,236810L,293593L,359880L,441276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279786Inst : IEnumerable<long>
{
public static readonly long[] Value=A279786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279786.Bytes);
public long this[int i]=>Value[i];

public static A279786Inst Instance=new A279786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279787
{
public static readonly long[] Value={ 1L,1L,3L,4L,10L,8L,29L,16L,64L,58L,124L,57L,469L,102L,489L,763L,1597L,298L,3858L,491L,8942L,6355L,6187L,1256L,59076L,18766L,20830L,49694L,167078L,4566L,481186L,6843L,752128L,362907L,231592L,1597802L,5951007L,21638L,790404L,2655810L,25274798L,44584L,40898731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279787Inst : IEnumerable<long>
{
public static readonly long[] Value=A279787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279787.Bytes);
public long this[int i]=>Value[i];

public static A279787Inst Instance=new A279787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279788
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,10L,6L,12L,17L,21L,13L,57L,19L,49L,87L,86L,39L,240L,55L,279L,330L,235L,105L,1141L,386L,491L,1217L,1461L,257L,4804L,341L,2968L,4225L,1958L,5898L,18961L,761L,3782L,15007L,30572L,1261L,66245L,1611L,32523L,106951L,13122L,2591L,283013L,81390L,182873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279788Inst : IEnumerable<long>
{
public static readonly long[] Value=A279788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279788.Bytes);
public long this[int i]=>Value[i];

public static A279788Inst Instance=new A279788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279789
{
public static readonly long[] Value={ 1L,1L,3L,3L,8L,3L,17L,3L,30L,12L,41L,3L,130L,3L,137L,45L,359L,3L,656L,3L,1306L,141L,2057L,3L,5446L,36L,8201L,544L,18610L,3L,34969L,3L,72385L,2061L,131081L,165L,290362L,3L,524297L,8205L,1109206L,3L,2130073L,3L,4371490L,33594L,8388617L,3L,17445321L,132L,33556496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279789Inst : IEnumerable<long>
{
public static readonly long[] Value=A279789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279789.Bytes);
public long this[int i]=>Value[i];

public static A279789Inst Instance=new A279789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279790
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,11L,12L,18L,24L,49L,53L,82L,102L,149L,236L,297L,392L,540L,702L,924L,1423L,1723L,2318L,3016L,3969L,5037L,6647L,9285L,11448L,15048L,19143L,24695L,31288L,40075L,50014L,68583L,83056L,107252L,133796L,171565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279790Inst : IEnumerable<long>
{
public static readonly long[] Value=A279790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279790.Bytes);
public long this[int i]=>Value[i];

public static A279790Inst Instance=new A279790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279791
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,6L,5L,8L,8L,16L,12L,23L,18L,36L,33L,50L,38L,84L,54L,106L,100L,155L,104L,244L,142L,301L,270L,436L,256L,684L,340L,788L,670L,1044L,585L,1868L,760L,1878L,1600L,2647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279791Inst : IEnumerable<long>
{
public static readonly long[] Value=A279791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279791.Bytes);
public long this[int i]=>Value[i];

public static A279791Inst Instance=new A279791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279792
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,0L,1L,2L,1L,0L,2L,1L,1L,2L,1L,1L,2L,0L,2L,3L,1L,1L,2L,2L,1L,2L,1L,1L,4L,1L,2L,3L,1L,2L,3L,1L,2L,2L,1L,2L,4L,0L,2L,5L,1L,1L,3L,2L,3L,4L,3L,1L,4L,3L,3L,5L,2L,1L,6L,1L,2L,5L,1L,3L,4L,2L,2L,4L,4L,3L,6L,3L,3L,7L,2L,4L,6L,1L,4L,5L,2L,2L,5L,4L,3L,5L,3L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279792Inst : IEnumerable<long>
{
public static readonly long[] Value=A279792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279792.Bytes);
public long this[int i]=>Value[i];

public static A279792Inst Instance=new A279792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279793
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,15L,19L,25L,26L,137L,141L,257L,399L,508L,524L,607L,709L,953L,989L,2484L,3196L,4538L,6448L,35401L,36106L,51530L,79327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279793Inst : IEnumerable<long>
{
public static readonly long[] Value=A279793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279793.Bytes);
public long this[int i]=>Value[i];

public static A279793Inst Instance=new A279793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279794
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,2L,2L,3L,2L,2L,2L,1L,3L,3L,1L,3L,3L,3L,3L,5L,3L,2L,4L,4L,2L,4L,3L,3L,4L,1L,3L,4L,2L,4L,4L,3L,4L,5L,4L,4L,6L,2L,3L,5L,2L,4L,5L,3L,3L,4L,3L,4L,5L,2L,2L,5L,2L,4L,5L,3L,4L,5L,3L,3L,8L,5L,3L,6L,4L,4L,8L,4L,4L,7L,3L,4L,6L,5L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279794Inst : IEnumerable<long>
{
public static readonly long[] Value=A279794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279794.Bytes);
public long this[int i]=>Value[i];

public static A279794Inst Instance=new A279794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279795
{
public static readonly long[] Value={ 5L,7L,13L,433L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279795Inst : IEnumerable<long>
{
public static readonly long[] Value=A279795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279795.Bytes);
public long this[int i]=>Value[i];

public static A279795Inst Instance=new A279795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279796
{
public static readonly long[] Value={ 820L,1276L,1422L,1926L,2080L,2640L,3160L,3186L,3250L,4446L,4720L,4930L,5370L,6006L,6546L,7386L,7450L,7476L,9066L,9276L,10626L,10836L,13146L,13300L,15640L,15666L,16056L,16060L,16446L,17020L,17466L,17550L,17766L,18040L,18910L,19176L,19230L,19416L,20736L,21000L,21246L,21310L,21376L,21726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279796Inst : IEnumerable<long>
{
public static readonly long[] Value=A279796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279796.Bytes);
public long this[int i]=>Value[i];

public static A279796Inst Instance=new A279796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279797
{
public static readonly long[] Value={ 6L,23L,31L,34L,23L,29L,20L,9L,11L,8L,6L,4L,4L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279797Inst : IEnumerable<long>
{
public static readonly long[] Value=A279797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279797.Bytes);
public long this[int i]=>Value[i];

public static A279797Inst Instance=new A279797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279798
{
public static readonly long[] Value={ 67L,104743L,8609L,281L,521L,1163L,1436471L,12391L,136343L,1483L,23663L,727L,10453L,2029L,135481883L,7429021L,2059324621L,6864415403L,3716857L,9629L,451358821L,51782483L,62504399L,439322585771L,63337L,128110399L,42209L,59569669L,111486983L,10936129L,31585821557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279798Inst : IEnumerable<long>
{
public static readonly long[] Value=A279798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279798.Bytes);
public long this[int i]=>Value[i];

public static A279798Inst Instance=new A279798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279799
{
public static readonly BigInteger[] Value={ 1L,0L,111L,100L,10001L,10L,1111100L,1000101L,100010000L,101011L,11111000010L,10001001000L,1000100000111L,1011010100L,111110011000001L,100010011101010L,10001000110100000L,10110110011111L,1111100110110010000L,1000100110111000111L,BigInteger.Parse("100010001110101011100") };
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
public class A279799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279799Inst Instance=new A279799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279800
{
public static readonly ulong[] Value={ 1L,0L,111L,10L,10001L,10000L,11111L,10100010L,10001L,1101010000L,1000011111L,100100010L,1110000010001L,101011010000L,100000110011111L,101011100100010L,101100010001L,111110011011010000L,100110110011111L,11100011101100100010UL,1110101011100010001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279800Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279800.Bytes);
public ulong this[int i]=>Value[i];

public static A279800Inst Instance=new A279800Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279801
{
public static readonly long[] Value={ 0L,2L,22L,196L,1848L,16720L,149392L,1317720L,11508016L,99674848L,857347424L,7330950944L,62366312416L,528216075200L,4456342509184L,37466616823680L,314030294836992L,2624804780948864L,21884570459044608L,182051987035756544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279801Inst : IEnumerable<long>
{
public static readonly long[] Value=A279801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279801.Bytes);
public long this[int i]=>Value[i];

public static A279801Inst Instance=new A279801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279802
{
public static readonly BigInteger[] Value={ 2L,22L,740L,19376L,507986L,12910722L,323712032L,8013623436L,196400852184L,4773606700366L,115217934303248L,2764478696453498L,65990691037253840L,1568251660224288550L,BigInteger.Parse("37123381500487456052"),BigInteger.Parse("875734939465031708698") };
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
public class A279802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279802Inst Instance=new A279802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279803
{
public static readonly BigInteger[] Value={ 4L,196L,19376L,1476500L,110514378L,8028037200L,573336320344L,40364489132724L,2810020691400808L,193831137138886892L,13268230089583775030UL,BigInteger.Parse("902385132437593702794"),BigInteger.Parse("61032878082356786970528"),BigInteger.Parse("4108195708114892413443354") };
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
public class A279803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279803Inst Instance=new A279803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279804
{
public static readonly BigInteger[] Value={ 14L,1848L,507986L,110514378L,23500346624L,4849917013896L,982389352238899L,196014655863868720L,BigInteger.Parse("38649854832515938489"),BigInteger.Parse("7547769153037869682662"),BigInteger.Parse("1462240286143581780582744"),BigInteger.Parse("281381292175354349182558964") };
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
public class A279804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279804Inst Instance=new A279804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279805
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,2L,4L,22L,22L,4L,14L,196L,740L,196L,14L,40L,1848L,19376L,19376L,1848L,40L,120L,16720L,507986L,1476500L,507986L,16720L,120L,352L,149392L,12910722L,110514378L,110514378L,12910722L,149392L,352L,1032L,1317720L,323712032L,8028037200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279805Inst : IEnumerable<long>
{
public static readonly long[] Value=A279805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279805.Bytes);
public long this[int i]=>Value[i];

public static A279805Inst Instance=new A279805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279806
{
public static readonly long[] Value={ 1L,0L,7L,4L,17L,2L,124L,69L,272L,43L,1986L,1096L,4359L,724L,31937L,17642L,70048L,11679L,511376L,282055L,1121628L,185365L,8176448L,4520767L,17927136L,2986535L,130918732L,72188429L,287160764L,47557031L,2093056404L,1155903937L,4591303512L,763603739L,33516323706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279806Inst : IEnumerable<long>
{
public static readonly long[] Value=A279806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279806.Bytes);
public long this[int i]=>Value[i];

public static A279806Inst Instance=new A279806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279807
{
public static readonly long[] Value={ 1L,0L,7L,2L,17L,16L,31L,162L,17L,848L,543L,290L,7185L,2768L,16799L,22306L,2833L,255696L,19871L,932642L,481041L,2755280L,90527L,16572194L,1024785L,59844304L,26520991L,184818466L,129218321L,962947792L,348176799L,2207098658L,901458705L,14551549648L,12717845919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279807Inst : IEnumerable<long>
{
public static readonly long[] Value=A279807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279807.Bytes);
public long this[int i]=>Value[i];

public static A279807Inst Instance=new A279807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279808
{
public static readonly long[] Value={ 1L,1L,101L,101L,10101L,10101L,1010101L,1010101L,101000001L,101111101L,10101000101L,10101110101L,1010001010101L,1011101010101L,101010101000101L,101010101111101L,10100000101000101L,10111110101110101L,1010100010001010001L,1010111010101011101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279808Inst : IEnumerable<long>
{
public static readonly long[] Value=A279808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279808.Bytes);
public long this[int i]=>Value[i];

public static A279808Inst Instance=new A279808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279809
{
public static readonly ulong[] Value={ 1L,10L,101L,1010L,10101L,101010L,1010101L,10101010L,100000101L,1011111010L,10100010101L,101011101010L,1010101000101L,10101010111010L,101000101010101L,1011111010101010L,10100010100000101L,101011101011111010L,1000101000100010101L,10111010101011101010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279809Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279809.Bytes);
public ulong this[int i]=>Value[i];

public static A279809Inst Instance=new A279809Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279810
{
public static readonly long[] Value={ 1L,1L,5L,5L,21L,21L,85L,85L,321L,381L,1349L,1397L,5205L,5973L,21829L,21885L,82245L,97653L,345169L,357725L,1332565L,1529173L,5587265L,5600605L,21058581L,24991701L,88364101L,91576149L,341071173L,391632213L,1430541573L,1434277365L,5390013717L,6400341365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279810Inst : IEnumerable<long>
{
public static readonly long[] Value=A279810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279810.Bytes);
public long this[int i]=>Value[i];

public static A279810Inst Instance=new A279810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279811
{
public static readonly long[] Value={ 1L,2L,5L,10L,21L,42L,85L,170L,261L,762L,1301L,2794L,5445L,10938L,20821L,48810L,83205L,178938L,282901L,764650L,1398085L,2796218L,4276565L,12234410L,22041861L,45067002L,85020949L,179219178L,341132613L,715848378L,1347752277L,2947202730L,5659247877L,11722750714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279811Inst : IEnumerable<long>
{
public static readonly long[] Value=A279811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279811.Bytes);
public long this[int i]=>Value[i];

public static A279811Inst Instance=new A279811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279812
{
public static readonly long[] Value={ 440L,568L,2368L,2420L,5240L,5848L,10040L,11128L,12464L,12736L,21488L,21712L,24570L,29190L,34592L,36832L,126040L,133856L,133984L,134190L,139230L,142290L,152168L,159500L,175266L,177460L,200970L,244530L,244736L,246304L,248310L,279630L,283328L,284620L,306352L,337460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279812Inst : IEnumerable<long>
{
public static readonly long[] Value=A279812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279812.Bytes);
public long this[int i]=>Value[i];

public static A279812Inst Instance=new A279812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279813
{
public static readonly long[] Value={ 2L,3L,3L,1L,3L,2L,1L,4L,2L,3L,2L,5L,5L,6L,3L,5L,4L,1L,3L,3L,2L,1L,2L,3L,3L,1L,4L,1L,2L,3L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279813Inst : IEnumerable<long>
{
public static readonly long[] Value=A279813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279813.Bytes);
public long this[int i]=>Value[i];

public static A279813Inst Instance=new A279813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279814
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,9L,10L,11L,13L,14L,17L,19L,22L,23L,25L,26L,29L,31L,34L,35L,37L,38L,41L,43L,46L,47L,49L,50L,53L,55L,58L,59L,61L,62L,65L,67L,71L,73L,74L,75L,77L,79L,80L,81L,82L,83L,85L,86L,89L,91L,94L,95L,97L,101L,103L,106L,107L,109L,113L,115L,118L,119L,121L,122L,125L,127L,131L,133L,134L,137L,139L,140L,142L,143L,145L,146L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279814Inst : IEnumerable<long>
{
public static readonly long[] Value=A279814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279814.Bytes);
public long this[int i]=>Value[i];

public static A279814Inst Instance=new A279814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279815
{
public static readonly long[] Value={ 3L,4L,7L,13L,16L,19L,20L,31L,37L,43L,61L,67L,73L,79L,97L,103L,109L,127L,139L,151L,157L,163L,181L,188L,193L,199L,211L,223L,229L,241L,271L,277L,283L,307L,313L,331L,337L,349L,367L,373L,379L,397L,409L,421L,433L,439L,457L,463L,487L,499L,523L,541L,547L,571L,577L,601L,607L,613L,619L,631L,643L,661L,673L,691L,709L,727L,733L,739L,751L,757L,769L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279815Inst : IEnumerable<long>
{
public static readonly long[] Value=A279815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279815.Bytes);
public long this[int i]=>Value[i];

public static A279815Inst Instance=new A279815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279816
{
public static readonly long[] Value={ 0L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,9L,9L,9L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,9L,9L,9L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,9L,9L,9L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279816Inst : IEnumerable<long>
{
public static readonly long[] Value=A279816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279816.Bytes);
public long this[int i]=>Value[i];

public static A279816Inst Instance=new A279816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279817
{
public static readonly long[] Value={ -1L,1L,1L,0L,1L,0L,1L,-1L,0L,1L,1L,-2L,1L,1L,-1L,1L,1L,-3L,1L,-3L,1L,2L,1L,-6L,0L,0L,0L,0L,1L,-2L,1L,-2L,-1L,5L,-1L,-4L,1L,3L,0L,3L,1L,-3L,1L,-7L,-3L,10L,1L,-9L,0L,-10L,2L,-4L,1L,-7L,2L,6L,-1L,4L,1L,-25L,1L,2L,-2L,4L,-1L,-11L,1L,6L,-1L,13L,1L,-20L,1L,-3L,-4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279817Inst : IEnumerable<long>
{
public static readonly long[] Value=A279817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279817.Bytes);
public long this[int i]=>Value[i];

public static A279817Inst Instance=new A279817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279818
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,8L,8L,16L,9L,9L,18L,28L,38L,43L,18L,53L,14L,22L,10L,7L,7L,14L,28L,68L,76L,39L,39L,51L,19L,55L,20L,14L,35L,43L,49L,86L,96L,93L,96L,117L,41L,50L,30L,27L,51L,50L,40L,40L,44L,52L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279818Inst : IEnumerable<long>
{
public static readonly long[] Value=A279818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279818.Bytes);
public long this[int i]=>Value[i];

public static A279818Inst Instance=new A279818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279819
{
public static readonly BigInteger[] Value={ 1L,0L,2L,5L,23L,106L,537L,3143L,20485L,143747L,1078660L,8680687L,74914773L,690204588L,6749661220L,69732043730L,758671016406L,8674112392913L,104037242257509L,1306629414101911L,17148719951169617L,234689253311285406L,3342159005325362828L,BigInteger.Parse("49430840838485256475") };
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
public class A279819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279819Inst Instance=new A279819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279820
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,5L,2L,5L,1L,2L,6L,1L,3L,7L,1L,3L,7L,2L,4L,8L,2L,1L,3L,9L,2L,1L,4L,9L,3L,1L,4L,10L,3L,1L,5L,11L,3L,2L,4L,11L,3L,1L,2L,5L,12L,3L,1L,2L,5L,13L,3L,1L,2L,6L,13L,4L,1L,3L,5L,14L,4L,1L,3L,6L,15L,3L,2L,3L,6L,15L,4L,2L,1L,2L,7L,16L,4L,2L,1L,3L,6L,17L,4L,2L,1L,3L,7L,17L,5L,2L,1L,3L,7L,18L,4L,3L,1L,3L,8L,19L,4L,3L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279820Inst : IEnumerable<long>
{
public static readonly long[] Value=A279820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279820.Bytes);
public long this[int i]=>Value[i];

public static A279820Inst Instance=new A279820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279821
{
public static readonly long[] Value={ 12L,30L,902L,1360L,2450L,3730L,21475L,74945L,82208L,88282L,254677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279821Inst : IEnumerable<long>
{
public static readonly long[] Value=A279821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279821.Bytes);
public long this[int i]=>Value[i];

public static A279821Inst Instance=new A279821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279822
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1100L,111L,111100L,111L,11111100L,111L,1111111100L,111L,111111001100L,1111111L,11111111000000L,1100111L,1111111111111100L,111L,111111111111011100L,1010111L,11111111111010000100UL,1001011011L,BigInteger.Parse("1111111111110110011010"),10111111000L };
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
public class A279822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279822Inst Instance=new A279822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279823
{
public static readonly BigInteger[] Value={ 1L,1L,10L,11L,11100L,1111L,1110000L,111111L,111000000L,11111111L,11100000000L,1100111111L,1111111000000L,11111111L,111001100000000L,11111111111111L,11100000000000000L,1110111111111111L,1110101000000000000L,100001011111111111L,BigInteger.Parse("110110100100000000000") };
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
public class A279823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279823Inst Instance=new A279823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279824
{
public static readonly long[] Value={ 1L,2L,2L,12L,7L,60L,7L,252L,7L,1020L,7L,4044L,127L,16320L,103L,65532L,7L,262108L,87L,1048196L,603L,4193690L,1528L,16775439L,3768L,67107375L,2376L,268424759L,18292L,1073720659L,35854L,4294934362L,82200L,17179750079L,215584L,68719423835L,130586L,274877580152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279824Inst : IEnumerable<long>
{
public static readonly long[] Value=A279824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279824.Bytes);
public long this[int i]=>Value[i];

public static A279824Inst Instance=new A279824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279825
{
public static readonly long[] Value={ 1L,1L,2L,3L,28L,15L,112L,63L,448L,255L,1792L,831L,8128L,255L,29440L,16383L,114688L,61439L,479232L,137215L,1787904L,1470463L,1036288L,15769599L,3858432L,64061439L,9732096L,247906303L,98320384L,850231295L,941129728L,1526661119L,822411264L,17009082367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279825Inst : IEnumerable<long>
{
public static readonly long[] Value=A279825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279825.Bytes);
public long this[int i]=>Value[i];

public static A279825Inst Instance=new A279825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279826
{
public static readonly ulong[] Value={ 1L,11L,110L,1110L,11010L,111010L,1101010L,11100010L,110110110L,1110110110L,11010110110L,111000110110L,1101101110110L,11101101010110L,110101101010110L,1110001101010110L,11011011100010110L,111011010110110110L,1101011010110110110L,11100011010110110110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279826Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279826.Bytes);
public ulong this[int i]=>Value[i];

public static A279826Inst Instance=new A279826Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279827
{
public static readonly ulong[] Value={ 1L,11L,11L,111L,1011L,10111L,101011L,1000111L,11011011L,110110111L,1101101011L,11011000111L,110111011011L,1101010110111L,11010101101011L,110101011000111L,1101000111011011L,11011011010110111L,110110110101101011L,1101101101011000111L,11011011000111011011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279827Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279827.Bytes);
public ulong this[int i]=>Value[i];

public static A279827Inst Instance=new A279827Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279828
{
public static readonly long[] Value={ 1L,3L,6L,14L,26L,58L,106L,226L,438L,950L,1718L,3638L,7030L,15190L,27478L,58198L,112406L,243126L,439734L,931254L,1798582L,3890102L,7035574L,14899382L,28777910L,62240182L,112571830L,238400950L,460436918L,995866038L,1801106870L,3814208950L,7367062966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279828Inst : IEnumerable<long>
{
public static readonly long[] Value=A279828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279828.Bytes);
public long this[int i]=>Value[i];

public static A279828Inst Instance=new A279828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279829
{
public static readonly long[] Value={ 1L,3L,3L,7L,11L,23L,43L,71L,219L,439L,875L,1735L,3547L,6839L,13675L,27335L,53723L,112311L,224619L,449223L,897499L,1799863L,3583339L,7150279L,14381531L,28751543L,57503083L,115006151L,230011355L,460027575L,920038763L,1839995591L,3680268763L,7359805111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279829Inst : IEnumerable<long>
{
public static readonly long[] Value=A279829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279829.Bytes);
public long this[int i]=>Value[i];

public static A279829Inst Instance=new A279829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279830
{
public static readonly long[] Value={ 4L,7L,37L,31L,91L,181L,211L,421L,631L,1891L,1261L,2521L,6931L,18481L,20791L,13861L,27721L,41581L,83161L,138601L,245701L,235621L,180181L,556921L,360361L,540541L,1670761L,1081081L,1413721L,2702701L,2162161L,6486481L,3063061L,8288281L,13430341L,6846841L,10270261L,6126121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279830Inst : IEnumerable<long>
{
public static readonly long[] Value=A279830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279830.Bytes);
public long this[int i]=>Value[i];

public static A279830Inst Instance=new A279830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279831
{
public static readonly long[] Value={ 1L,7L,13L,16L,19L,22L,25L,31L,37L,43L,46L,49L,55L,61L,64L,67L,73L,76L,79L,85L,91L,97L,103L,106L,109L,111L,115L,121L,127L,133L,136L,139L,141L,145L,148L,151L,154L,157L,163L,166L,169L,172L,175L,181L,187L,190L,191L,193L,196L,199L,205L,211L,217L,221L,223L,226L,229L,232L,235L,241L,247L,253L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279831Inst : IEnumerable<long>
{
public static readonly long[] Value=A279831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279831.Bytes);
public long this[int i]=>Value[i];

public static A279831Inst Instance=new A279831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279832
{
public static readonly BigInteger[] Value={ 1L,3L,27L,1129L,6177L,228496227L,507769159L,3411091723167L,226108446954939L,2799063804718849119L,BigInteger.Parse("56928279095622876861"),BigInteger.Parse("175898907783132547767087"),BigInteger.Parse("2387767743416733035533529"),BigInteger.Parse("617528637834242429324813087883"),BigInteger.Parse("26943941094191660800993918030539"),BigInteger.Parse("4813884370789026772162811298692933153"),BigInteger.Parse("41249694296981783922826921997571040581"),BigInteger.Parse("69502372123801730691426662081268221528029689"),BigInteger.Parse("19796290340432197210800092215751765052273983"),BigInteger.Parse("16957540878135184586375745347497078257426299617863"),BigInteger.Parse("1168637136489375278109169401471800538288143908488069") };
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
public class A279832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279832Inst Instance=new A279832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279833
{
public static readonly BigInteger[] Value={ 1L,10L,200L,14000L,112000L,5605600000L,16016000000L,133413280000000L,10673062400000000L,BigInteger.Parse("156146902912000000000"),BigInteger.Parse("3690744977920000000000"),BigInteger.Parse("13072618711792640000000000"),BigInteger.Parse("201117210950656000000000000"),BigInteger.Parse("58382315166865930240000000000000"),BigInteger.Parse("2835712450962059468800000000000000") };
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
public class A279833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279833Inst Instance=new A279833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279834
{
public static readonly BigInteger[] Value={ 1L,3L,9L,212L,774L,2986491L,11962183L,5866732236L,24717532254L,155049859325162L,8766713183100126L,1242400321151564076L,157798597956508868L,BigInteger.Parse("141417442289739551841"),BigInteger.Parse("3032690837599386922473477"),BigInteger.Parse("272243517649610491264579553148"),BigInteger.Parse("1244664961615535298800024043306") };
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
public class A279834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279834Inst Instance=new A279834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279835
{
public static readonly BigInteger[] Value={ 1L,5L,25L,875L,4375L,21896875L,109484375L,65143203125L,325716015625L,2382612654296875L,154869822529296875L,BigInteger.Parse("24934041427216796875"),3562005918173828125L,BigInteger.Parse("3559956170522705078125"),BigInteger.Parse("84510816662372930908203125"),BigInteger.Parse("8344175483159391333221435546875"),BigInteger.Parse("41720877415796956666107177734375"),BigInteger.Parse("11291964076972525306465238189697265625") };
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
public class A279835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279835Inst Instance=new A279835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279836
{
public static readonly BigInteger[] Value={ 1L,1L,5L,113L,4505L,324545L,34312317L,5171466801L,1036525185393L,268061777199361L,86654517306871861L,BigInteger.Parse("34236056076864607345"),BigInteger.Parse("16224034929841344607625"),BigInteger.Parse("9077085568599515191480769"),BigInteger.Parse("5918716657866577845713460525"),BigInteger.Parse("4447229534037550877037585953073"),BigInteger.Parse("3813957492790787345317821024498657"),BigInteger.Parse("3702048025219670721125627874960351233") };
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
public class A279836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279836Inst Instance=new A279836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279837
{
public static readonly BigInteger[] Value={ 1L,2L,20L,496L,23120L,1747360L,195269568L,30288321792L,6227935871232L,1639388975800832L,537520438716580864L,BigInteger.Parse("214739554795652526080"),BigInteger.Parse("102653241459277667225600"),BigInteger.Parse("57838071113129054500200448"),BigInteger.Parse("37921092324167375349735014400"),BigInteger.Parse("28616681138798042948070311264256"),BigInteger.Parse("24621851021674983535130840611749888"),BigInteger.Parse("23955560260216279396643234915721281536") };
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
public class A279837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279837Inst Instance=new A279837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279838
{
public static readonly BigInteger[] Value={ 1L,-1L,5L,-113L,4505L,-324545L,34312317L,-5171466801L,1036525185393L,-268061777199361L,86654517306871861L,BigInteger.Parse("-34236056076864607345"),BigInteger.Parse("16224034929841344607625"),BigInteger.Parse("-9077085568599515191480769"),BigInteger.Parse("5918716657866577845713460525"),BigInteger.Parse("-4447229534037550877037585953073"),BigInteger.Parse("3813957492790787345317821024498657"),BigInteger.Parse("-3702048025219670721125627874960351233") };
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
public class A279838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279838.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279838Inst Instance=new A279838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279839
{
public static readonly BigInteger[] Value={ 1L,-2L,20L,-496L,23120L,-1747360L,195269568L,-30288321792L,6227935871232L,-1639388975800832L,537520438716580864L,BigInteger.Parse("-214739554795652526080"),BigInteger.Parse("102653241459277667225600"),BigInteger.Parse("-57838071113129054500200448"),BigInteger.Parse("37921092324167375349735014400"),BigInteger.Parse("-28616681138798042948070311264256"),BigInteger.Parse("24621851021674983535130840611749888") };
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
public class A279839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279839Inst Instance=new A279839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279840
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,9L,33L,153L,723L,4209L,25377L,172689L,1269699L,9918009L,84824577L,755458281L,7273792467L,73106578017L,778521070017L,8706817538721L,101639490754563L,1247219636693481L,15865740131343201L,211222989431067321L,2910911923076727123L,BigInteger.Parse("41712768080815125969"),BigInteger.Parse("618850476497056820193"),BigInteger.Parse("9493258647299740012593"),BigInteger.Parse("150683229897137204994243"),BigInteger.Parse("2464182867193114878735129"),BigInteger.Parse("41617827328955209795843137"),BigInteger.Parse("722857076727380399275752969") };
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
public class A279840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279840Inst Instance=new A279840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279841
{
public static readonly BigInteger[] Value={ 1L,0L,-2L,6L,6L,-150L,522L,3654L,-53226L,104490L,4132458L,-47627514L,-114714954L,8856035370L,-75897566838L,-1028068746426L,31770904056534L,-135504089273430L,-8135851530983382L,169470347331164166L,532060336564506486L,BigInteger.Parse("-82392155996494676310"),BigInteger.Parse("1171058783000050544202"),BigInteger.Parse("21934887486351381588294"),BigInteger.Parse("-1082420392535043092192106"),BigInteger.Parse("7667454997532070585239850"),BigInteger.Parse("570833713563794519922918378") };
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
public class A279841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279841Inst Instance=new A279841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279842
{
public static readonly BigInteger[] Value={ 1L,-1L,-3L,21L,-21L,-549L,3933L,7029L,-342549L,2039499L,21325437L,-479621979L,1462333419L,74172750651L,-1192395763107L,-3407789304171L,380952336378411L,-4313364309242901L,-70292105696209923L,2800422902218340421L,BigInteger.Parse("-15710895178041433941"),BigInteger.Parse("-1066174951636968019749"),BigInteger.Parse("27502560229200724642653"),BigInteger.Parse("89610782410072372514229"),BigInteger.Parse("-18826208456829546478535829"),BigInteger.Parse("324641884843138083973324299") };
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
public class A279842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279842Inst Instance=new A279842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279843
{
public static readonly BigInteger[] Value={ 1L,3L,18L,189L,2907L,59373L,1520019L,46964934L,1705072680L,71304998301L,3382510434561L,179805942701262L,10604941134768027L,688310036217216666L,BigInteger.Parse("48823571643364894410"),BigInteger.Parse("3762575719966561217301"),BigInteger.Parse("313432935903428395412205"),BigInteger.Parse("28098727418570995251538128"),BigInteger.Parse("2700377607104440375587008499"),BigInteger.Parse("277246288187233901613660728700") };
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
public class A279843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279843Inst Instance=new A279843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279844
{
public static readonly BigInteger[] Value={ 1L,3L,27L,441L,10593L,338715L,13603923L,660689217L,37773985257L,2492351980659L,186888829248171L,15733456044557193L,1472423968474987185L,BigInteger.Parse("151932311464679521803"),BigInteger.Parse("17166519680224611739203"),BigInteger.Parse("2111435499783771418877073"),BigInteger.Parse("281279117575497421255121721"),BigInteger.Parse("40406056752677361995435879907"),BigInteger.Parse("6234806360224720540046684747547"),BigInteger.Parse("1029860015641146082486445487150681") };
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
public class A279844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279844Inst Instance=new A279844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279845
{
public static readonly BigInteger[] Value={ 1L,1L,7L,87L,1577L,37921L,1143991L,41734167L,1793837945L,89100737537L,5038278258759L,320488252355991L,22712229678267017L,1778818548078114337L,BigInteger.Parse("152926844472960316055"),BigInteger.Parse("14348332105800041202903"),BigInteger.Parse("1461880180517958608890585"),BigInteger.Parse("161034066043430013259095681"),BigInteger.Parse("19105043857756090069661974951"),BigInteger.Parse("2432865068875486088572762200535"),BigInteger.Parse("331511875063241457659846364208233"),BigInteger.Parse("48205214775404458968179455649349921"),BigInteger.Parse("7461345443274460130807423699070922103") };
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
public class A279845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279845Inst Instance=new A279845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279846
{
public static readonly long[] Value={ 1L,31L,37L,43L,46L,61L,67L,73L,79L,85L,91L,106L,109L,121L,127L,133L,136L,145L,151L,157L,166L,169L,181L,199L,211L,217L,226L,232L,235L,241L,253L,265L,271L,274L,277L,289L,295L,301L,307L,313L,316L,325L,331L,337L,343L,361L,379L,391L,397L,406L,409L,421L,433L,451L,463L,469L,481L,496L,505L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279846Inst : IEnumerable<long>
{
public static readonly long[] Value=A279846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279846.Bytes);
public long this[int i]=>Value[i];

public static A279846Inst Instance=new A279846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279847
{
public static readonly long[] Value={ 0L,1L,2L,7L,8L,22L,23L,44L,54L,84L,85L,151L,152L,206L,241L,326L,327L,458L,459L,605L,664L,790L,791L,1065L,1091L,1265L,1356L,1622L,1623L,2023L,2024L,2365L,2496L,2790L,2865L,3480L,3481L,3847L,4026L,4636L,4637L,5373L,5374L,6000L,6341L,6875L,6876L,7982L,8032L,8787L,9086L,9952L,9953L,11137L,11284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279847Inst : IEnumerable<long>
{
public static readonly long[] Value=A279847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279847.Bytes);
public long this[int i]=>Value[i];

public static A279847Inst Instance=new A279847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279848
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,4L,4L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279848Inst : IEnumerable<long>
{
public static readonly long[] Value=A279848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279848.Bytes);
public long this[int i]=>Value[i];

public static A279848Inst Instance=new A279848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279849
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,1L,2L,4L,3L,2L,1L,2L,1L,4L,3L,1L,2L,3L,4L,4L,3L,2L,1L,2L,1L,4L,3L,3L,4L,1L,2L,1L,2L,4L,3L,3L,4L,2L,1L,2L,1L,3L,4L,4L,3L,1L,2L,1L,2L,4L,3L,4L,3L,1L,2L,3L,4L,2L,1L,2L,1L,3L,4L,1L,3L,2L,4L,2L,4L,1L,3L,4L,2L,3L,1L,3L,1L,4L,2L,1L,3L,2L,4L,4L,2L,3L,1L,3L,1L,4L,2L,2L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279849Inst : IEnumerable<long>
{
public static readonly long[] Value=A279849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279849.Bytes);
public long this[int i]=>Value[i];

public static A279849Inst Instance=new A279849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279850
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,4L,2L,5L,1L,4L,1L,5L,3L,2L,5L,3L,1L,2L,4L,2L,5L,4L,1L,3L,1L,2L,3L,4L,5L,3L,4L,5L,1L,2L,5L,1L,2L,3L,4L,2L,3L,4L,5L,1L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,3L,5L,2L,1L,4L,5L,1L,4L,2L,3L,2L,4L,5L,3L,1L,4L,3L,1L,5L,2L,1L,2L,3L,4L,5L,3L,5L,4L,2L,1L,4L,1L,2L,5L,3L,5L,4L,1L,3L,2L,2L,3L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279850Inst : IEnumerable<long>
{
public static readonly long[] Value=A279850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279850.Bytes);
public long this[int i]=>Value[i];

public static A279850Inst Instance=new A279850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279851
{
public static readonly long[] Value={ 0L,4L,10L,24L,54L,116L,250L,528L,1118L,2348L,4930L,10312L,21542L,44900L,93450L,194176L,402926L,834972L,1728210L,3572920L,7378870L,15223764L,31379610L,64623344L,132974974L,273406476L,561726050L,1153278248L,2366208838L,4851722308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279851Inst : IEnumerable<long>
{
public static readonly long[] Value=A279851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279851.Bytes);
public long this[int i]=>Value[i];

public static A279851Inst Instance=new A279851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279852
{
public static readonly long[] Value={ 2L,10L,49L,168L,557L,1758L,5441L,16500L,49253L,145290L,424425L,1229824L,3539405L,10127350L,28832593L,81728396L,230776757L,649427170L,1821994809L,5097729560L,14227693853L,39620451150L,110107647905L,305424435364L,845754303493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279852Inst : IEnumerable<long>
{
public static readonly long[] Value=A279852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279852.Bytes);
public long this[int i]=>Value[i];

public static A279852Inst Instance=new A279852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279853
{
public static readonly long[] Value={ 2L,24L,168L,972L,5200L,26632L,134898L,668668L,3278294L,15902088L,76515244L,365585432L,1736575416L,8206953072L,38615236370L,180986296644L,845359203352L,3936439186972L,18279759467004L,84675466304900L,391350188916098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279853Inst : IEnumerable<long>
{
public static readonly long[] Value=A279853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279853.Bytes);
public long this[int i]=>Value[i];

public static A279853Inst Instance=new A279853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279854
{
public static readonly long[] Value={ 8L,54L,557L,5200L,44893L,373516L,3010179L,23836450L,185854745L,1432781380L,10940440805L,82884481996L,623764753929L,4667668549882L,34757207667097L,257707173342548L,1903562116898937L,14013650638972172L,102857118300106915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279854Inst : IEnumerable<long>
{
public static readonly long[] Value=A279854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279854.Bytes);
public long this[int i]=>Value[i];

public static A279854Inst Instance=new A279854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279855
{
public static readonly long[] Value={ 14L,116L,1758L,26632L,373516L,4989784L,64921744L,827573664L,10392951988L,129001348624L,1586027917024L,19345996306220L,234406391335134L,2824014683941452L,33854795060931456L,404112060548429912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279855Inst : IEnumerable<long>
{
public static readonly long[] Value=A279855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279855.Bytes);
public long this[int i]=>Value[i];

public static A279855Inst Instance=new A279855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279856
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,2L,2L,10L,10L,2L,8L,24L,49L,24L,8L,14L,54L,168L,168L,54L,14L,36L,116L,557L,972L,557L,116L,36L,74L,250L,1758L,5200L,5200L,1758L,250L,74L,168L,528L,5441L,26632L,44893L,26632L,5441L,528L,168L,358L,1118L,16500L,134898L,373516L,373516L,134898L,16500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279856Inst : IEnumerable<long>
{
public static readonly long[] Value=A279856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279856.Bytes);
public long this[int i]=>Value[i];

public static A279856Inst Instance=new A279856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279857
{
public static readonly long[] Value={ 5L,13L,17L,29L,37L,41L,53L,59L,61L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,163L,167L,179L,181L,191L,197L,199L,211L,223L,227L,229L,233L,239L,251L,269L,271L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279857Inst : IEnumerable<long>
{
public static readonly long[] Value=A279857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279857.Bytes);
public long this[int i]=>Value[i];

public static A279857Inst Instance=new A279857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279858
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,22L,26L,28L,36L,37L,41L,98L,117L,120L,124L,214L,222L,226L,236L,333L,338L,532L,533L,534L,538L,541L,543L,544L,743L,746L,956L,957L,958L,961L,1054L,1263L,1267L,1463L,1466L,1468L,1473L,1474L,1475L,1476L,1684L,1894L,2196L,2198L,2199L,2205L,2206L,2404L,2406L,2408L,2411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279858Inst : IEnumerable<long>
{
public static readonly long[] Value=A279858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279858.Bytes);
public long this[int i]=>Value[i];

public static A279858Inst Instance=new A279858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279859
{
public static readonly long[] Value={ 3L,-1L,2L,6L,8L,-11L,10L,-14L,0L,-16L,15L,14L,-8L,-26L,-9L,29L,-26L,-27L,-1L,37L,-34L,47L,40L,20L,-36L,26L,6L,-57L,29L,-55L,-23L,53L,-9L,58L,52L,-65L,33L,-37L,-83L,3L,24L,73L,-72L,-66L,-76L,105L,45L,-108L,84L,-84L,19L,109L,-84L,21L,-28L,-19L,-139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279859Inst : IEnumerable<long>
{
public static readonly long[] Value=A279859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279859.Bytes);
public long this[int i]=>Value[i];

public static A279859Inst Instance=new A279859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279860
{
public static readonly long[] Value={ 2L,18L,182L,1828L,98793L,987931L,4349076L,82549802L,450388721L,5291493974L,72883660263L,476539957100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279860Inst : IEnumerable<long>
{
public static readonly long[] Value=A279860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279860.Bytes);
public long this[int i]=>Value[i];

public static A279860Inst Instance=new A279860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279861
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,2L,1L,2L,2L,2L,5L,4L,6L,8L,10L,14L,23L,26L,34L,46L,64L,81L,115L,158L,199L,277L,376L,505L,684L,934L,1241L,1711L,2300L,3123L,4236L,5763L,7814L,10647L,14456L,19662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279861Inst : IEnumerable<long>
{
public static readonly long[] Value=A279861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279861.Bytes);
public long this[int i]=>Value[i];

public static A279861Inst Instance=new A279861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279862
{
public static readonly long[] Value={ 37027L,15590L,3562L,3561L,1881L,1856L,735L,588L,132L,131L,188L,111L,89L,47L,44L,32L,20L,11L,9L,8L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279862Inst : IEnumerable<long>
{
public static readonly long[] Value=A279862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279862.Bytes);
public long this[int i]=>Value[i];

public static A279862Inst Instance=new A279862Inst();

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