using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A228147
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,7L,1L,1L,7L,5L,1L,3L,7L,3L,31L,1L,1L,7L,5L,31L,21L,1L,3L,7L,15L,31L,63L,127L,1L,1L,7L,5L,31L,7L,127L,85L,1L,3L,7L,3L,31L,63L,127L,51L,511L,1L,1L,7L,5L,31L,21L,127L,85L,511L,341L,1L,3L,7L,15L,31L,63L,127L,15L,511L,1023L,2047L,1L,1L,7L,5L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228147Inst : IEnumerable<long>
{
public static readonly long[] Value=A228147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228147.Bytes);
public long this[int i]=>Value[i];

public static A228147Inst Instance=new A228147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228146
{
public static readonly long[] Value={ -3L,-5L,-1L,-9L,-5L,-3L,-17L,-3L,-5L,-1L,-33L,-17L,-9L,-1L,-3L,-65L,-11L,-17L,-3L,-5L,-1L,-129L,-65L,-33L,-17L,-9L,-5L,-3L,-257L,-43L,-65L,-11L,-17L,-1L,-5L,-1L,-513L,-257L,-129L,-13L,-33L,-17L,-9L,-1L,-3L,-1025L,-171L,-257L,-43L,-65L,-11L,-17L,-3L,-5L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228146Inst : IEnumerable<long>
{
public static readonly long[] Value=A228146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228146.Bytes);
public long this[int i]=>Value[i];

public static A228146Inst Instance=new A228146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228145
{
public static readonly long[] Value={ 3L,4L,8L,9L,10L,16L,18L,31L,34L,39L,41L,42L,55L,68L,79L,90L,95L,97L,114L,122L,148L,151L,160L,209L,265L,320L,329L,441L,457L,516L,529L,632L,640L,682L,712L,791L,1056L,1169L,1632L,1943L,2200L,2279L,2468L,2698L,2921L,2996L,3129L,3140L,3656L,3960L,4889L,5560L,5895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228145Inst : IEnumerable<long>
{
public static readonly long[] Value=A228145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228145.Bytes);
public long this[int i]=>Value[i];

public static A228145Inst Instance=new A228145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228144
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,46L,47L,48L,49L,50L,51L,52L,53L,55L,55L,56L,57L,59L,59L,60L,61L,62L,63L,64L,66L,66L,67L,68L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228144Inst : IEnumerable<long>
{
public static readonly long[] Value=A228144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228144.Bytes);
public long this[int i]=>Value[i];

public static A228144Inst Instance=new A228144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228143
{
public static readonly BigInteger[] Value={ 1L,48L,161856L,39002646528L,674708032182398976L,BigInteger.Parse("839431510934341028210638848"),BigInteger.Parse("75178263784150214825106859877233852416"),BigInteger.Parse("484905075185415831301477770434885768003422223597568"),BigInteger.Parse("225327830550164300895512117291590826401931052058453494726924435456"),BigInteger.Parse("7544971365077550026405694467600069733983243666195122776655161969325034606646263808") };
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
public class A228143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228143Inst Instance=new A228143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228142
{
public static readonly long[] Value={ 1L,21L,30L,82L,99L,183L,208L,324L,357L,505L,546L,726L,775L,987L,1044L,1288L,1353L,1629L,1702L,2010L,2091L,2431L,2520L,2892L,2989L,3393L,3498L,3934L,4047L,4515L,4636L,5136L,5265L,5797L,5934L,6498L,6643L,7239L,7392L,8020L,8181L,8841L,9010L,9702L,9879L,10603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228142Inst : IEnumerable<long>
{
public static readonly long[] Value=A228142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228142.Bytes);
public long this[int i]=>Value[i];

public static A228142Inst Instance=new A228142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228141
{
public static readonly long[] Value={ 1L,5L,21L,25L,41L,45L,61L,65L,81L,85L,101L,105L,121L,125L,141L,145L,161L,165L,181L,185L,201L,205L,221L,225L,241L,245L,261L,265L,281L,285L,301L,305L,321L,325L,341L,345L,361L,365L,381L,385L,401L,405L,421L,425L,441L,445L,461L,465L,481L,485L,501L,505L,521L,525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228141Inst : IEnumerable<long>
{
public static readonly long[] Value=A228141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228141.Bytes);
public long this[int i]=>Value[i];

public static A228141Inst Instance=new A228141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228140
{
public static readonly long[] Value={ 10L,39L,45L,58L,59L,88L,108L,116L,137L,156L,157L,186L,206L,235L,244L,255L,284L,304L,333L,334L,338L,353L,373L,382L,402L,414L,431L,451L,477L,480L,500L,529L,533L,549L,578L,598L,623L,627L,647L,665L,676L,685L,696L,717L,725L,745L,774L,794L,822L,823L,843L,845L,872L,892L,902L,912L,921L,941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228140Inst : IEnumerable<long>
{
public static readonly long[] Value=A228140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228140.Bytes);
public long this[int i]=>Value[i];

public static A228140Inst Instance=new A228140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228139
{
public static readonly long[] Value={ 23L,29L,41L,43L,47L,83L,89L,127L,149L,181L,223L,227L,229L,241L,251L,263L,271L,277L,293L,347L,349L,367L,383L,389L,419L,431L,433L,439L,457L,479L,487L,541L,587L,631L,641L,643L,647L,653L,659L,673L,677L,743L,761L,853L,857L,859L,863L,883L,887L,1123L,1229L,1279L,1297L,1423L,1459L,1489L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228139Inst : IEnumerable<long>
{
public static readonly long[] Value=A228139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228139.Bytes);
public long this[int i]=>Value[i];

public static A228139Inst Instance=new A228139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228138
{
public static readonly long[] Value={ 4L,13L,20L,50L,63L,111L,130L,196L,221L,305L,336L,438L,475L,595L,638L,776L,825L,981L,1036L,1210L,1271L,1463L,1530L,1740L,1813L,2041L,2120L,2366L,2451L,2715L,2806L,3088L,3185L,3485L,3588L,3906L,4015L,4351L,4466L,4820L,4941L,5313L,5440L,5830L,5963L,6371L,6510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228138Inst : IEnumerable<long>
{
public static readonly long[] Value=A228138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228138.Bytes);
public long this[int i]=>Value[i];

public static A228138Inst Instance=new A228138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228137
{
public static readonly long[] Value={ 1L,4L,13L,16L,25L,28L,37L,40L,49L,52L,61L,64L,73L,76L,85L,88L,97L,100L,109L,112L,121L,124L,133L,136L,145L,148L,157L,160L,169L,172L,181L,184L,193L,196L,205L,208L,217L,220L,229L,232L,241L,244L,253L,256L,265L,268L,277L,280L,289L,292L,301L,304L,313L,316L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228137Inst : IEnumerable<long>
{
public static readonly long[] Value=A228137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228137.Bytes);
public long this[int i]=>Value[i];

public static A228137Inst Instance=new A228137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228136
{
public static readonly long[] Value={ 1L,2L,4L,10L,16L,30L,103L,210L,261L,1625L,3081L,6693L,32697L,155165L,262546L,697924L,760750L,1081782L,5547049L,14637837L,18044997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228136Inst : IEnumerable<long>
{
public static readonly long[] Value=A228136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228136.Bytes);
public long this[int i]=>Value[i];

public static A228136Inst Instance=new A228136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228135
{
public static readonly long[] Value={ 278L,1945L,2545L,4045L,5389L,9134L,9289L,12634L,17678L,23578L,25034L,25178L,27289L,32245L,32689L,34889L,35078L,40234L,42289L,47578L,47789L,48979L,50579L,51434L,51589L,55534L,55634L,55934L,57289L,57779L,69334L,69478L,70178L,70234L,71945L,71989L,72134L,76345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228135Inst : IEnumerable<long>
{
public static readonly long[] Value=A228135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228135.Bytes);
public long this[int i]=>Value[i];

public static A228135Inst Instance=new A228135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228134
{
public static readonly long[] Value={ 181L,121441L,961691L,676927L,1489L,94816391L,63139423L,631273L,63885209L,52096129L,10891L,4040190601L,6992152231L,4293116141L,16141441L,44114641L,96116171L,9231348613L,4861314023L,4213398433L,5224369543L,12753163L,9821742817L,14877487L,16912769L,1276944379L,923401679401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228134Inst : IEnumerable<long>
{
public static readonly long[] Value=A228134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228134.Bytes);
public long this[int i]=>Value[i];

public static A228134Inst Instance=new A228134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228133
{
public static readonly BigInteger[] Value={ 256L,3801203878441216L,BigInteger.Parse("37676241378424125849856"),BigInteger.Parse("458674242952187370600625"),BigInteger.Parse("544126177359173833650625"),BigInteger.Parse("685460284523397245894656"),BigInteger.Parse("1608863370428370905668561"),BigInteger.Parse("3002790971698825459360000"),BigInteger.Parse("25230797696265342385603441"),BigInteger.Parse("287990971036503268357824016") };
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
public class A228133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228133Inst Instance=new A228133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228132
{
public static readonly long[] Value={ 4L,2L,1L,5L,2L,1L,3L,1L,2L,7L,2L,1L,3L,1L,2L,5L,1L,2L,4L,11L,2L,1L,3L,1L,2L,5L,1L,2L,4L,9L,1L,2L,4L,8L,19L,2L,1L,3L,1L,2L,5L,1L,2L,4L,9L,1L,2L,4L,8L,17L,1L,2L,4L,8L,16L,35L,2L,1L,3L,1L,2L,5L,1L,2L,4L,9L,1L,2L,4L,8L,17L,1L,2L,4L,8L,16L,33L,1L,2L,4L,8L,16L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228132Inst : IEnumerable<long>
{
public static readonly long[] Value=A228132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228132.Bytes);
public long this[int i]=>Value[i];

public static A228132Inst Instance=new A228132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228131
{
public static readonly long[] Value={ 0L,1L,-1L,4L,0L,6L,-7L,0L,27L,6L,-11L,-8L,0L,20L,-30L,64L,0L,-4L,-19L,0L,0L,46L,-69L,-48L,250L,106L,-9L,0L,0L,68L,-93L,0L,0L,44L,-70L,216L,0L,82L,-156L,0L,0L,60L,-43L,-88L,0L,148L,-235L,-32L,1029L,94L,-102L,0L,0L,6L,-220L,-224L,0L,-82L,-177L,0L,0L,168L,-126L,1024L,0L,304L,-67L,0L,0L,268L,-497L,0L,0L,494L,-50L,-152L,0L,276L,-395L,0L,2187L,4L,-249L,0L,0L,310L,-522L,-176L,0L,388L,-182L,0L,0L,424L,-760L,-192L,0L,202L,0L,2000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228131Inst : IEnumerable<long>
{
public static readonly long[] Value=A228131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228131.Bytes);
public long this[int i]=>Value[i];

public static A228131Inst Instance=new A228131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228130
{
public static readonly long[] Value={ 61L,227L,233L,239L,613L,2213L,7507L,13691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228130Inst : IEnumerable<long>
{
public static readonly long[] Value=A228130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228130.Bytes);
public long this[int i]=>Value[i];

public static A228130Inst Instance=new A228130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228129
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,13L,22L,34L,53L,80L,125L,184L,279L,413L,610L,891L,1306L,1883L,2724L,3902L,5576L,7919L,11227L,15808L,22222L,31085L,43361L,60242L,83493L,115261L,158750L,217925L,298408L,407430L,554986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228129Inst : IEnumerable<long>
{
public static readonly long[] Value=A228129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228129.Bytes);
public long this[int i]=>Value[i];

public static A228129Inst Instance=new A228129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228128
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,3L,3L,1L,1L,0L,1L,3L,4L,3L,1L,1L,0L,1L,4L,7L,5L,3L,1L,1L,0L,1L,5L,8L,9L,6L,3L,1L,1L,0L,1L,5L,13L,13L,10L,6L,3L,1L,1L,0L,1L,6L,14L,20L,17L,11L,6L,3L,1L,1L,0L,1L,7L,20L,27L,28L,19L,12L,6L,3L,1L,1L,0L,1L,7L,22L,38L,40L,33L,20L,12L,6L,3L,1L,1L,0L,1L,8L,29L,49L,60L,51L,37L,21L,12L,6L,3L,1L,1L,0L,1L,9L,31L,65L,85L,79L,59L,39L,22L,12L,6L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228128Inst : IEnumerable<long>
{
public static readonly long[] Value=A228128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228128.Bytes);
public long this[int i]=>Value[i];

public static A228128Inst Instance=new A228128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228127
{
public static readonly long[] Value={ 1L,2L,3L,1080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228127Inst : IEnumerable<long>
{
public static readonly long[] Value=A228127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228127.Bytes);
public long this[int i]=>Value[i];

public static A228127Inst Instance=new A228127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228126
{
public static readonly long[] Value={ 2L,3L,4L,9L,20L,24L,98L,170L,1104L,1274L,2079L,2255L,3438L,4233L,4345L,4716L,5368L,7105L,7625L,10620L,13350L,13775L,14905L,20220L,21385L,23408L,25592L,26123L,28518L,30457L,34945L,35167L,38180L,45548L,49230L,51911L,52206L,53456L,56563L,61456L,65429L,66585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228126Inst : IEnumerable<long>
{
public static readonly long[] Value=A228126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228126.Bytes);
public long this[int i]=>Value[i];

public static A228126Inst Instance=new A228126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228125
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,4L,4L,2L,1L,1L,5L,7L,5L,2L,1L,1L,6L,10L,9L,5L,2L,1L,1L,7L,14L,16L,10L,5L,2L,1L,1L,8L,19L,24L,19L,11L,5L,2L,1L,1L,9L,24L,37L,32L,21L,11L,5L,2L,1L,1L,10L,30L,51L,52L,38L,22L,11L,5L,2L,1L,1L,11L,37L,71L,79L,66L,41L,23L,11L,5L,2L,1L,1L,12L,44L,93L,117L,106L,74L,43L,23L,11L,5L,2L,1L,1L,13L,52L,122L,166L,166L,125L,80L,44L,23L,11L,5L,2L,1L,1L,14L,61L,153L,231L,251L,204L,139L,83L,45L,23L,11L,5L,2L,1L,1L,15L,70L,193L,311L,367L,322L,236L,147L,85L,45L,23L,11L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228125Inst : IEnumerable<long>
{
public static readonly long[] Value=A228125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228125.Bytes);
public long this[int i]=>Value[i];

public static A228125Inst Instance=new A228125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228124
{
public static readonly long[] Value={ 1L,14L,30L,91L,140L,285L,385L,650L,819L,1240L,1496L,2109L,2470L,3311L,3795L,4900L,5525L,6930L,7714L,9455L,10416L,12529L,13685L,16206L,17575L,20540L,22140L,25585L,27434L,31395L,33511L,38024L,40425L,45526L,48230L,53955L,56980L,63365L,66729L,73810L,77531L,85344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228124Inst : IEnumerable<long>
{
public static readonly long[] Value=A228124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228124.Bytes);
public long this[int i]=>Value[i];

public static A228124Inst Instance=new A228124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228123
{
public static readonly long[] Value={ 1L,10L,86L,581L,4148L,31984L,261080L,2208196L,19132652L,168806740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228123Inst : IEnumerable<long>
{
public static readonly long[] Value=A228123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228123.Bytes);
public long this[int i]=>Value[i];

public static A228123Inst Instance=new A228123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228122
{
public static readonly long[] Value={ 0L,40L,420L,1721L,14144L,139563L,3019035L,24304266L,206583092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228122Inst : IEnumerable<long>
{
public static readonly long[] Value=A228122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228122.Bytes);
public long this[int i]=>Value[i];

public static A228122Inst Instance=new A228122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228121
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,15L,17L,19L,21L,25L,29L,31L,35L,37L,39L,45L,47L,51L,57L,59L,61L,65L,67L,77L,79L,81L,85L,87L,89L,91L,95L,99L,105L,107L,117L,119L,121L,129L,131L,135L,141L,145L,149L,151L,155L,157L,161L,165L,169L,171L,175L,187L,189L,191L,197L,199L,201L,207L,215L,217L,219L,221L,227L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228121Inst : IEnumerable<long>
{
public static readonly long[] Value=A228121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228121.Bytes);
public long this[int i]=>Value[i];

public static A228121Inst Instance=new A228121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228120
{
public static readonly BigInteger[] Value={ 2L,10L,100L,44200L,1635400L,5315050000L,435834100000L,5370347780200000L,BigInteger.Parse("26078677338040210000000"),BigInteger.Parse("5893781078397087460000000"),BigInteger.Parse("142760638726203851727985000000000"),BigInteger.Parse("20723419838773203524537758570000000000"),BigInteger.Parse("9159751568737755957845689287940000000000"),BigInteger.Parse("2354514140744040168964234431464977000000000000") };
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
public class A228120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228120Inst Instance=new A228120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228119
{
public static readonly long[] Value={ 1L,2L,4L,6L,16L,21L,22L,23L,24L,25L,26L,27L,28L,29L,32L,34L,42L,52L,61L,65L,66L,69L,72L,83L,84L,86L,92L,98L,114L,123L,134L,138L,161L,165L,169L,176L,186L,192L,213L,216L,219L,222L,223L,228L,239L,249L,253L,256L,258L,259L,265L,273L,286L,289L,292L,293L,294L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228119Inst : IEnumerable<long>
{
public static readonly long[] Value=A228119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228119.Bytes);
public long this[int i]=>Value[i];

public static A228119Inst Instance=new A228119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228118
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,31L,37L,71L,73L,79L,97L,99L,113L,117L,131L,135L,153L,171L,199L,311L,315L,333L,337L,351L,373L,513L,531L,555L,577L,711L,733L,757L,775L,777L,919L,991L,999L,1113L,1131L,1155L,1179L,1197L,1311L,1359L,1377L,1395L,1515L,1539L,1551L,1557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228118Inst : IEnumerable<long>
{
public static readonly long[] Value=A228118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228118.Bytes);
public long this[int i]=>Value[i];

public static A228118Inst Instance=new A228118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228117
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,6L,7L,9L,10L,16L,14L,23L,24L,33L,33L,50L,50L,71L,75L,101L,103L,146L,151L,201L,211L,280L,292L,389L,409L,519L,573L,707L,765L,960L,1043L,1276L,1393L,1704L,1870L,2258L,2483L,2970L,3281L,3920L,4290L,5101L,5659L,6640L,7318L,8628L,9506L,11081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228117Inst : IEnumerable<long>
{
public static readonly long[] Value=A228117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228117.Bytes);
public long this[int i]=>Value[i];

public static A228117Inst Instance=new A228117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228116
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,-3L,-26L,200L,2154L,11484L,19600L,-477397L,-8219901L,-91253055L,-827443165L,-6390673975L,-40675147794L,-175537475858L,224340865430L,16557635792557L,240512852610684L,2400398259375610L,16146663225893061L,5309635516930146L,-2257043208658957597L,BigInteger.Parse("-52738581235904454897") };
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
public class A228116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228116Inst Instance=new A228116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228115
{
public static readonly BigInteger[] Value={ 3L,21L,143L,1061L,8366L,68932L,585881L,5094722L,45074595L,404185377L,3663479699L,33498077106L,308548877876L,2859703657128L,26646019345842L,249434445759050L,2344494354096166L,22116172789221197L,209301155352811190L,1986521422431963549L,BigInteger.Parse("18904049485198437478"),BigInteger.Parse("180323870540071281301"),BigInteger.Parse("1723847795281971132487"),BigInteger.Parse("16512536418951055856540"),BigInteger.Parse("158463448213030472998711") };
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
public class A228115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228115Inst Instance=new A228115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228114
{
public static readonly long[] Value={ -1L,0L,1L,2L,3L,-34L,-59L,-9L,176L,1749L,490L,-842L,4297L,13427L,-92418L,-253834L,925307L,2903111L,-27385699L,28776158L,81540379L,40700461L,-1160432518L,2692289572L,175794995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228114Inst : IEnumerable<long>
{
public static readonly long[] Value=A228114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228114.Bytes);
public long this[int i]=>Value[i];

public static A228114Inst Instance=new A228114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228113
{
public static readonly BigInteger[] Value={ 5L,21L,142L,1059L,8360L,68940L,586140L,5096885L,45085903L,404203228L,3663001812L,33489858047L,308457620524L,2858876200536L,26639628764285L,249393770865090L,2344318815695001L,22116397127183516L,209317713015989446L,1986761935255798075L,BigInteger.Parse("18906449883376272709") };
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
public class A228113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228113Inst Instance=new A228113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228112
{
public static readonly BigInteger[] Value={ 0L,0L,0L,-2L,-22L,-23L,1614L,21952L,200754L,1427826L,6969680L,-2536429L,-648528610L,-11247293516L,-143493754330L,-1578026921839L,-15633412845816L,-140582270611489L,-1122913035234416L,-7326349588043722L,-25245049578998081L,301375487087871682L,9140885960557495580L,BigInteger.Parse("157255672291012140238"),BigInteger.Parse("2265259467069624459434") };
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
public class A228112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228112Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228112.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228112Inst Instance=new A228112Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228111
{
public static readonly BigInteger[] Value={ 4L,21L,143L,1063L,8385L,68929L,584467L,5074924L,44885325L,402777151L,3656032622L,33492393634L,309106153431L,2870123507479L,26783122426197L,250971797533095L,2359952229466124L,22256979400698116L,210440626023838163L,1994088284872617955L,BigInteger.Parse("18931694933036811169") };
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
public class A228111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228111Inst Instance=new A228111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228110
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,1L,2L,3L,4L,5L,4L,3L,2L,1L,0L,1L,2L,3L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,1L,2L,3L,4L,5L,4L,3L,4L,5L,6L,5L,6L,7L,8L,9L,10L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,2L,3L,4L,5L,6L,7L,6L,5L,6L,7L,8L,9L,8L,9L,10L,11L,12L,13L,14L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228110Inst : IEnumerable<long>
{
public static readonly long[] Value=A228110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228110.Bytes);
public long this[int i]=>Value[i];

public static A228110Inst Instance=new A228110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228109
{
public static readonly long[] Value={ 0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,1L,0L,-1L,0L,-1L,0L,1L,2L,1L,2L,3L,4L,3L,4L,3L,2L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,3L,4L,5L,4L,5L,6L,7L,6L,5L,6L,5L,4L,5L,4L,3L,2L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228109Inst : IEnumerable<long>
{
public static readonly long[] Value=A228109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228109.Bytes);
public long this[int i]=>Value[i];

public static A228109Inst Instance=new A228109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228108
{
public static readonly long[] Value={ 4L,18L,48L,108L,204L,342L,528L,780L,1100L,1494L,1968L,2576L,3292L,4122L,5104L,6240L,7524L,8962L,10560L,12348L,14324L,16494L,18864L,21600L,24572L,27786L,31248L,34996L,39012L,43362L,48000L,52968L,58244L,63834L,69840L,76308L,83132L,90318L,97872L,105972L,114468L,123378L,132704L,142500L,152892L,163742L,175056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228108Inst : IEnumerable<long>
{
public static readonly long[] Value=A228108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228108.Bytes);
public long this[int i]=>Value[i];

public static A228108Inst Instance=new A228108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228107
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,3L,4L,1L,1L,3L,4L,5L,8L,1L,1L,3L,5L,6L,10L,12L,1L,1L,3L,6L,8L,13L,17L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228107Inst : IEnumerable<long>
{
public static readonly long[] Value=A228107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228107.Bytes);
public long this[int i]=>Value[i];

public static A228107Inst Instance=new A228107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228106
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,1L,3L,3L,1L,5L,1L,1L,1L,3L,3L,2L,5L,3L,1L,5L,4L,1L,1L,1L,4L,4L,2L,1L,7L,3L,1L,3L,7L,5L,4L,3L,1L,10L,6L,4L,2L,1L,6L,1L,1L,1L,4L,4L,3L,1L,7L,5L,1L,3L,1L,7L,6L,5L,3L,2L,3L,10L,8L,7L,3L,1L,6L,4L,3L,4L,1L,10L,9L,8L,5L,1L,6L,5L,4L,1L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228106Inst : IEnumerable<long>
{
public static readonly long[] Value=A228106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228106.Bytes);
public long this[int i]=>Value[i];

public static A228106Inst Instance=new A228106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228105
{
public static readonly long[] Value={ 0L,432L,27648L,314928L,1769472L,6750000L,20155392L,50824368L,113246208L,229582512L,432000000L,765314352L,1289945088L,2085181488L,3252759552L,4920750000L,7247757312L,10427429808L,14693280768L,20323820592L,27648000000L,37050964272L,48980118528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228105Inst : IEnumerable<long>
{
public static readonly long[] Value=A228105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228105.Bytes);
public long this[int i]=>Value[i];

public static A228105Inst Instance=new A228105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228104
{
public static readonly long[] Value={ 6L,18L,24L,54L,72L,96L,162L,216L,288L,384L,486L,648L,864L,1152L,1458L,1536L,1944L,2592L,3456L,4374L,4608L,5832L,6144L,7776L,10368L,13122L,13824L,17496L,18432L,23328L,24576L,31104L,39366L,41472L,52488L,55296L,69984L,73728L,93312L,98304L,118098L,124416L,157464L,165888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228104Inst : IEnumerable<long>
{
public static readonly long[] Value=A228104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228104.Bytes);
public long this[int i]=>Value[i];

public static A228104Inst Instance=new A228104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228103
{
public static readonly long[] Value={ 100L,121L,6084L,10000L,10201L,82369L,132496L,1000000L,1002001L,1162084L,1201216L,1656369L,1860496L,100000000L,100020001L,123121216L,330621489L,10000000000L,10000200001L,13967221489L,113322449956L,1000000000000L,1000002000001L,1786590449956L,7438023471076L,100000000000000L,100000020000001L,161983503471076L,366292019505049L,553633229065744L,674650026648676L,9553960107298321L,10000000000000000L,10000000200000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228103Inst : IEnumerable<long>
{
public static readonly long[] Value=A228103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228103.Bytes);
public long this[int i]=>Value[i];

public static A228103Inst Instance=new A228103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228102
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,9L,10L,13L,14L,15L,16L,37L,38L,39L,40L,43L,44L,45L,46L,281L,282L,311L,312L,503L,504L,505L,506L,507L,508L,541L,542L,543L,544L,545L,546L,557L,558L,559L,560L,561L,562L,593L,594L,595L,596L,597L,598L,619L,620L,621L,622L,623L,624L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228102Inst : IEnumerable<long>
{
public static readonly long[] Value=A228102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228102.Bytes);
public long this[int i]=>Value[i];

public static A228102Inst Instance=new A228102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228101
{
public static readonly long[] Value={ 0L,0L,0L,-2L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,-2L,2L,0L,-1L,0L,0L,4L,0L,2L,-1L,0L,1L,1L,0L,0L,-1L,-2L,0L,-1L,0L,0L,1L,4L,0L,2L,0L,1L,-1L,0L,1L,-1L,1L,0L,-1L,0L,0L,-1L,0L,0L,1L,0L,5L,1L,2L,1L,-1L,1L,0L,-2L,0L,2L,1L,0L,0L,2L,2L,-1L,1L,0L,0L,3L,2L,0L,4L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228101Inst : IEnumerable<long>
{
public static readonly long[] Value=A228101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228101.Bytes);
public long this[int i]=>Value[i];

public static A228101Inst Instance=new A228101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228100
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,2L,1L,1L,2L,2L,3L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,3L,1L,1L,3L,2L,4L,1L,5L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,3L,1L,1L,1L,2L,2L,2L,3L,2L,1L,4L,1L,1L,3L,3L,4L,2L,5L,1L,6L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228100Inst : IEnumerable<long>
{
public static readonly long[] Value=A228100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228100.Bytes);
public long this[int i]=>Value[i];

public static A228100Inst Instance=new A228100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228099
{
public static readonly long[] Value={ 1L,2L,6L,4L,30L,12L,8L,210L,60L,36L,24L,16L,2310L,420L,180L,120L,72L,48L,32L,30030L,4620L,1260L,840L,900L,360L,240L,216L,144L,96L,64L,510510L,60060L,13860L,9240L,6300L,2520L,1680L,1800L,1080L,720L,480L,432L,288L,192L,128L,9699690L,1021020L,180180L,120120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228099Inst : IEnumerable<long>
{
public static readonly long[] Value=A228099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228099.Bytes);
public long this[int i]=>Value[i];

public static A228099Inst Instance=new A228099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228098
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,3L,2L,1L,1L,2L,2L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,2L,1L,1L,4L,1L,2L,1L,3L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,1L,2L,4L,2L,1L,1L,2L,1L,2L,2L,2L,2L,1L,3L,2L,1L,1L,4L,2L,1L,1L,2L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228098Inst : IEnumerable<long>
{
public static readonly long[] Value=A228098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228098.Bytes);
public long this[int i]=>Value[i];

public static A228098Inst Instance=new A228098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228097
{
public static readonly long[] Value={ 30L,50L,75L,120L,195L,200L,260L,270L,300L,340L,450L,480L,510L,525L,585L,675L,700L,750L,765L,780L,800L,845L,1014L,1015L,1040L,1080L,1156L,1200L,1250L,1360L,1365L,1470L,1530L,1554L,1740L,1755L,1800L,1845L,1875L,1920L,2040L,2100L,2210L,2220L,2275L,2340L,2430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228097Inst : IEnumerable<long>
{
public static readonly long[] Value=A228097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228097.Bytes);
public long this[int i]=>Value[i];

public static A228097Inst Instance=new A228097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228096
{
public static readonly long[] Value={ 1L,9L,15L,33L,39L,51L,55L,57L,75L,77L,93L,99L,111L,117L,135L,153L,155L,159L,171L,177L,195L,315L,333L,339L,351L,355L,357L,375L,393L,399L,513L,515L,519L,531L,535L,537L,551L,553L,555L,559L,573L,579L,591L,595L,597L,711L,717L,735L,753L,759L,771L,777L,795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228096Inst : IEnumerable<long>
{
public static readonly long[] Value=A228096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228096.Bytes);
public long this[int i]=>Value[i];

public static A228096Inst Instance=new A228096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228047
{
public static readonly long[] Value={ 4L,2L,3L,5L,3L,9L,0L,9L,9L,6L,0L,8L,7L,0L,0L,1L,9L,6L,8L,3L,7L,6L,0L,7L,6L,8L,9L,9L,7L,4L,4L,2L,8L,9L,3L,7L,5L,4L,4L,3L,2L,2L,8L,8L,1L,8L,9L,4L,1L,7L,1L,1L,1L,0L,2L,1L,7L,5L,6L,0L,8L,4L,2L,8L,1L,3L,0L,9L,3L,4L,7L,8L,2L,4L,5L,8L,2L,6L,7L,1L,1L,7L,8L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228047Inst : IEnumerable<long>
{
public static readonly long[] Value=A228047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228047.Bytes);
public long this[int i]=>Value[i];

public static A228047Inst Instance=new A228047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228046
{
public static readonly long[] Value={ 5L,3L,5L,6L,3L,6L,1L,9L,4L,7L,8L,0L,7L,8L,7L,2L,8L,4L,5L,5L,7L,8L,5L,0L,7L,4L,8L,6L,6L,4L,7L,1L,8L,6L,0L,7L,0L,0L,4L,3L,5L,4L,9L,4L,9L,6L,9L,1L,0L,7L,9L,6L,2L,2L,7L,7L,5L,5L,2L,0L,9L,8L,4L,9L,1L,8L,8L,7L,9L,3L,3L,8L,3L,3L,6L,0L,7L,1L,3L,2L,4L,9L,7L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228046Inst : IEnumerable<long>
{
public static readonly long[] Value=A228046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228046.Bytes);
public long this[int i]=>Value[i];

public static A228046Inst Instance=new A228046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228045
{
public static readonly long[] Value={ 7L,2L,6L,8L,0L,0L,6L,1L,9L,4L,6L,4L,9L,3L,5L,7L,7L,8L,1L,7L,9L,1L,4L,3L,0L,0L,7L,1L,9L,4L,4L,3L,5L,3L,8L,3L,9L,0L,8L,7L,7L,4L,6L,2L,7L,6L,3L,6L,0L,7L,7L,7L,3L,2L,3L,8L,9L,9L,7L,2L,6L,1L,3L,4L,0L,1L,3L,4L,6L,7L,2L,7L,2L,0L,1L,4L,8L,5L,9L,5L,2L,6L,4L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228045Inst : IEnumerable<long>
{
public static readonly long[] Value=A228045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228045.Bytes);
public long this[int i]=>Value[i];

public static A228045Inst Instance=new A228045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228044
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,9L,4L,6L,0L,6L,6L,0L,3L,5L,0L,4L,3L,4L,3L,5L,4L,3L,4L,3L,2L,1L,8L,5L,9L,7L,9L,2L,5L,5L,9L,9L,2L,0L,2L,4L,3L,5L,0L,0L,8L,4L,2L,6L,9L,4L,6L,5L,5L,6L,7L,8L,8L,6L,4L,8L,1L,7L,3L,4L,3L,0L,8L,9L,9L,0L,3L,8L,1L,2L,1L,3L,5L,0L,3L,9L,6L,5L,8L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228044Inst : IEnumerable<long>
{
public static readonly long[] Value=A228044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228044.Bytes);
public long this[int i]=>Value[i];

public static A228044Inst Instance=new A228044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228043
{
public static readonly long[] Value={ 2L,1L,4L,9L,7L,1L,4L,1L,6L,5L,6L,0L,7L,9L,4L,3L,8L,8L,2L,9L,3L,0L,0L,2L,8L,2L,5L,7L,2L,9L,7L,3L,1L,7L,9L,4L,9L,2L,2L,2L,2L,6L,2L,8L,3L,4L,3L,2L,9L,9L,2L,1L,2L,1L,6L,2L,3L,8L,8L,8L,4L,5L,3L,8L,3L,1L,2L,8L,2L,5L,7L,9L,7L,4L,9L,1L,7L,0L,8L,4L,5L,9L,0L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228043Inst : IEnumerable<long>
{
public static readonly long[] Value=A228043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228043.Bytes);
public long this[int i]=>Value[i];

public static A228043Inst Instance=new A228043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228042
{
public static readonly long[] Value={ 2L,8L,6L,6L,2L,8L,5L,5L,5L,4L,1L,4L,3L,9L,2L,5L,1L,7L,7L,2L,4L,0L,0L,3L,7L,6L,7L,6L,3L,9L,6L,4L,2L,3L,9L,3L,2L,2L,9L,6L,3L,5L,0L,4L,4L,5L,7L,7L,3L,2L,2L,8L,2L,8L,8L,3L,1L,8L,5L,1L,2L,7L,1L,7L,7L,5L,0L,4L,3L,4L,3L,9L,6L,6L,5L,5L,6L,1L,1L,2L,7L,8L,7L,1L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228042Inst : IEnumerable<long>
{
public static readonly long[] Value=A228042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228042.Bytes);
public long this[int i]=>Value[i];

public static A228042Inst Instance=new A228042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228041
{
public static readonly long[] Value={ 4L,2L,9L,9L,4L,2L,8L,3L,3L,1L,2L,1L,5L,8L,8L,7L,7L,6L,5L,8L,6L,0L,0L,5L,6L,5L,1L,4L,5L,9L,4L,6L,3L,5L,8L,9L,8L,4L,4L,4L,5L,2L,5L,6L,6L,8L,6L,5L,9L,8L,4L,2L,4L,3L,2L,4L,7L,7L,7L,6L,9L,0L,7L,6L,6L,2L,5L,6L,5L,1L,5L,9L,4L,9L,8L,3L,4L,1L,6L,9L,1L,8L,0L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228041Inst : IEnumerable<long>
{
public static readonly long[] Value=A228041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228041.Bytes);
public long this[int i]=>Value[i];

public static A228041Inst Instance=new A228041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228040
{
public static readonly long[] Value={ 6L,2L,9L,5L,2L,4L,8L,3L,9L,8L,7L,6L,3L,1L,2L,4L,4L,9L,5L,3L,5L,4L,6L,1L,7L,9L,5L,3L,4L,1L,8L,5L,0L,1L,9L,3L,3L,1L,6L,2L,5L,9L,6L,8L,3L,8L,2L,8L,8L,8L,6L,0L,8L,7L,7L,9L,7L,3L,8L,1L,9L,0L,7L,0L,8L,3L,7L,2L,8L,2L,7L,4L,2L,1L,3L,1L,2L,7L,0L,4L,4L,6L,4L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228040Inst : IEnumerable<long>
{
public static readonly long[] Value=A228040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228040.Bytes);
public long this[int i]=>Value[i];

public static A228040Inst Instance=new A228040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228039
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228039Inst : IEnumerable<long>
{
public static readonly long[] Value=A228039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228039.Bytes);
public long this[int i]=>Value[i];

public static A228039Inst Instance=new A228039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228038
{
public static readonly long[] Value={ 2L,6L,14L,30L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228038Inst : IEnumerable<long>
{
public static readonly long[] Value=A228038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228038.Bytes);
public long this[int i]=>Value[i];

public static A228038Inst Instance=new A228038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228037
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,1L,5L,1L,1L,7L,1L,5L,9L,1L,1L,11L,0L,1L,13L,1L,1L,24L,1L,7L,17L,1L,0L,19L,1L,1L,21L,13L,1L,23L,1L,1L,25L,0L,1L,27L,1L,17L,29L,1L,13L,31L,0L,1L,33L,1L,1L,56L,1L,1L,37L,1L,0L,39L,0L,11L,41L,25L,1L,43L,1L,19L,45L,1L,1L,47L,0L,29L,49L,1L,1L,51L,0L,1L,53L,0L,1L,88L,1L,13L,57L,1L,25L,59L,1L,1L,61L,37L,0L,63L,1L,1L,65L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228037Inst : IEnumerable<long>
{
public static readonly long[] Value=A228037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228037.Bytes);
public long this[int i]=>Value[i];

public static A228037Inst Instance=new A228037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228036
{
public static readonly long[] Value={ 1L,605L,51005L,5837732L,599407380L,60462121402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228036Inst : IEnumerable<long>
{
public static readonly long[] Value=A228036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228036.Bytes);
public long this[int i]=>Value[i];

public static A228036Inst Instance=new A228036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228035
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,7L,1L,3L,7L,15L,1L,1L,1L,5L,31L,1L,3L,7L,15L,31L,63L,1L,1L,7L,1L,31L,21L,127L,1L,3L,1L,15L,31L,9L,127L,255L,1L,1L,7L,5L,1L,21L,127L,85L,511L,1L,3L,7L,15L,31L,63L,127L,255L,511L,1023L,1L,1L,1L,1L,31L,1L,127L,17L,73L,341L,2047L,1L,3L,7L,15L,31L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228035Inst : IEnumerable<long>
{
public static readonly long[] Value=A228035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228035.Bytes);
public long this[int i]=>Value[i];

public static A228035Inst Instance=new A228035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228034
{
public static readonly BigInteger[] Value={ 3L,11L,83L,6563L,59051L,4782971L,282429536483L,2541865828331L,150094635296999123L,BigInteger.Parse("57264168970223481226273458862846808078011946891"),BigInteger.Parse("30432527221704537086371993251530170531786747066637051") };
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
public class A228034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228034.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228034Inst Instance=new A228034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228033
{
public static readonly BigInteger[] Value={ 13L,BigInteger.Parse("2787593149816327892691964784081045188247557"),BigInteger.Parse("15177100720513508366558296147058741458143803430094840009779784451085189728165691397") };
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
public class A228033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228033Inst Instance=new A228033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228032
{
public static readonly BigInteger[] Value={ 11L,67L,4099L,32771L,262147L,1073741827L,BigInteger.Parse("19342813113834066795298819") };
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
public class A228032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228032Inst Instance=new A228032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227967
{
public static readonly long[] Value={ 4L,6L,6L,7L,7L,8L,3L,4L,6L,6L,1L,2L,6L,6L,2L,4L,2L,5L,6L,1L,1L,8L,8L,1L,6L,9L,9L,5L,1L,7L,1L,1L,5L,5L,8L,3L,1L,6L,0L,3L,8L,3L,4L,9L,7L,2L,4L,8L,6L,8L,7L,3L,3L,3L,9L,4L,5L,7L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227967Inst : IEnumerable<long>
{
public static readonly long[] Value=A227967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227967.Bytes);
public long this[int i]=>Value[i];

public static A227967Inst Instance=new A227967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227966
{
public static readonly long[] Value={ 1L,5L,4L,0L,6L,8L,4L,3L,2L,6L,4L,8L,6L,0L,7L,1L,6L,4L,5L,0L,6L,1L,5L,6L,1L,5L,0L,7L,2L,9L,3L,9L,2L,0L,5L,2L,0L,1L,8L,7L,5L,2L,5L,9L,6L,7L,2L,6L,2L,2L,8L,6L,5L,7L,3L,5L,4L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227966Inst : IEnumerable<long>
{
public static readonly long[] Value=A227966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227966.Bytes);
public long this[int i]=>Value[i];

public static A227966Inst Instance=new A227966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227965
{
public static readonly long[] Value={ 11L,53L,249L,1164L,5435L,25371L,118428L,552798L,2580343L,12044484L,56221045L,262427666L,1224955522L,5717827134L,26689578960L,124581175389L,581517950673L,2714399875409L,12670230858892L,59141894115145L,276061555506087L,1288595564424512L,6014885070144844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227965Inst : IEnumerable<long>
{
public static readonly long[] Value=A227965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227965.Bytes);
public long this[int i]=>Value[i];

public static A227965Inst Instance=new A227965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227964
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,1L,1L,-2L,-1L,4L,-1L,-2L,1L,1L,-3L,0L,8L,-6L,-6L,8L,0L,-3L,1L,1L,-4L,2L,12L,-17L,-8L,28L,-8L,-17L,12L,2L,-4L,1L,1L,-5L,5L,15L,-35L,-1L,65L,-45L,-45L,65L,-1L,-35L,15L,5L,-5L,1L,1L,-6L,9L,16L,-60L,24L,116L,-144L,-66L,220L,-66L,-144L,116L,24L,-60L,16L,9L,-6L,1L,1L,-7L,14L,14L,-91L,77L,168L,-344L,-14L,546L,-364L,-364L,546L,-14L,-344L,168L,77L,-91L,14L,14L,-7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227964Inst : IEnumerable<long>
{
public static readonly long[] Value=A227964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227964.Bytes);
public long this[int i]=>Value[i];

public static A227964Inst Instance=new A227964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227963
{
public static readonly long[] Value={ 1L,3L,5L,6L,15L,17L,18L,51L,20L,85L,105L,24L,102L,90L,60L,255L,257L,258L,771L,260L,1285L,1545L,264L,1542L,1290L,780L,3855L,272L,4369L,4641L,5185L,6273L,288L,4626L,4386L,6210L,5250L,816L,13107L,15555L,320L,5140L,6180L,4420L,4740L,1360L,21845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227963Inst : IEnumerable<long>
{
public static readonly long[] Value=A227963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227963.Bytes);
public long this[int i]=>Value[i];

public static A227963Inst Instance=new A227963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227962
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,2L,0L,7L,3L,5L,1L,6L,2L,4L,0L,15L,7L,12L,3L,13L,5L,9L,1L,14L,6L,10L,11L,2L,4L,8L,0L,31L,15L,26L,7L,28L,12L,20L,3L,29L,13L,22L,23L,5L,9L,17L,1L,30L,14L,24L,25L,6L,27L,10L,11L,18L,19L,2L,21L,4L,8L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227962Inst : IEnumerable<long>
{
public static readonly long[] Value=A227962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227962.Bytes);
public long this[int i]=>Value[i];

public static A227962Inst Instance=new A227962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227961
{
public static readonly long[] Value={ 2L,3L,2L,4L,8L,2L,2L,5L,22L,8L,24L,2L,2L,2L,2L,6L,52L,22L,150L,8L,24L,24L,72L,2L,2L,2L,2L,2L,2L,2L,2L,7L,114L,52L,740L,22L,150L,150L,1046L,8L,24L,24L,72L,24L,72L,72L,216L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,8L,240L,114L,3282L,52L,740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227961Inst : IEnumerable<long>
{
public static readonly long[] Value=A227961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227961.Bytes);
public long this[int i]=>Value[i];

public static A227961Inst Instance=new A227961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227960
{
public static readonly long[] Value={ 1L,3L,6L,15L,24L,60L,105L,255L,384L,960L,1632L,1680L,4080L,15555L,27030L,65535L,98304L,245760L,417792L,430080L,1044480L,1582080L,3947520L,3982080L,6908160L,6919680L,16776960L,106991625L,267448335L,1019462460L,1771476585L,4294967295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227960Inst : IEnumerable<long>
{
public static readonly long[] Value=A227960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227960.Bytes);
public long this[int i]=>Value[i];

public static A227960Inst Instance=new A227960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227959
{
public static readonly long[] Value={ 1L,1L,4L,6L,20L,38L,104L,220L,556L,1244L,3024L,6944L,16576L,38536L,91216L,213280L,502864L,1178928L,2774592L,6512864L,15315072L,35969952L,84550912L,198634048L,466825152L,1096838208L,2577550336L,6056474880L,14232064256L,33441977216L,78583660288L,184655188480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227959Inst : IEnumerable<long>
{
public static readonly long[] Value=A227959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227959.Bytes);
public long this[int i]=>Value[i];

public static A227959Inst Instance=new A227959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227958
{
public static readonly long[] Value={ 7L,0L,2L,1L,8L,8L,5L,0L,1L,3L,2L,6L,5L,5L,9L,5L,9L,6L,2L,3L,8L,1L,8L,7L,4L,7L,9L,7L,4L,6L,2L,1L,8L,0L,6L,3L,5L,0L,4L,5L,3L,0L,5L,1L,7L,0L,3L,8L,9L,6L,2L,0L,7L,6L,6L,6L,2L,8L,9L,4L,3L,2L,8L,6L,8L,7L,8L,7L,9L,6L,3L,0L,8L,2L,3L,5L,4L,5L,3L,0L,1L,1L,2L,8L,1L,7L,9L,1L,7L,7L,2L,1L,4L,5L,2L,8L,4L,2L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227958Inst : IEnumerable<long>
{
public static readonly long[] Value=A227958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227958.Bytes);
public long this[int i]=>Value[i];

public static A227958Inst Instance=new A227958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227957
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,0L,2L,0L,2L,1L,1L,1L,2L,1L,1L,0L,1L,2L,3L,1L,2L,0L,2L,1L,1L,1L,1L,0L,2L,1L,2L,0L,3L,1L,1L,2L,1L,2L,2L,0L,1L,1L,2L,2L,2L,0L,2L,2L,1L,2L,0L,0L,2L,2L,1L,0L,1L,1L,3L,2L,3L,1L,3L,0L,0L,1L,2L,2L,3L,0L,1L,1L,3L,2L,3L,0L,1L,2L,2L,1L,1L,0L,2L,1L,2L,1L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227957Inst : IEnumerable<long>
{
public static readonly long[] Value=A227957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227957.Bytes);
public long this[int i]=>Value[i];

public static A227957Inst Instance=new A227957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227956
{
public static readonly long[] Value={ 3L,4L,6L,8L,12L,14L,18L,20L,24L,30L,32L,38L,44L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227956Inst : IEnumerable<long>
{
public static readonly long[] Value=A227956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227956.Bytes);
public long this[int i]=>Value[i];

public static A227956Inst Instance=new A227956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227955
{
public static readonly long[] Value={ 1L,2L,6L,4L,30L,12L,8L,210L,60L,36L,24L,16L,2310L,420L,180L,120L,72L,48L,32L,30030L,4620L,1260L,900L,840L,360L,216L,240L,144L,96L,64L,510510L,60060L,13860L,6300L,9240L,2520L,1800L,1080L,1680L,720L,432L,480L,288L,192L,128L,9699690L,1021020L,180180L,69300L,44100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227955Inst : IEnumerable<long>
{
public static readonly long[] Value=A227955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227955.Bytes);
public long this[int i]=>Value[i];

public static A227955Inst Instance=new A227955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227954
{
public static readonly long[] Value={ 3L,15L,78L,115L,155L,310L,231L,911L,619L,691L,464L,863L,1294L,1616L,3240L,2235L,1240L,2240L,3472L,3183L,4479L,2766L,4148L,9212L,6588L,4567L,2587L,2588L,4846L,6479L,3231L,7763L,3744L,3743L,2479L,2480L,6367L,7440L,12936L,2768L,9914L,9395L,13415L,11059L,9792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227954Inst : IEnumerable<long>
{
public static readonly long[] Value=A227954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227954.Bytes);
public long this[int i]=>Value[i];

public static A227954Inst Instance=new A227954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227953
{
public static readonly long[] Value={ 3L,1L,30L,63L,187L,232L,348L,375L,912L,620L,692L,463L,864L,2303L,1615L,2806L,4844L,1239L,2239L,1383L,1835L,2236L,3716L,6575L,3447L,3670L,1384L,6894L,13422L,7486L,9131L,6462L,6480L,13703L,13039L,4958L,9908L,6368L,9912L,5534L,2767L,12734L,9719L,16598L,11060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227953Inst : IEnumerable<long>
{
public static readonly long[] Value=A227953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227953.Bytes);
public long this[int i]=>Value[i];

public static A227953Inst Instance=new A227953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227952
{
public static readonly long[] Value={ 6L,15L,27L,31L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227952Inst : IEnumerable<long>
{
public static readonly long[] Value=A227952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227952.Bytes);
public long this[int i]=>Value[i];

public static A227952Inst Instance=new A227952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194331
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,2L,4L,5L,3L,4L,5L,5L,5L,5L,5L,7L,5L,6L,7L,6L,5L,7L,7L,7L,7L,7L,7L,7L,8L,8L,9L,7L,9L,7L,8L,8L,10L,9L,8L,10L,9L,9L,9L,9L,8L,10L,9L,11L,10L,9L,11L,10L,10L,10L,10L,11L,11L,11L,12L,11L,11L,12L,10L,11L,11L,10L,13L,11L,12L,13L,11L,12L,13L,12L,11L,13L,12L,11L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194331Inst : IEnumerable<long>
{
public static readonly long[] Value=A194331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194331.Bytes);
public long this[int i]=>Value[i];

public static A194331Inst Instance=new A194331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194330
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,1L,2L,3L,1L,3L,1L,3L,2L,2L,2L,2L,1L,3L,1L,2L,2L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,2L,2L,2L,1L,3L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194330Inst : IEnumerable<long>
{
public static readonly long[] Value=A194330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194330.Bytes);
public long this[int i]=>Value[i];

public static A194330Inst Instance=new A194330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194329
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,2L,0L,1L,1L,1L,1L,1L,2L,1L,1L,0L,2L,0L,1L,1L,1L,1L,1L,1L,2L,0L,2L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194329Inst : IEnumerable<long>
{
public static readonly long[] Value=A194329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194329.Bytes);
public long this[int i]=>Value[i];

public static A194329Inst Instance=new A194329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194328
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,6L,6L,7L,7L,6L,10L,11L,10L,11L,11L,11L,18L,18L,18L,18L,19L,18L,19L,32L,32L,32L,31L,33L,31L,33L,32L,57L,57L,56L,57L,57L,57L,58L,56L,57L,101L,103L,102L,103L,101L,104L,102L,103L,102L,103L,185L,188L,186L,186L,185L,187L,187L,186L,187L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194328Inst : IEnumerable<long>
{
public static readonly long[] Value=A194328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194328.Bytes);
public long this[int i]=>Value[i];

public static A194328Inst Instance=new A194328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194327
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,4L,6L,6L,5L,7L,6L,6L,7L,7L,6L,7L,8L,7L,7L,7L,8L,9L,7L,9L,8L,7L,9L,9L,9L,9L,9L,9L,9L,10L,9L,8L,9L,10L,10L,10L,10L,11L,10L,10L,10L,10L,10L,12L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194327Inst : IEnumerable<long>
{
public static readonly long[] Value=A194327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194327.Bytes);
public long this[int i]=>Value[i];

public static A194327Inst Instance=new A194327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194326
{
public static readonly long[] Value={ 2L,2L,2L,1L,3L,2L,2L,1L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,3L,1L,2L,2L,2L,3L,1L,3L,1L,3L,1L,2L,2L,1L,3L,2L,2L,2L,2L,2L,1L,3L,2L,2L,1L,3L,2L,3L,1L,2L,1L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,1L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194326Inst : IEnumerable<long>
{
public static readonly long[] Value=A194326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194326.Bytes);
public long this[int i]=>Value[i];

public static A194326Inst Instance=new A194326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194325
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,0L,2L,1L,1L,0L,2L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,1L,2L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194325Inst : IEnumerable<long>
{
public static readonly long[] Value=A194325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194325.Bytes);
public long this[int i]=>Value[i];

public static A194325Inst Instance=new A194325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194324
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,6L,6L,6L,8L,6L,11L,10L,11L,11L,11L,10L,19L,18L,18L,19L,18L,19L,17L,33L,32L,31L,32L,32L,32L,32L,32L,56L,58L,57L,57L,57L,56L,57L,56L,58L,103L,102L,102L,103L,102L,102L,103L,103L,102L,102L,186L,186L,188L,184L,188L,186L,185L,187L,186L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194324Inst : IEnumerable<long>
{
public static readonly long[] Value=A194324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194324.Bytes);
public long this[int i]=>Value[i];

public static A194324Inst Instance=new A194324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194323
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,4L,4L,4L,4L,5L,4L,5L,6L,5L,6L,5L,7L,6L,7L,5L,7L,7L,6L,7L,8L,7L,7L,8L,8L,8L,8L,8L,9L,8L,7L,8L,10L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,11L,10L,9L,11L,11L,11L,10L,12L,11L,11L,11L,11L,12L,10L,12L,13L,11L,11L,13L,12L,12L,11L,13L,13L,11L,12L,13L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194323Inst : IEnumerable<long>
{
public static readonly long[] Value=A194323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194323.Bytes);
public long this[int i]=>Value[i];

public static A194323Inst Instance=new A194323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194322
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,2L,2L,1L,3L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,3L,1L,2L,3L,2L,1L,2L,2L,2L,1L,3L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,1L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194322Inst : IEnumerable<long>
{
public static readonly long[] Value=A194322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194322.Bytes);
public long this[int i]=>Value[i];

public static A194322Inst Instance=new A194322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194321
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,1L,0L,2L,1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,1L,1L,1L,1L,1L,0L,2L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194321Inst : IEnumerable<long>
{
public static readonly long[] Value=A194321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194321.Bytes);
public long this[int i]=>Value[i];

public static A194321Inst Instance=new A194321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194320
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,2L,6L,3L,5L,6L,6L,7L,7L,6L,11L,10L,11L,11L,11L,10L,19L,18L,18L,18L,18L,19L,18L,31L,32L,32L,33L,31L,32L,32L,33L,56L,57L,58L,55L,57L,58L,56L,58L,57L,102L,102L,101L,104L,103L,102L,103L,102L,103L,102L,185L,186L,185L,186L,186L,186L,187L,186L,187L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194320Inst : IEnumerable<long>
{
public static readonly long[] Value=A194320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194320.Bytes);
public long this[int i]=>Value[i];

public static A194320Inst Instance=new A194320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194319
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,2L,6L,3L,5L,4L,5L,5L,6L,5L,6L,5L,6L,6L,7L,6L,7L,6L,6L,7L,8L,8L,7L,8L,8L,8L,8L,8L,8L,7L,9L,8L,9L,10L,7L,10L,10L,8L,10L,9L,9L,11L,9L,11L,9L,11L,8L,12L,9L,11L,9L,11L,11L,12L,11L,11L,11L,10L,12L,11L,12L,12L,12L,11L,13L,11L,13L,11L,13L,11L,13L,12L,12L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194319Inst : IEnumerable<long>
{
public static readonly long[] Value=A194319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194319.Bytes);
public long this[int i]=>Value[i];

public static A194319Inst Instance=new A194319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194318
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,3L,3L,2L,1L,1L,3L,3L,1L,2L,3L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,2L,1L,3L,2L,2L,3L,1L,3L,1L,2L,2L,2L,2L,2L,3L,1L,3L,1L,3L,2L,2L,1L,3L,1L,3L,1L,3L,1L,3L,2L,2L,1L,3L,1L,2L,1L,3L,1L,3L,2L,2L,3L,2L,2L,1L,3L,1L,3L,1L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194318Inst : IEnumerable<long>
{
public static readonly long[] Value=A194318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194318.Bytes);
public long this[int i]=>Value[i];

public static A194318Inst Instance=new A194318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194317
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,0L,2L,2L,0L,2L,1L,0L,1L,1L,1L,2L,0L,2L,1L,1L,1L,0L,2L,0L,2L,0L,2L,1L,1L,1L,1L,1L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,1L,1L,1L,1L,0L,2L,0L,3L,0L,2L,0L,2L,0L,1L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194317Inst : IEnumerable<long>
{
public static readonly long[] Value=A194317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194317.Bytes);
public long this[int i]=>Value[i];

public static A194317Inst Instance=new A194317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194316
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,4L,5L,3L,4L,6L,7L,7L,6L,6L,9L,11L,12L,9L,12L,11L,18L,18L,18L,19L,19L,18L,18L,31L,33L,32L,33L,30L,33L,31L,33L,56L,57L,57L,58L,57L,56L,57L,57L,57L,103L,102L,103L,103L,103L,101L,102L,102L,103L,102L,186L,186L,186L,186L,187L,186L,186L,186L,186L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194316Inst : IEnumerable<long>
{
public static readonly long[] Value=A194316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194316.Bytes);
public long this[int i]=>Value[i];

public static A194316Inst Instance=new A194316Inst();

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