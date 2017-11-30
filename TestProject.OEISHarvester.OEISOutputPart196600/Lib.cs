using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A227057
{
public static readonly long[] Value={ 20L,124L,643L,2934L,11810L,42295L,136553L,402898L,1099681L,2805516L,6748051L,15412421L,33626114L,70430760L,142218700L,277853319L,526833214L,972034792L,1749218167L,3076360168L,5297051430L,8943742393L,14828643583L,24172697248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227057Inst : IEnumerable<long>
{
public static readonly long[] Value=A227057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227057.Bytes);
public long this[int i]=>Value[i];

public static A227057Inst Instance=new A227057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227058
{
public static readonly long[] Value={ 35L,329L,2934L,24511L,183000L,1202223L,6979049L,36211854L,170079551L,731624081L,2911895167L,10815978236L,37768115156L,124748330535L,391810133572L,1175449312194L,3381493985505L,9359644588159L,25000202714038L,64609485660739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227058Inst : IEnumerable<long>
{
public static readonly long[] Value=A227058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227058.Bytes);
public long this[int i]=>Value[i];

public static A227058Inst Instance=new A227058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227059
{
public static readonly long[] Value={ 56L,777L,11810L,183000L,2625106L,33345171L,371484306L,3651371505L,32017940207L,253426591748L,1830279313794L,12175210709491L,75202293506194L,434279600673275L,2358572224659638L,12108001563352776L,59013152727127909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227059Inst : IEnumerable<long>
{
public static readonly long[] Value=A227059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227059.Bytes);
public long this[int i]=>Value[i];

public static A227059Inst Instance=new A227059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227060
{
public static readonly long[] Value={ 4L,10L,10L,20L,40L,20L,35L,124L,124L,35L,56L,329L,643L,329L,56L,84L,777L,2934L,2934L,777L,84L,120L,1673L,11810L,24511L,11810L,1673L,120L,165L,3341L,42295L,183000L,183000L,42295L,3341L,165L,220L,6269L,136553L,1202223L,2625106L,1202223L,136553L,6269L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227060Inst : IEnumerable<long>
{
public static readonly long[] Value=A227060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227060.Bytes);
public long this[int i]=>Value[i];

public static A227060Inst Instance=new A227060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227061
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,5L,1L,1L,1L,5L,25L,13L,1L,1L,1L,8L,161L,272L,42L,1L,1L,1L,13L,1112L,7776L,4070L,155L,1L,1L,1L,21L,8787L,287311L,626649L,79221L,636L,1L,1L,1L,34L,76156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227061Inst : IEnumerable<long>
{
public static readonly long[] Value=A227061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227061.Bytes);
public long this[int i]=>Value[i];

public static A227061Inst Instance=new A227061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227062
{
public static readonly long[] Value={ 9L,13L,17L,21L,29L,33L,37L,41L,45L,53L,57L,61L,65L,77L,81L,85L,101L,105L,129L,133L,137L,141L,145L,153L,157L,161L,165L,177L,181L,185L,201L,205L,225L,253L,257L,261L,265L,277L,281L,285L,301L,305L,325L,377L,381L,385L,401L,405L,425L,501L,505L,525L,629L,633L,637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227062Inst : IEnumerable<long>
{
public static readonly long[] Value=A227062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227062.Bytes);
public long this[int i]=>Value[i];

public static A227062Inst Instance=new A227062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227063
{
public static readonly long[] Value={ 11L,9433L,9437L,62983L,62987L,72229L,72251L,392269L,392279L,495589L,495611L,663583L,663587L,909301L,909317L,909319L,909329L,1006309L,1006331L,1138393L,1138409L,1159201L,1159229L,1173553L,1173581L,1322161L,1322171L,2144491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227063Inst : IEnumerable<long>
{
public static readonly long[] Value=A227063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227063.Bytes);
public long this[int i]=>Value[i];

public static A227063Inst Instance=new A227063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227064
{
public static readonly long[] Value={ 7L,23L,37L,59L,67L,71L,73L,89L,163L,167L,233L,241L,269L,277L,367L,379L,389L,449L,479L,557L,569L,587L,599L,601L,631L,743L,751L,757L,809L,967L,983L,1009L,1033L,1039L,1109L,1117L,1229L,1283L,1297L,1307L,1361L,1439L,1523L,1559L,1607L,1609L,1613L,1637L,1669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227064Inst : IEnumerable<long>
{
public static readonly long[] Value=A227064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227064.Bytes);
public long this[int i]=>Value[i];

public static A227064Inst Instance=new A227064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227065
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,5L,6L,7L,8L,8L,9L,10L,12L,12L,14L,13L,14L,17L,17L,17L,19L,19L,19L,21L,23L,22L,25L,25L,24L,28L,27L,27L,32L,30L,30L,32L,33L,32L,36L,36L,34L,38L,40L,36L,42L,42L,41L,46L,44L,43L,47L,47L,46L,49L,49L,47L,52L,53L,48L,57L,57L,53L,61L,58L,57L,61L,63L,61L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227065Inst : IEnumerable<long>
{
public static readonly long[] Value=A227065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227065.Bytes);
public long this[int i]=>Value[i];

public static A227065Inst Instance=new A227065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227066
{
public static readonly long[] Value={ 5L,6L,15L,21L,25L,26L,28L,29L,30L,33L,35L,38L,39L,44L,47L,50L,62L,63L,65L,67L,74L,78L,80L,86L,94L,105L,108L,109L,112L,114L,153L,155L,164L,165L,170L,171L,172L,173L,174L,207L,208L,209L,215L,276L,279L,282L,283L,285L,287L,293L,294L,297L,298L,299L,504L,704L,712L,714L,1308L,1316L,1322L,1328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227066Inst : IEnumerable<long>
{
public static readonly long[] Value=A227066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227066.Bytes);
public long this[int i]=>Value[i];

public static A227066Inst Instance=new A227066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227067
{
public static readonly long[] Value={ 3L,51L,32151L,300863849741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227067Inst : IEnumerable<long>
{
public static readonly long[] Value=A227067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227067.Bytes);
public long this[int i]=>Value[i];

public static A227067Inst Instance=new A227067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227068
{
public static readonly long[] Value={ 2L,6L,12L,24L,48L,60L,144L,120L,180L,240L,3072L,360L,900L,960L,720L,840L,5184L,1260L,36864L,1680L,2880L,3600L,12582912L,2520L,6480L,61440L,6300L,6720L,805306368L,5040L,14400L,7560L,46080L,983040L,25920L,10080L,32400L,746496L,184320L,15120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227068Inst : IEnumerable<long>
{
public static readonly long[] Value=A227068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227068.Bytes);
public long this[int i]=>Value[i];

public static A227068Inst Instance=new A227068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227069
{
public static readonly long[] Value={ 3L,51L,62L,32151L,32158L,32163L,32170L,300863849741L,300863849758L,300863849763L,300863849817L,300863849841L,300863849864L,300863849871L,300863851617L,300863851626L,300863852542L,300863852547L,300863852565L,300863852571L,300863852799L,300863852805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227069Inst : IEnumerable<long>
{
public static readonly long[] Value=A227069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227069.Bytes);
public long this[int i]=>Value[i];

public static A227069Inst Instance=new A227069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227070
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,11L,17L,21L,26L,33L,41L,51L,65L,81L,101L,126L,129L,161L,201L,251L,257L,321L,401L,501L,513L,626L,641L,801L,1001L,1025L,1251L,1281L,1601L,2001L,2049L,2501L,2561L,3126L,3201L,4001L,4097L,5001L,5121L,6251L,6401L,8001L,8193L,10001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227070Inst : IEnumerable<long>
{
public static readonly long[] Value=A227070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227070.Bytes);
public long this[int i]=>Value[i];

public static A227070Inst Instance=new A227070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227071
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,3L,2L,9L,2L,11L,2L,5L,2L,3L,6L,17L,2L,3L,2L,21L,2L,3L,2L,9L,26L,3L,2L,5L,2L,11L,2L,33L,2L,3L,6L,5L,2L,3L,2L,41L,2L,3L,2L,5L,6L,3L,2L,17L,2L,51L,2L,5L,2L,3L,6L,9L,2L,3L,2L,21L,2L,3L,2L,65L,6L,3L,2L,5L,2L,11L,2L,9L,2L,3L,26L,5L,2L,3L,2L,81L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227071Inst : IEnumerable<long>
{
public static readonly long[] Value=A227071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227071.Bytes);
public long this[int i]=>Value[i];

public static A227071Inst Instance=new A227071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227072
{
public static readonly long[] Value={ 1L,12L,22L,123L,333L,1224L,1234L,2244L,4444L,12235L,12345L,33336L,33346L,55555L,111225L,111445L,112455L,114555L,122346L,122446L,123456L,144466L,222226L,224466L,244557L,244666L,333357L,333666L,345567L,355567L,455667L,666666L,1122556L,1134457L,1145557L,1155666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227072Inst : IEnumerable<long>
{
public static readonly long[] Value=A227072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227072.Bytes);
public long this[int i]=>Value[i];

public static A227072Inst Instance=new A227072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227073
{
public static readonly long[] Value={ 1L,12L,21L,22L,123L,132L,213L,231L,312L,321L,333L,1224L,1234L,1242L,1243L,1324L,1342L,1422L,1423L,1432L,2124L,2134L,2142L,2143L,2214L,2241L,2244L,2314L,2341L,2412L,2413L,2421L,2424L,2431L,2442L,3124L,3142L,3214L,3241L,3412L,3421L,4122L,4123L,4132L,4212L,4213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227073Inst : IEnumerable<long>
{
public static readonly long[] Value=A227073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227073.Bytes);
public long this[int i]=>Value[i];

public static A227073Inst Instance=new A227073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227074
{
public static readonly long[] Value={ 1L,4L,4L,16L,8L,16L,64L,24L,24L,64L,256L,88L,48L,88L,256L,1024L,344L,136L,136L,344L,1024L,4096L,1368L,480L,272L,480L,1368L,4096L,16384L,5464L,1848L,752L,752L,1848L,5464L,16384L,65536L,21848L,7312L,2600L,1504L,2600L,7312L,21848L,65536L,262144L,87384L,29160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227074Inst : IEnumerable<long>
{
public static readonly long[] Value=A227074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227074.Bytes);
public long this[int i]=>Value[i];

public static A227074Inst Instance=new A227074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227075
{
public static readonly long[] Value={ 1L,3L,3L,9L,6L,9L,27L,15L,15L,27L,81L,42L,30L,42L,81L,243L,123L,72L,72L,123L,243L,729L,366L,195L,144L,195L,366L,729L,2187L,1095L,561L,339L,339L,561L,1095L,2187L,6561L,3282L,1656L,900L,678L,900L,1656L,3282L,6561L,19683L,9843L,4938L,2556L,1578L,1578L,2556L,4938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227075Inst : IEnumerable<long>
{
public static readonly long[] Value=A227075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227075.Bytes);
public long this[int i]=>Value[i];

public static A227075Inst Instance=new A227075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227076
{
public static readonly long[] Value={ 1L,5L,5L,25L,10L,25L,125L,35L,35L,125L,625L,160L,70L,160L,625L,3125L,785L,230L,230L,785L,3125L,15625L,3910L,1015L,460L,1015L,3910L,15625L,78125L,19535L,4925L,1475L,1475L,4925L,19535L,78125L,390625L,97660L,24460L,6400L,2950L,6400L,24460L,97660L,390625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227076Inst : IEnumerable<long>
{
public static readonly long[] Value=A227076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227076.Bytes);
public long this[int i]=>Value[i];

public static A227076Inst Instance=new A227076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227077
{
public static readonly long[] Value={ 1L,3L,7L,29L,6761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227077Inst : IEnumerable<long>
{
public static readonly long[] Value=A227077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227077.Bytes);
public long this[int i]=>Value[i];

public static A227077Inst Instance=new A227077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227078
{
public static readonly long[] Value={ 1L,9L,25L,121L,32761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227078Inst : IEnumerable<long>
{
public static readonly long[] Value=A227078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227078.Bytes);
public long this[int i]=>Value[i];

public static A227078Inst Instance=new A227078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227079
{
public static readonly long[] Value={ 1L,49L,289L,5041L,274266721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227079Inst : IEnumerable<long>
{
public static readonly long[] Value=A227079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227079.Bytes);
public long this[int i]=>Value[i];

public static A227079Inst Instance=new A227079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227080
{
public static readonly long[] Value={ 11L,16L,21L,26L,31L,41L,46L,51L,56L,61L,66L,76L,81L,86L,91L,96L,111L,116L,121L,126L,146L,151L,156L,181L,186L,221L,226L,231L,236L,241L,246L,256L,261L,266L,271L,276L,291L,296L,301L,306L,326L,331L,336L,361L,366L,396L,436L,441L,446L,451L,456L,471L,476L,481L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227080Inst : IEnumerable<long>
{
public static readonly long[] Value=A227080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227080.Bytes);
public long this[int i]=>Value[i];

public static A227080Inst Instance=new A227080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227081
{
public static readonly long[] Value={ 1L,2L,8L,40L,212L,1152L,6360L,35520L,200132L,1135456L,6478088L,37128896L,213617704L,1233014720L,7136819376L,41408161920L,240758343684L,1402436532576L,8182797500328L,47814708577728L,279768031296312L,1638915078384960L,9611453035886160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227081Inst : IEnumerable<long>
{
public static readonly long[] Value=A227081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227081.Bytes);
public long this[int i]=>Value[i];

public static A227081Inst Instance=new A227081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227082
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,9L,8L,11L,10L,13L,12L,17L,19L,23L,14L,25L,15L,21L,29L,27L,16L,31L,33L,35L,37L,41L,18L,43L,20L,47L,49L,39L,53L,59L,22L,61L,55L,67L,24L,65L,26L,71L,73L,45L,28L,79L,77L,83L,85L,89L,30L,97L,51L,91L,32L,95L,34L,101L,36L,57L,103L,107L,109L,113L,38L,121L,115L,125L,40L,127L,42L,63L,119L,131L,133L,137L,44L,139L,143L,145L,46L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227082Inst : IEnumerable<long>
{
public static readonly long[] Value=A227082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227082.Bytes);
public long this[int i]=>Value[i];

public static A227082Inst Instance=new A227082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227083
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,1L,2L,2L,1L,3L,1L,2L,2L,3L,2L,3L,2L,3L,3L,3L,3L,4L,1L,4L,4L,2L,3L,5L,3L,4L,5L,4L,3L,7L,4L,4L,3L,6L,5L,5L,3L,6L,5L,6L,4L,6L,4L,6L,7L,5L,5L,7L,4L,6L,6L,7L,4L,7L,6L,5L,8L,5L,6L,9L,6L,5L,6L,7L,8L,8L,6L,7L,7L,9L,7L,7L,5L,9L,10L,6L,8L,9L,8L,10L,7L,8L,7L,11L,8L,7L,9L,9L,10L,10L,8L,9L,8L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227083Inst : IEnumerable<long>
{
public static readonly long[] Value=A227083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227083.Bytes);
public long this[int i]=>Value[i];

public static A227083Inst Instance=new A227083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227084
{
public static readonly long[] Value={ 2L,12L,99L,1339L,34862L,2016091L,272856711L,87559140736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227084Inst : IEnumerable<long>
{
public static readonly long[] Value=A227084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227084.Bytes);
public long this[int i]=>Value[i];

public static A227084Inst Instance=new A227084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227085
{
public static readonly long[] Value={ 4L,12L,29L,62L,122L,225L,393L,655L,1048L,1618L,2421L,3524L,5006L,6959L,9489L,12717L,16780L,21832L,28045L,35610L,44738L,55661L,68633L,83931L,101856L,122734L,146917L,174784L,206742L,243227L,284705L,331673L,384660L,444228L,510973L,585526L,668554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227085Inst : IEnumerable<long>
{
public static readonly long[] Value=A227085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227085.Bytes);
public long this[int i]=>Value[i];

public static A227085Inst Instance=new A227085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227086
{
public static readonly long[] Value={ 7L,29L,99L,302L,842L,2177L,5281L,12128L,26548L,55684L,112389L,219051L,413531L,758154L,1353017L,2355283L,4006629L,6671623L,10890535L,17450956L,27483624L,42589055L,65002969L,97810106L,145217866L,212903302L,308449369L,441889009L,626378657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227086Inst : IEnumerable<long>
{
public static readonly long[] Value=A227086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227086.Bytes);
public long this[int i]=>Value[i];

public static A227086Inst Instance=new A227086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227087
{
public static readonly long[] Value={ 11L,62L,302L,1339L,5517L,21335L,77706L,267130L,868999L,2683571L,7894237L,22199557L,59882610L,155443180L,389435848L,944177113L,2220593929L,5077160511L,11307063564L,24570317758L,52177373347L,108436508850L,220822419206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227087Inst : IEnumerable<long>
{
public static readonly long[] Value=A227087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227087.Bytes);
public long this[int i]=>Value[i];

public static A227087Inst Instance=new A227087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227088
{
public static readonly long[] Value={ 16L,122L,842L,5517L,34862L,210279L,1198995L,6435794L,32506602L,154792049L,697073117L,2979286263L,12129141182L,47200560835L,176145560948L,632250821238L,2188584143256L,7323870287583L,23744538586763L,74727529131117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227088Inst : IEnumerable<long>
{
public static readonly long[] Value=A227088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227088.Bytes);
public long this[int i]=>Value[i];

public static A227088Inst Instance=new A227088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227089
{
public static readonly long[] Value={ 2L,4L,4L,7L,12L,7L,11L,29L,29L,11L,16L,62L,99L,62L,16L,22L,122L,302L,302L,122L,22L,29L,225L,842L,1339L,842L,225L,29L,37L,393L,2177L,5517L,5517L,2177L,393L,37L,46L,655L,5281L,21335L,34862L,21335L,5281L,655L,46L,56L,1048L,12128L,77706L,210279L,210279L,77706L,12128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227089Inst : IEnumerable<long>
{
public static readonly long[] Value=A227089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227089.Bytes);
public long this[int i]=>Value[i];

public static A227089Inst Instance=new A227089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227090
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,10L,12L,13L,18L,19L,27L,28L,30L,31L,35L,38L,39L,40L,41L,55L,57L,59L,60L,61L,62L,84L,86L,87L,88L,89L,96L,97L,99L,101L,103L,105L,108L,112L,116L,117L,119L,124L,131L,136L,138L,139L,140L,175L,177L,178L,179L,181L,183L,184L,190L,191L,193L,194L,196L,199L,265L,266L,268L,272L,273L,276L,277L,279L,280L,281L,300L,304L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227090Inst : IEnumerable<long>
{
public static readonly long[] Value=A227090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227090.Bytes);
public long this[int i]=>Value[i];

public static A227090Inst Instance=new A227090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227091
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,4L,2L,8L,2L,8L,2L,8L,4L,4L,8L,8L,4L,4L,2L,16L,4L,4L,2L,16L,4L,8L,2L,8L,4L,16L,2L,8L,4L,8L,8L,8L,4L,4L,8L,32L,4L,8L,2L,8L,8L,4L,2L,16L,2L,8L,8L,16L,4L,4L,8L,16L,4L,8L,2L,32L,4L,4L,4L,8L,16L,8L,2L,16L,4L,16L,2L,16L,4L,8L,8L,8L,4L,16L,2L,32L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227091Inst : IEnumerable<long>
{
public static readonly long[] Value=A227091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227091.Bytes);
public long this[int i]=>Value[i];

public static A227091Inst Instance=new A227091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227092
{
public static readonly long[] Value={ 13L,19L,25L,31L,37L,43L,55L,61L,67L,73L,79L,85L,91L,103L,109L,115L,121L,127L,133L,151L,157L,163L,169L,175L,199L,205L,211L,217L,247L,253L,259L,295L,301L,349L,355L,361L,367L,373L,379L,385L,397L,403L,409L,415L,421L,427L,445L,451L,457L,463L,469L,493L,499L,505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227092Inst : IEnumerable<long>
{
public static readonly long[] Value=A227092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227092.Bytes);
public long this[int i]=>Value[i];

public static A227092Inst Instance=new A227092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227093
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,2L,0L,3L,0L,5L,0L,8L,1L,3L,2L,1L,3L,4L,5L,5L,9L,0L,4L,6L,3L,6L,8L,3L,2L,0L,0L,3L,2L,3L,2L,6L,4L,9L,7L,6L,2L,6L,0L,2L,2L,8L,3L,0L,5L,8L,8L,9L,4L,8L,3L,7L,8L,6L,2L,4L,1L,0L,3L,4L,4L,4L,7L,9L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227093Inst : IEnumerable<long>
{
public static readonly long[] Value=A227093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227093.Bytes);
public long this[int i]=>Value[i];

public static A227093Inst Instance=new A227093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227094
{
public static readonly BigInteger[] Value={ 1L,2L,5L,18L,91L,574L,4199L,34650L,318645L,3237034L,36041657L,436713506L,5722676895L,80654047942L,1216703923147L,19562850695690L,333991034593833L,6034449711055890L,115036771019660269L,2307582082535387570L,BigInteger.Parse("48588759062255598563"),BigInteger.Parse("1071533741191907032590") };
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
public class A227094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227094Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227094.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227094.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227094Inst Instance=new A227094Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227095
{
public static readonly long[] Value={ 15L,22L,29L,36L,43L,50L,57L,71L,78L,85L,92L,99L,106L,113L,120L,134L,141L,148L,155L,162L,169L,176L,197L,204L,211L,218L,225L,232L,260L,267L,274L,281L,288L,323L,330L,337L,344L,386L,393L,400L,449L,456L,519L,526L,533L,540L,547L,554L,561L,568L,582L,589L,596L,603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227095Inst : IEnumerable<long>
{
public static readonly long[] Value=A227095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227095.Bytes);
public long this[int i]=>Value[i];

public static A227095Inst Instance=new A227095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227096
{
public static readonly BigInteger[] Value={ 1L,2L,5L,20L,104L,632L,4396L,34680L,307236L,3026472L,32849364L,389704800L,5017492320L,69678231552L,1038078389376L,16513758904320L,279354776803200L,5007072973075200L,94783054774919040L,1889504358498754560L,BigInteger.Parse("39565281716813111040"),BigInteger.Parse("868194780280625779200") };
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
public class A227096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227096Inst Instance=new A227096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227097
{
public static readonly long[] Value={ 1L,3L,9L,27L,61L,123L,349L,1007L,2021L,4043L,8089L,16187L,42481L,125363L,271029L,612067L,1234141L,3498383L,10087069L,20254147L,40558401L,81167203L,163394609L,429879827L,1268830461L,2745691323L,6196472949L,12499016807L,35407044421L,101221129243L,202643278689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227097Inst : IEnumerable<long>
{
public static readonly long[] Value=A227097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227097.Bytes);
public long this[int i]=>Value[i];

public static A227097Inst Instance=new A227097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227098
{
public static readonly long[] Value={ 2L,15L,239L,8427L,754758L,180409504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227098Inst : IEnumerable<long>
{
public static readonly long[] Value=A227098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227098.Bytes);
public long this[int i]=>Value[i];

public static A227098Inst Instance=new A227098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227099
{
public static readonly long[] Value={ 4L,15L,48L,136L,341L,771L,1606L,3133L,5789L,10214L,17315L,28342L,44977L,69437L,104592L,154099L,222553L,315656L,440405L,605300L,820573L,1098439L,1453370L,1902393L,2465413L,3165562L,4029575L,5088194L,6376601L,7934881L,9808516L,12048911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227099Inst : IEnumerable<long>
{
public static readonly long[] Value=A227099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227099.Bytes);
public long this[int i]=>Value[i];

public static A227099Inst Instance=new A227099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227100
{
public static readonly long[] Value={ 7L,48L,239L,1084L,4444L,16366L,54500L,166271L,470106L,1243205L,3098315L,7323392L,16507967L,35657274L,74111642L,148760250L,289286122L,546530516L,1005554661L,1805649489L,3170455197L,5452571146L,9198647584L,15243057393L,24840973642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227100Inst : IEnumerable<long>
{
public static readonly long[] Value=A227100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227100.Bytes);
public long this[int i]=>Value[i];

public static A227100Inst Instance=new A227100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227101
{
public static readonly long[] Value={ 11L,136L,1084L,8427L,60039L,384591L,2209056L,11456481L,54141062L,235262503L,947783225L,3566095007L,12613787982L,42187331840L,134097083832L,406916965311L,1183456563350L,3310261263895L,8932219958483L,23313790229352L,59000955033387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227101Inst : IEnumerable<long>
{
public static readonly long[] Value=A227101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227101.Bytes);
public long this[int i]=>Value[i];

public static A227101Inst Instance=new A227101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227102
{
public static readonly long[] Value={ 16L,341L,4444L,60039L,754758L,8638999L,89104481L,828893716L,6983821643L,53621106874L,377769331391L,2459320959398L,14894188221320L,84433809668941L,450539327678840L,2274144315956048L,10906260377874097L,49886929929379557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227102Inst : IEnumerable<long>
{
public static readonly long[] Value=A227102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227102.Bytes);
public long this[int i]=>Value[i];

public static A227102Inst Instance=new A227102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227103
{
public static readonly long[] Value={ 2L,4L,4L,7L,15L,7L,11L,48L,48L,11L,16L,136L,239L,136L,16L,22L,341L,1084L,1084L,341L,22L,29L,771L,4444L,8427L,4444L,771L,29L,37L,1606L,16366L,60039L,60039L,16366L,1606L,37L,46L,3133L,54500L,384591L,754758L,384591L,54500L,3133L,46L,56L,5789L,166271L,2209056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227103Inst : IEnumerable<long>
{
public static readonly long[] Value=A227103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227103.Bytes);
public long this[int i]=>Value[i];

public static A227103Inst Instance=new A227103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227104
{
public static readonly long[] Value={ -1L,3L,2L,3L,7L,10L,15L,27L,42L,67L,111L,178L,287L,467L,754L,1219L,1975L,3194L,5167L,8363L,13530L,21891L,35423L,57314L,92735L,150051L,242786L,392835L,635623L,1028458L,1664079L,2692539L,4356618L,7049155L,11405775L,18454930L,29860703L,48315635L,78176338L,126491971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227104Inst : IEnumerable<long>
{
public static readonly long[] Value=A227104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227104.Bytes);
public long this[int i]=>Value[i];

public static A227104Inst Instance=new A227104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227105
{
public static readonly BigInteger[] Value={ 2L,6L,30L,1155L,15015L,969969L,37182145L,1078282205L,33426748355L,7244053893505L,311494317420715L,14640232918773605L,775932344695001065L,BigInteger.Parse("64092011671807087969"),BigInteger.Parse("3909612711980232366109"),BigInteger.Parse("261944051702675568529303"),BigInteger.Parse("18598027670889965365580513"),BigInteger.Parse("1357656019974967471687377449") };
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
public class A227105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227105Inst Instance=new A227105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227106
{
public static readonly long[] Value={ 0L,3L,12L,3L,24L,15L,4L,21L,48L,9L,60L,33L,24L,39L,84L,5L,96L,51L,36L,57L,120L,21L,132L,69L,16L,75L,156L,27L,168L,87L,60L,93L,192L,11L,204L,105L,72L,111L,228L,39L,240L,123L,28L,129L,264L,45L,276L,141L,96L,147L,300L,17L,312L,159L,108L,165L,336L,57L,348L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227106Inst : IEnumerable<long>
{
public static readonly long[] Value=A227106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227106.Bytes);
public long this[int i]=>Value[i];

public static A227106Inst Instance=new A227106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227107
{
public static readonly long[] Value={ 0L,8L,8L,24L,4L,40L,24L,56L,16L,72L,40L,88L,6L,104L,56L,120L,32L,136L,72L,152L,20L,168L,88L,184L,48L,200L,104L,216L,7L,232L,120L,248L,64L,264L,136L,280L,36L,296L,152L,312L,80L,328L,168L,344L,22L,360L,184L,376L,96L,392L,200L,408L,52L,424L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227107Inst : IEnumerable<long>
{
public static readonly long[] Value=A227107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227107.Bytes);
public long this[int i]=>Value[i];

public static A227107Inst Instance=new A227107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227108
{
public static readonly long[] Value={ 1L,3L,7L,4L,9L,1L,11L,6L,13L,7L,3L,8L,17L,9L,19L,2L,21L,11L,23L,12L,1L,13L,27L,14L,29L,3L,31L,16L,33L,17L,7L,18L,37L,19L,39L,4L,41L,21L,43L,22L,9L,23L,47L,24L,49L,1L,51L,26L,53L,27L,11L,28L,57L,29L,59L,6L,61L,31L,63L,32L,13L,33L,67L,34L,69L,7L,71L,36L,73L,37L,3L,38L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227108Inst : IEnumerable<long>
{
public static readonly long[] Value=A227108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227108.Bytes);
public long this[int i]=>Value[i];

public static A227108Inst Instance=new A227108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227109
{
public static readonly long[] Value={ 0L,5L,20L,15L,40L,5L,60L,35L,80L,45L,20L,55L,120L,65L,140L,15L,160L,85L,180L,95L,8L,105L,220L,115L,240L,25L,260L,135L,280L,145L,60L,155L,320L,165L,340L,35L,360L,185L,380L,195L,80L,205L,420L,215L,440L,9L,460L,235L,480L,245L,100L,255L,520L,265L,540L,55L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227109Inst : IEnumerable<long>
{
public static readonly long[] Value=A227109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227109.Bytes);
public long this[int i]=>Value[i];

public static A227109Inst Instance=new A227109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227110
{
public static readonly BigInteger[] Value={ 1L,500001L,500002000001L,500003000004500001L,BigInteger.Parse("500004000010000008000001"),BigInteger.Parse("500005000017500025000012500001"),BigInteger.Parse("500006000027000056000052500018000001"),BigInteger.Parse("500007000038500105000147000098000024500001"),BigInteger.Parse("500008000052000176000330000336000168000032000001") };
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
public class A227110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227110Inst Instance=new A227110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227111
{
public static readonly BigInteger[] Value={ 0L,1L,1000002L,1000004000003L,1000006000010000004L,BigInteger.Parse("1000008000021000020000005"),BigInteger.Parse("1000010000036000056000035000006"),BigInteger.Parse("1000012000055000120000126000056000007"),BigInteger.Parse("1000014000078000220000330000252000084000008"),BigInteger.Parse("1000016000105000364000715000792000462000120000009") };
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
public class A227111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227111Inst Instance=new A227111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227112
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,16L,18L,20L,22L,24L,26L,30L,38L,40L,42L,50L,56L,60L,68L,70L,78L,80L,90L,96L,100L,102L,104L,110L,120L,130L,144L,148L,150L,156L,160L,170L,174L,180L,182L,198L,210L,224L,234L,240L,286L,290L,300L,312L,350L,360L,370L,390L,400L,440L,510L,520L,548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227112Inst : IEnumerable<long>
{
public static readonly long[] Value=A227112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227112.Bytes);
public long this[int i]=>Value[i];

public static A227112Inst Instance=new A227112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227113
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,10L,7L,14L,8L,12L,9L,15L,11L,22L,13L,26L,16L,18L,17L,34L,19L,38L,20L,24L,21L,27L,23L,46L,25L,30L,28L,32L,29L,58L,31L,62L,33L,36L,35L,40L,37L,74L,39L,42L,41L,82L,43L,86L,44L,48L,45L,50L,47L,94L,49L,56L,51L,54L,52L,60L,53L,106L,55L,65L,57L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227113Inst : IEnumerable<long>
{
public static readonly long[] Value=A227113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227113.Bytes);
public long this[int i]=>Value[i];

public static A227113Inst Instance=new A227113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227114
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,8L,10L,12L,7L,14L,11L,16L,9L,13L,18L,20L,19L,22L,24L,26L,15L,28L,25L,30L,17L,27L,32L,34L,31L,36L,33L,38L,21L,40L,39L,42L,23L,44L,41L,46L,45L,48L,50L,52L,29L,54L,51L,56L,53L,58L,60L,62L,59L,64L,57L,66L,35L,68L,61L,70L,37L,67L,72L,65L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227114Inst : IEnumerable<long>
{
public static readonly long[] Value=A227114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227114.Bytes);
public long this[int i]=>Value[i];

public static A227114Inst Instance=new A227114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227115
{
public static readonly long[] Value={ 27L,10077696L,128L,32768L,8L,27L,1000L,1728L,5088448L,690807104L,27L,32L,512L,2048L,512L,6859L,4913L,243L,405224L,125L,3125L,2744L,98611128L,27000L,314432L,216L,1728L,1889568L,243L,2744L,512L,4913000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227115Inst : IEnumerable<long>
{
public static readonly long[] Value=A227115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227115.Bytes);
public long this[int i]=>Value[i];

public static A227115Inst Instance=new A227115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227116
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,9L,14L,18L,23L,29L,36L,44L,52L,61L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227116Inst : IEnumerable<long>
{
public static readonly long[] Value=A227116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227116.Bytes);
public long this[int i]=>Value[i];

public static A227116Inst Instance=new A227116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227117
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,13L,70L,608L,7222L,110132L,2039273L,441767171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227117Inst : IEnumerable<long>
{
public static readonly long[] Value=A227117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227117.Bytes);
public long this[int i]=>Value[i];

public static A227117Inst Instance=new A227117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227118
{
public static readonly long[] Value={ 1L,5L,9L,13L,16L,19L,22L,25L,28L,2L,3L,4L,8L,14L,15L,20L,21L,26L,27L,6L,7L,11L,10L,12L,17L,18L,23L,24L,29L,31L,32L,30L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,40L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,50L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,60L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227118Inst : IEnumerable<long>
{
public static readonly long[] Value=A227118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227118.Bytes);
public long this[int i]=>Value[i];

public static A227118Inst Instance=new A227118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227119
{
public static readonly BigInteger[] Value={ 1L,2L,7L,31L,163L,985L,6676L,49918L,406820L,3580011L,33764544L,339222866L,3612046889L,40588278875L,479542299692L,5938050050297L,76848380886090L,1036869475470365L,14553056889254517L,212063804824260167L,3202482669648363619L,BigInteger.Parse("50039504959872274840") };
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
public class A227119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227119Inst Instance=new A227119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227120
{
public static readonly long[] Value={ 2L,7L,33L,295L,5820L,241783L,21458929L,4109192774L,1709864974106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227120Inst : IEnumerable<long>
{
public static readonly long[] Value=A227120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227120.Bytes);
public long this[int i]=>Value[i];

public static A227120Inst Instance=new A227120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227121
{
public static readonly long[] Value={ 3L,7L,13L,23L,40L,68L,112L,178L,273L,405L,583L,817L,1118L,1498L,1970L,2548L,3247L,4083L,5073L,6235L,7588L,9152L,10948L,12998L,15325L,17953L,20907L,24213L,27898L,31990L,36518L,41512L,47003L,53023L,59605L,66783L,74592L,83068L,92248L,102170L,112873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227121Inst : IEnumerable<long>
{
public static readonly long[] Value=A227121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227121.Bytes);
public long this[int i]=>Value[i];

public static A227121Inst Instance=new A227121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227122
{
public static readonly long[] Value={ 4L,13L,33L,81L,202L,492L,1143L,2524L,5315L,10718L,20776L,38839L,70225L,123134L,209884L,348550L,565100L,896136L,1392363L,2122925L,3180764L,4689176L,6809757L,9751952L,13784441L,19248618L,26574442L,36298963L,49087851L,65760282L,87317562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227122Inst : IEnumerable<long>
{
public static readonly long[] Value=A227122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227122.Bytes);
public long this[int i]=>Value[i];

public static A227122Inst Instance=new A227122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227123
{
public static readonly long[] Value={ 5L,23L,81L,295L,1079L,3836L,12954L,41334L,124956L,359214L,985377L,2587934L,6528298L,15865511L,37249628L,84702904L,186968944L,401441143L,839947739L,1715449948L,3424892827L,6693385156L,12820586861L,24094606746L,44476144089L,80712174607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227123Inst : IEnumerable<long>
{
public static readonly long[] Value=A227123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227123.Bytes);
public long this[int i]=>Value[i];

public static A227123Inst Instance=new A227123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227124
{
public static readonly long[] Value={ 6L,40L,202L,1079L,5820L,30620L,153955L,732611L,3296920L,14061299L,56985160L,220076717L,812449972L,2875724911L,9787354849L,32113565709L,101824379739L,312674532585L,931663492446L,2698483534259L,7609773537119L,20924215257349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227124Inst : IEnumerable<long>
{
public static readonly long[] Value=A227124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227124.Bytes);
public long this[int i]=>Value[i];

public static A227124Inst Instance=new A227124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227125
{
public static readonly long[] Value={ 2L,3L,3L,4L,7L,4L,5L,13L,13L,5L,6L,23L,33L,23L,6L,7L,40L,81L,81L,40L,7L,8L,68L,202L,295L,202L,68L,8L,9L,112L,492L,1079L,1079L,492L,112L,9L,10L,178L,1143L,3836L,5820L,3836L,1143L,178L,10L,11L,273L,2524L,12954L,30620L,30620L,12954L,2524L,273L,11L,12L,405L,5315L,41334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227125Inst : IEnumerable<long>
{
public static readonly long[] Value=A227125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227125.Bytes);
public long this[int i]=>Value[i];

public static A227125Inst Instance=new A227125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227126
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,167L,193L,197L,433L,4111L,9173L,42929L,142567L,344209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227126Inst : IEnumerable<long>
{
public static readonly long[] Value=A227126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227126.Bytes);
public long this[int i]=>Value[i];

public static A227126Inst Instance=new A227126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227127
{
public static readonly long[] Value={ 1L,1L,2L,8L,20L,12L,28L,16L,36L,60L,22L,72L,52L,28L,60L,96L,102L,36L,114L,80L,42L,132L,92L,144L,200L,104L,54L,112L,58L,120L,434L,128L,198L,68L,350L,72L,222L,228L,156L,240L,246L,84L,430L,88L,180L,92L,564L,576L,196L,100L,204L,312L,106L,540L,330L,336L,342L,116L,354L,240L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227127Inst : IEnumerable<long>
{
public static readonly long[] Value=A227127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227127.Bytes);
public long this[int i]=>Value[i];

public static A227127Inst Instance=new A227127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227128
{
public static readonly long[] Value={ 1L,3L,3L,6L,6L,9L,6L,12L,9L,18L,12L,18L,12L,18L,18L,24L,18L,27L,18L,36L,18L,36L,24L,36L,30L,36L,27L,36L,30L,54L,30L,48L,36L,54L,36L,54L,36L,54L,36L,72L,42L,54L,42L,72L,54L,72L,48L,72L,42L,90L,54L,72L,54L,81L,72L,72L,54L,90L,60L,108L,60L,90L,54L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227128Inst : IEnumerable<long>
{
public static readonly long[] Value=A227128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227128.Bytes);
public long this[int i]=>Value[i];

public static A227128Inst Instance=new A227128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227129
{
public static readonly long[] Value={ 15L,51L,85L,91L,133L,145L,235L,249L,265L,427L,451L,493L,519L,559L,565L,589L,591L,681L,721L,871L,879L,1003L,1149L,1177L,1189L,1207L,1411L,1441L,1509L,1561L,1603L,1651L,1837L,1945L,2059L,2071L,2119L,2227L,2335L,2391L,2419L,2599L,2661L,2827L,2869L,2965L,2995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227129Inst : IEnumerable<long>
{
public static readonly long[] Value=A227129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227129.Bytes);
public long this[int i]=>Value[i];

public static A227129Inst Instance=new A227129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227130
{
public static readonly long[] Value={ 0L,3L,5L,7L,8L,10L,13L,14L,16L,19L,20L,22L,25L,26L,28L,30L,33L,35L,36L,39L,41L,42L,45L,47L,49L,50L,52L,54L,57L,59L,60L,63L,65L,66L,69L,71L,73L,74L,76L,78L,81L,83L,84L,87L,89L,90L,93L,95L,97L,98L,100L,102L,105L,107L,108L,111L,113L,114L,117L,119L,121L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227130Inst : IEnumerable<long>
{
public static readonly long[] Value=A227130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227130.Bytes);
public long this[int i]=>Value[i];

public static A227130Inst Instance=new A227130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227131
{
public static readonly long[] Value={ 1L,1L,3L,4L,7L,6L,12L,8L,15L,13L,18L,12L,28L,14L,24L,24L,31L,18L,39L,20L,42L,32L,36L,24L,60L,6L,42L,40L,56L,30L,72L,32L,63L,48L,54L,48L,91L,38L,60L,56L,90L,42L,96L,44L,84L,78L,72L,48L,124L,57L,18L,72L,98L,54L,120L,72L,120L,80L,90L,60L,168L,62L,96L,104L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227131Inst : IEnumerable<long>
{
public static readonly long[] Value=A227131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227131.Bytes);
public long this[int i]=>Value[i];

public static A227131Inst Instance=new A227131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227132
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,11L,12L,15L,17L,18L,21L,23L,24L,27L,29L,31L,32L,34L,37L,38L,40L,43L,44L,46L,48L,51L,53L,55L,56L,58L,61L,62L,64L,67L,68L,70L,72L,75L,77L,79L,80L,82L,85L,86L,88L,91L,92L,94L,96L,99L,101L,103L,104L,106L,109L,110L,112L,115L,116L,118L,120L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227132Inst : IEnumerable<long>
{
public static readonly long[] Value=A227132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227132.Bytes);
public long this[int i]=>Value[i];

public static A227132Inst Instance=new A227132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227133
{
public static readonly long[] Value={ 1L,3L,7L,12L,17L,24L,32L,41L,51L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227133Inst : IEnumerable<long>
{
public static readonly long[] Value=A227133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227133.Bytes);
public long this[int i]=>Value[i];

public static A227133Inst Instance=new A227133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227134
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,7L,8L,11L,14L,19L,22L,30L,36L,46L,55L,70L,83L,104L,123L,151L,179L,218L,256L,309L,363L,433L,507L,602L,701L,828L,961L,1127L,1306L,1525L,1759L,2046L,2355L,2725L,3129L,3609L,4131L,4750L,5424L,6214L,7081L,8090L,9195L,10478L,11886L,13506L,15290L,17335L,19583L,22154L,24981L,28197L,31741L,35757L,40176L,45176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227134Inst : IEnumerable<long>
{
public static readonly long[] Value=A227134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227134.Bytes);
public long this[int i]=>Value[i];

public static A227134Inst Instance=new A227134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227135
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,4L,6L,8L,10L,12L,17L,20L,25L,31L,39L,47L,58L,69L,85L,102L,123L,145L,175L,207L,246L,290L,343L,401L,473L,551L,646L,751L,875L,1012L,1177L,1358L,1570L,1807L,2083L,2389L,2746L,3140L,3597L,4106L,4690L,5337L,6082L,6907L,7848L,8895L,10085L,11404L,12902L,14561L,16438L,18520L,20864L,23460L,26385L,29619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227135Inst : IEnumerable<long>
{
public static readonly long[] Value=A227135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227135.Bytes);
public long this[int i]=>Value[i];

public static A227135Inst Instance=new A227135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227136
{
public static readonly long[] Value={ 645L,1387L,2701L,2821L,4369L,4371L,7957L,8911L,11305L,13741L,13747L,13981L,14491L,18721L,19951L,23001L,23377L,30889L,31417L,31609L,35333L,39865L,41665L,55245L,57421L,60701L,60787L,63973L,68101L,72885L,83665L,88561L,91001L,93961L,101101L,107185L,121465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227136Inst : IEnumerable<long>
{
public static readonly long[] Value=A227136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227136.Bytes);
public long this[int i]=>Value[i];

public static A227136Inst Instance=new A227136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227137
{
public static readonly BigInteger[] Value={ 1L,1000003L,1000005000005L,1000007000014000007L,BigInteger.Parse("1000009000027000030000009"),BigInteger.Parse("1000011000044000077000055000011"),BigInteger.Parse("1000013000065000156000182000091000013"),BigInteger.Parse("1000015000090000275000450000378000140000015"),BigInteger.Parse("1000017000119000442000935001122000714000204000017") };
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
public class A227137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227137Inst Instance=new A227137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227138
{
public static readonly BigInteger[] Value={ 1L,1000001L,1000003000001L,1000005000006000001L,BigInteger.Parse("1000007000015000010000001"),BigInteger.Parse("1000009000028000035000015000001"),BigInteger.Parse("1000011000045000084000070000021000001"),BigInteger.Parse("1000013000066000165000210000126000028000001"),BigInteger.Parse("1000015000091000286000495000462000210000036000001") };
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
public class A227138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227138Inst Instance=new A227138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227139
{
public static readonly BigInteger[] Value={ 1L,48L,2303L,110496L,5301505L,254361744L,12204062207L,585540624192L,28093745899009L,1347914262528240L,64671790855456511L,3102898046799384288L,BigInteger.Parse("148874434455514989313"),BigInteger.Parse("7142869955817920102736"),BigInteger.Parse("342708883444804649942015") };
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
public class A227139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227139Inst Instance=new A227139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227140
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,11L,3L,13L,7L,15L,1L,17L,9L,19L,5L,21L,11L,23L,3L,25L,13L,27L,7L,29L,15L,31L,1L,33L,17L,35L,9L,37L,19L,39L,5L,41L,21L,43L,11L,45L,23L,47L,3L,49L,25L,51L,13L,53L,27L,55L,7L,57L,29L,59L,15L,61L,31L,63L,2L,65L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227140Inst : IEnumerable<long>
{
public static readonly long[] Value=A227140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227140.Bytes);
public long this[int i]=>Value[i];

public static A227140Inst Instance=new A227140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227141
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,4L,3L,2L,1L,1L,1L,1L,3L,3L,3L,2L,1L,1L,1L,2L,2L,5L,4L,3L,2L,1L,1L,1L,1L,3L,4L,4L,4L,3L,2L,1L,1L,1L,2L,4L,4L,6L,5L,4L,3L,2L,1L,1L,1L,1L,2L,3L,5L,5L,5L,4L,3L,2L,1L,1L,1L,2L,3L,4L,5L,7L,6L,5L,4L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227141Inst : IEnumerable<long>
{
public static readonly long[] Value=A227141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227141.Bytes);
public long this[int i]=>Value[i];

public static A227141Inst Instance=new A227141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227142
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,9L,8L,11L,10L,13L,12L,17L,19L,23L,14L,29L,15L,31L,20L,37L,16L,41L,18L,43L,22L,47L,21L,53L,24L,57L,25L,59L,26L,61L,27L,67L,34L,71L,28L,73L,30L,79L,46L,83L,32L,89L,33L,97L,55L,101L,35L,103L,39L,107L,62L,109L,36L,113L,38L,127L,74L,131L,42L,137L,40L,139L,85L,149L,44L,151L,45L,157L,86L,163L,49L,167L,48L,173L,94L,179L,50L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227142Inst : IEnumerable<long>
{
public static readonly long[] Value=A227142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227142.Bytes);
public long this[int i]=>Value[i];

public static A227142Inst Instance=new A227142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227143
{
public static readonly BigInteger[] Value={ 1L,1L,12L,567L,122472L,126660105L,640190834712L,15987980408180508L,BigInteger.Parse("1985745116187976972608"),BigInteger.Parse("1231754497376142871049675940"),BigInteger.Parse("3826847477714307687323719819461000"),BigInteger.Parse("59670909707615018862830973519922857945375") };
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
public class A227143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227143Inst Instance=new A227143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227144
{
public static readonly long[] Value={ 1L,2L,7L,17L,23L,25L,26L,31L,41L,47L,49L,50L,55L,65L,71L,73L,74L,79L,89L,95L,97L,98L,103L,113L,119L,121L,122L,127L,137L,143L,145L,146L,151L,161L,167L,169L,170L,175L,185L,191L,193L,194L,199L,209L,215L,217L,218L,223L,233L,239L,241L,242L,247L,257L,263L,265L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227144Inst : IEnumerable<long>
{
public static readonly long[] Value=A227144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227144.Bytes);
public long this[int i]=>Value[i];

public static A227144Inst Instance=new A227144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227145
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,17L,17L,17L,17L,18L,18L,19L,19L,20L,20L,20L,21L,21L,22L,22L,22L,22L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227145Inst : IEnumerable<long>
{
public static readonly long[] Value=A227145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227145.Bytes);
public long this[int i]=>Value[i];

public static A227145Inst Instance=new A227145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227146
{
public static readonly long[] Value={ 5L,11L,13L,14L,19L,29L,35L,37L,38L,43L,53L,59L,61L,62L,67L,77L,83L,85L,86L,91L,101L,107L,109L,110L,115L,125L,131L,133L,134L,139L,149L,155L,157L,158L,163L,173L,179L,181L,182L,187L,197L,203L,205L,206L,211L,221L,227L,229L,230L,235L,245L,251L,253L,254L,259L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227146Inst : IEnumerable<long>
{
public static readonly long[] Value=A227146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227146.Bytes);
public long this[int i]=>Value[i];

public static A227146Inst Instance=new A227146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227147
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,4L,3L,2L,3L,4L,2L,3L,5L,4L,4L,3L,4L,5L,4L,3L,4L,4L,5L,3L,4L,6L,5L,5L,5L,4L,5L,6L,5L,5L,4L,5L,5L,6L,5L,4L,5L,5L,5L,6L,4L,5L,7L,6L,6L,6L,6L,5L,6L,7L,6L,6L,6L,5L,6L,6L,7L,6L,6L,5L,6L,6L,6L,7L,6L,5L,6L,6L,6L,6L,7L,5L,6L,8L,7L,7L,7L,7L,7L,6L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227147Inst : IEnumerable<long>
{
public static readonly long[] Value=A227147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227147.Bytes);
public long this[int i]=>Value[i];

public static A227147Inst Instance=new A227147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227148
{
public static readonly long[] Value={ 0L,3L,4L,7L,8L,11L,12L,15L,16L,19L,20L,23L,25L,26L,29L,30L,33L,34L,37L,38L,41L,42L,45L,46L,48L,51L,52L,55L,56L,59L,60L,63L,64L,67L,68L,71L,73L,74L,77L,78L,81L,82L,85L,86L,89L,90L,93L,94L,96L,99L,100L,103L,104L,107L,108L,111L,112L,115L,116L,119L,121L,122L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227148Inst : IEnumerable<long>
{
public static readonly long[] Value=A227148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227148.Bytes);
public long this[int i]=>Value[i];

public static A227148Inst Instance=new A227148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227149
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,10L,13L,14L,17L,18L,21L,22L,24L,27L,28L,31L,32L,35L,36L,39L,40L,43L,44L,47L,49L,50L,53L,54L,57L,58L,61L,62L,65L,66L,69L,70L,72L,75L,76L,79L,80L,83L,84L,87L,88L,91L,92L,95L,97L,98L,101L,102L,105L,106L,109L,110L,113L,114L,117L,118L,120L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227149Inst : IEnumerable<long>
{
public static readonly long[] Value=A227149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227149.Bytes);
public long this[int i]=>Value[i];

public static A227149Inst Instance=new A227149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227150
{
public static readonly BigInteger[] Value={ 1L,62809633L,7890099995189377L,BigInteger.Parse("991148570062293006927649"),BigInteger.Parse("124507355868174813917084187296257"),BigInteger.Parse("15640522655760911892802130406069321959713"),BigInteger.Parse("1964750975873056298957118436671896252612641334401"),BigInteger.Parse("246810575461957025811147127728879197279220180679392209953") };
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
public class A227150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227150Inst Instance=new A227150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227151
{
public static readonly BigInteger[] Value={ 0L,1L,125619266L,15780199990378755L,BigInteger.Parse("1982297140124586139474564"),BigInteger.Parse("249014711736349643614368364971269"),BigInteger.Parse("31281045311521825767901400936724783393990"),BigInteger.Parse("3929501951746112846928948609693436119593647640071"),BigInteger.Parse("493621150923914082903339566979584162459841298083567813896"),BigInteger.Parse("62008326661137305011878713606620352544481408648308875849192480265") };
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
public class A227151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227151Inst Instance=new A227151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227152
{
public static readonly BigInteger[] Value={ 1L,201L,80801L,32481801L,13057603201L,5249124005001L,2110134792407201L,848268937423689801L,BigInteger.Parse("341002002709530892801"),BigInteger.Parse("137081956820293995216201"),BigInteger.Parse("55106605639755476546020001"),BigInteger.Parse("22152718385224881277504824201") };
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
public class A227152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227152Inst Instance=new A227152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227153
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,4L,4L,3L,3L,3L,3L,6L,6L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,4L,4L,3L,3L,3L,3L,6L,6L,2L,2L,2L,2L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,4L,4L,8L,8L,6L,6L,6L,6L,12L,12L,3L,3L,3L,3L,6L,6L,3L,3L,3L,3L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227153Inst : IEnumerable<long>
{
public static readonly long[] Value=A227153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227153.Bytes);
public long this[int i]=>Value[i];

public static A227153Inst Instance=new A227153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227154
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,6L,2L,4L,4L,8L,6L,12L,3L,6L,6L,12L,9L,18L,4L,8L,8L,16L,12L,24L,2L,4L,4L,8L,6L,12L,4L,8L,8L,16L,12L,24L,6L,12L,12L,24L,18L,36L,8L,16L,16L,32L,24L,48L,3L,6L,6L,12L,9L,18L,6L,12L,12L,24L,18L,36L,9L,18L,18L,36L,27L,54L,12L,24L,24L,48L,36L,72L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227154Inst : IEnumerable<long>
{
public static readonly long[] Value=A227154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227154.Bytes);
public long this[int i]=>Value[i];

public static A227154Inst Instance=new A227154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227155
{
public static readonly long[] Value={ 4999999L,1666666L,666666L,380952L,207791L,159839L,112829L,95016L,74356L,56405L,50949L,41317L,36293L,33780L,30205L,26228L,23123L,21975L,19655L,18249L,17467L,15871L,14876L,13668L,12358L,11710L,11344L,10779L,10451L,9955L,8748L,8398L,7956L,7768L,7181L,7034L,6724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227155Inst : IEnumerable<long>
{
public static readonly long[] Value=A227155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227155.Bytes);
public long this[int i]=>Value[i];

public static A227155Inst Instance=new A227155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227156
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,1L,3L,1L,2L,2L,2L,2L,2L,4L,1L,4L,2L,1L,4L,0L,3L,4L,3L,1L,3L,4L,2L,3L,2L,3L,4L,2L,1L,4L,2L,4L,4L,3L,4L,2L,4L,1L,5L,2L,1L,5L,3L,5L,2L,2L,4L,3L,3L,3L,3L,3L,3L,4L,1L,3L,5L,4L,4L,4L,2L,4L,4L,3L,4L,3L,6L,1L,3L,5L,2L,6L,4L,3L,7L,2L,4L,6L,2L,3L,5L,5L,2L,4L,4L,4L,6L,4L,3L,5L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227156Inst : IEnumerable<long>
{
public static readonly long[] Value=A227156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227156.Bytes);
public long this[int i]=>Value[i];

public static A227156Inst Instance=new A227156Inst();

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