using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198157
{
public static readonly long[] Value={ 1L,5L,26L,267L,5802L,244365L,19093622L,2937099281L,866588833018L,491355230014545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198157Inst : IEnumerable<long>
{
public static readonly long[] Value=A198157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198157.Bytes);
public long this[int i]=>Value[i];

public static A198157Inst Instance=new A198157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198158
{
public static readonly long[] Value={ 1L,2L,17L,113L,2211L,79220L,4456377L,560699301L,127364497803L,52948639902295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198158Inst : IEnumerable<long>
{
public static readonly long[] Value=A198158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198158.Bytes);
public long this[int i]=>Value[i];

public static A198158Inst Instance=new A198158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198159
{
public static readonly long[] Value={ 1L,4L,13L,134L,2506L,81923L,5913801L,836958994L,235327275156L,133415063651713L,151040737730161989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198159Inst : IEnumerable<long>
{
public static readonly long[] Value=A198159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198159.Bytes);
public long this[int i]=>Value[i];

public static A198159Inst Instance=new A198159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198160
{
public static readonly long[] Value={ 1L,1L,13L,54L,846L,25780L,859573L,86163253L,12266096117L,3194757527455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198160Inst : IEnumerable<long>
{
public static readonly long[] Value=A198160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198160.Bytes);
public long this[int i]=>Value[i];

public static A198160Inst Instance=new A198160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198161
{
public static readonly long[] Value={ 4142135623L,8872420969L,9698078569L,7537694807L,7973799073L,7846210703L,2644121497L,9935831413L,6592750559L,7010955997L,1472851741L,5251407989L,2533965463L,5339654633L,6152583523L,1525835239L,3950547457L,5750287759L,5996172983L,4084988471L,6668713013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198161Inst : IEnumerable<long>
{
public static readonly long[] Value=A198161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198161.Bytes);
public long this[int i]=>Value[i];

public static A198161Inst Instance=new A198161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198162
{
public static readonly long[] Value={ 41L,13L,23L,37L,73L,67L,71L,53L,37L,73L,31L,17L,67L,79L,97L,73L,37L,79L,73L,47L,53L,43L,41L,73L,13L,23L,29L,97L,83L,73L,37L,41L,97L,83L,31L,41L,13L,59L,59L,79L,11L,71L,47L,59L,97L,71L,59L,97L,53L,59L,47L,17L,41L,89L,19L,23L,29L,23L,43L,71L,43L,83L,97L,79L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198162Inst : IEnumerable<long>
{
public static readonly long[] Value=A198162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198162.Bytes);
public long this[int i]=>Value[i];

public static A198162Inst Instance=new A198162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198163
{
public static readonly long[] Value={ 421L,373L,887L,569L,967L,769L,317L,797L,379L,907L,107L,503L,641L,157L,727L,229L,149L,709L,659L,557L,571L,701L,109L,599L,997L,971L,919L,523L,839L,397L,251L,463L,331L,829L,523L,239L,547L,457L,877L,599L,617L,983L,557L,337L,857L,701L,113L,997L,503L,277L,823L,929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198163Inst : IEnumerable<long>
{
public static readonly long[] Value=A198163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198163.Bytes);
public long this[int i]=>Value[i];

public static A198163Inst Instance=new A198163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198164
{
public static readonly long[] Value={ 5623L,7309L,6967L,7187L,8753L,7537L,3769L,6679L,9907L,4621L,8753L,4327L,4157L,2309L,1229L,2297L,3583L,6659L,5927L,5927L,5011L,7027L,2851L,1741L,8609L,4079L,7253L,7457L,7759L,3557L,2203L,5701L,5437L,4603L,8689L,6899L,8999L,7069L,4027L,7823L,9293L,3691L,6311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198164Inst : IEnumerable<long>
{
public static readonly long[] Value=A198164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198164.Bytes);
public long this[int i]=>Value[i];

public static A198164Inst Instance=new A198164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198165
{
public static readonly long[] Value={ 56237L,37309L,78569L,67187L,48073L,76679L,66797L,97379L,79907L,50387L,34327L,64157L,15727L,91229L,70249L,73721L,12149L,70999L,35831L,65927L,55927L,55799L,11527L,55997L,59971L,86201L,20147L,28517L,88919L,30871L,14321L,45083L,50839L,62603L,51407L,87253L,72533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198165Inst : IEnumerable<long>
{
public static readonly long[] Value=A198165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198165.Bytes);
public long this[int i]=>Value[i];

public static A198165Inst Instance=new A198165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198166
{
public static readonly long[] Value={ 135623L,569671L,480731L,850387L,157273L,384623L,585073L,970999L,927557L,275579L,950501L,686201L,450839L,514079L,989687L,872533L,583523L,750287L,759961L,961729L,983557L,752203L,531857L,857011L,570113L,374603L,340849L,868999L,997069L,970699L,900481L,277903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198166Inst : IEnumerable<long>
{
public static readonly long[] Value=A198166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198166.Bytes);
public long this[int i]=>Value[i];

public static A198166Inst Instance=new A198166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198167
{
public static readonly long[] Value={ 3562373L,5048801L,2420969L,5038753L,7534327L,6415727L,5073721L,2126441L,2644121L,9709993L,9935831L,2226659L,9275579L,8206057L,5714701L,7027453L,2851741L,8640889L,2145083L,5835239L,3868999L,8689997L,9970699L,9900481L,2779031L,6311159L,6668713L,6871301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198167Inst : IEnumerable<long>
{
public static readonly long[] Value=A198167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198167.Bytes);
public long this[int i]=>Value[i];

public static A198167Inst Instance=new A198167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198168
{
public static readonly long[] Value={ 42135623L,98078569L,96718753L,76948073L,69480731L,31766797L,76679737L,24784621L,70388503L,64157273L,22970249L,35831413L,75055927L,82060571L,71470109L,55232923L,21450839L,25835239L,23950547L,57502877L,87759961L,18570113L,54374603L,16038689L,38689997L,99970699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198168Inst : IEnumerable<long>
{
public static readonly long[] Value=A198168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198168.Bytes);
public long this[int i]=>Value[i];

public static A198168Inst Instance=new A198168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198169
{
public static readonly long[] Value={ 213562373L,488016887L,688724209L,807856967L,718753769L,376948073L,501384623L,470109559L,609552329L,292304843L,260362799L,396546331L,523950547L,877599617L,172983557L,220337531L,570113543L,160386899L,603868999L,782306849L,684929369L,861249497L,124949771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198169Inst : IEnumerable<long>
{
public static readonly long[] Value=A198169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198169.Bytes);
public long this[int i]=>Value[i];

public static A198169Inst Instance=new A198169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198170
{
public static readonly long[] Value={ 653L,643L,433L,383L,419L,197L,971L,937L,751L,307L,421L,211L,821L,823L,647L,709L,223L,317L,359L,811L,701L,193L,521L,211L,229L,881L,109L,659L,593L,461L,823L,233L,337L,271L,821L,607L,491L,127L,587L,631L,881L,881L,829L,409L,643L,367L,113L,521L,941L,151L,433L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198170Inst : IEnumerable<long>
{
public static readonly long[] Value=A198170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198170.Bytes);
public long this[int i]=>Value[i];

public static A198170Inst Instance=new A198170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198171
{
public static readonly long[] Value={ 1592653L,6535897L,2643383L,5028841L,6939937L,3993751L,1170679L,8086513L,5822317L,1725359L,4930381L,2881097L,4612847L,3165271L,2712019L,1201909L,4914127L,1133053L,3841469L,1469519L,6951941L,9433057L,9326117L,4462379L,2749567L,5272489L,8912279L,8183011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198171Inst : IEnumerable<long>
{
public static readonly long[] Value=A198171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198171.Bytes);
public long this[int i]=>Value[i];

public static A198171Inst Instance=new A198171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198172
{
public static readonly long[] Value={ 28841971L,41971693L,82534211L,42117067L,30664709L,31725359L,49303819L,75648233L,37867831L,71201909L,48566923L,26648213L,13393607L,25409171L,57595919L,21861173L,81932611L,79962749L,24891227L,30119491L,40656643L,30860213L,39494639L,39522473L,98609437L,53921717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198172Inst : IEnumerable<long>
{
public static readonly long[] Value=A198172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198172.Bytes);
public long this[int i]=>Value[i];

public static A198172Inst Instance=new A198172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198173
{
public static readonly long[] Value={ 795028841L,502884197L,884197169L,971693993L,348253421L,421170679L,306647093L,812848111L,659334461L,233786783L,648566923L,346034861L,326648213L,829254091L,678925903L,959195309L,530921861L,938183011L,298336733L,798609437L,717629317L,320005681L,757789609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198173Inst : IEnumerable<long>
{
public static readonly long[] Value=A198173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198173.Bytes);
public long this[int i]=>Value[i];

public static A198173Inst Instance=new A198173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198174
{
public static readonly long[] Value={ 5926535897L,4197169399L,1693993751L,7510582097L,4825342117L,5822317253L,2841027019L,8521105559L,8954930381L,4756482337L,2712019091L,5432664821L,3266482133L,6072602491L,5588174881L,8815209209L,6282925409L,2540917153L,5903600113L,8204665213L,3841469519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198174Inst : IEnumerable<long>
{
public static readonly long[] Value=A198174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198174.Bytes);
public long this[int i]=>Value[i];

public static A198174Inst Instance=new A198174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198175
{
public static readonly long[] Value={ 31L,41L,59L,53L,89L,97L,79L,23L,43L,83L,79L,41L,19L,97L,71L,37L,97L,59L,23L,89L,53L,11L,17L,67L,79L,13L,23L,47L,23L,31L,17L,53L,59L,11L,11L,17L,41L,19L,11L,59L,29L,89L,19L,97L,59L,61L,47L,23L,37L,67L,83L,31L,71L,19L,23L,61L,43L,13L,41L,73L,37L,31L,17L,29L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198175Inst : IEnumerable<long>
{
public static readonly long[] Value=A198175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198175.Bytes);
public long this[int i]=>Value[i];

public static A198175Inst Instance=new A198175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198176
{
public static readonly long[] Value={ 1L,6L,168L,26880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198176Inst : IEnumerable<long>
{
public static readonly long[] Value=A198176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198176.Bytes);
public long this[int i]=>Value[i];

public static A198176Inst Instance=new A198176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198177
{
public static readonly long[] Value={ 1772030917L,4189391137L,6222353693L,7931800607L,5959395829L,5829056383L,3832266131L,6131992829L,6892501711L,9250171169L,1043216269L,3136144381L,7587012203L,7954454749L,8509874339L,4487706647L,1240076521L,7780531531L,5315317141L,1704666599L,7046665991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198177Inst : IEnumerable<long>
{
public static readonly long[] Value=A198177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198177.Bytes);
public long this[int i]=>Value[i];

public static A198177Inst Instance=new A198177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198178
{
public static readonly long[] Value={ 1L,4L,9L,59L,2033L,51688L,4522496L,559601114L,174674654015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198178Inst : IEnumerable<long>
{
public static readonly long[] Value=A198178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198178.Bytes);
public long this[int i]=>Value[i];

public static A198178Inst Instance=new A198178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198179
{
public static readonly long[] Value={ 0L,4L,3L,8L,16L,21L,56L,70L,171L,256L,516L,905L,1622L,3048L,5293L,9992L,17564L,32517L,58330L,106144L,192767L,348188L,634426L,1145535L,2084360L,3771658L,6847617L,12413706L,22507930L,40835531L,74015802L,134288434L,243440863L,441575714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198179Inst : IEnumerable<long>
{
public static readonly long[] Value=A198179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198179.Bytes);
public long this[int i]=>Value[i];

public static A198179Inst Instance=new A198179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198180
{
public static readonly long[] Value={ 1L,3L,9L,25L,77L,148L,395L,866L,2346L,5663L,14065L,34309L,84252L,208413L,513352L,1266410L,3117377L,7679699L,18927327L,46639092L,114949605L,283220762L,697929906L,1719783577L,4237987789L,10443340285L,25734497336L,63415169957L,156267786924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198180Inst : IEnumerable<long>
{
public static readonly long[] Value=A198180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198180.Bytes);
public long this[int i]=>Value[i];

public static A198180Inst Instance=new A198180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198181
{
public static readonly long[] Value={ 2L,8L,25L,59L,331L,883L,3485L,12030L,43774L,155664L,540628L,1936313L,6871687L,24471790L,86551688L,306708029L,1089956129L,3870392120L,13733968845L,48703981505L,172844148554L,613561265167L,2177517194687L,7726401450405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198181Inst : IEnumerable<long>
{
public static readonly long[] Value=A198181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198181.Bytes);
public long this[int i]=>Value[i];

public static A198181Inst Instance=new A198181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198182
{
public static readonly long[] Value={ 1L,16L,77L,331L,2033L,8298L,48958L,216307L,1155412L,5522239L,28200527L,139401115L,695721892L,3477106364L,17307490471L,86498278609L,430707067503L,2150928384789L,10722364479972L,53497634923663L,266813770707004L,1330929200315097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198182Inst : IEnumerable<long>
{
public static readonly long[] Value=A198182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198182.Bytes);
public long this[int i]=>Value[i];

public static A198182Inst Instance=new A198182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198183
{
public static readonly long[] Value={ 1L,21L,148L,883L,8298L,51688L,395340L,2639341L,19059216L,135044844L,958174742L,6800519266L,48283678834L,342710822044L,2431565681788L,17263106688089L,122543913785532L,869732001977147L,6173405546650902L,43819646823646105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198183Inst : IEnumerable<long>
{
public static readonly long[] Value=A198183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198183.Bytes);
public long this[int i]=>Value[i];

public static A198183Inst Instance=new A198183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198184
{
public static readonly long[] Value={ 3L,56L,395L,3485L,48958L,395340L,4522496L,41084248L,441157382L,4292509761L,44051823241L,438360876506L,4438621935572L,44610898968447L,449562512780134L,4527350842044875L,45564682527974566L,459054827920170371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198184Inst : IEnumerable<long>
{
public static readonly long[] Value=A198184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198184.Bytes);
public long this[int i]=>Value[i];

public static A198184Inst Instance=new A198184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198185
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,1L,2L,3L,3L,2L,1L,8L,9L,8L,1L,1L,16L,25L,25L,16L,1L,3L,21L,77L,59L,77L,21L,3L,3L,56L,148L,331L,331L,148L,56L,3L,2L,70L,395L,883L,2033L,883L,395L,70L,2L,4L,171L,866L,3485L,8298L,8298L,3485L,866L,171L,4L,6L,256L,2346L,12030L,48958L,51688L,48958L,12030L,2346L,256L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198185Inst : IEnumerable<long>
{
public static readonly long[] Value=A198185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198185.Bytes);
public long this[int i]=>Value[i];

public static A198185Inst Instance=new A198185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198186
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,18L,24L,36L,48L,60L,84L,96L,108L,120L,156L,168L,180L,228L,240L,300L,360L,480L,600L,660L,720L,900L,960L,1080L,1320L,1380L,1440L,1620L,1800L,1920L,2160L,2400L,2520L,3360L,3840L,3960L,4320L,4680L,4800L,4860L,5040L,7560L,10080L,12600L,15120L,17640L,20160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198186Inst : IEnumerable<long>
{
public static readonly long[] Value=A198186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198186.Bytes);
public long this[int i]=>Value[i];

public static A198186Inst Instance=new A198186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198187
{
public static readonly long[] Value={ 3L,31L,41L,5L,59L,4159L,14159L,314159L,2L,5L,3L,53L,653L,1592653L,5L,89L,141592653589L,7L,97L,5897L,35897L,6535897L,5926535897L,415926535897L,79L,58979L,358979L,3L,589793L,2L,3L,23L,9323L,9265358979323L,2L,3L,43L,643L,462643L,93238462643L,3L,433L,3L,83L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198187Inst : IEnumerable<long>
{
public static readonly long[] Value=A198187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198187.Bytes);
public long this[int i]=>Value[i];

public static A198187Inst Instance=new A198187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198188
{
public static readonly BigInteger[] Value={ 2L,7L,71L,271L,2L,281L,2718281L,2L,5L,59L,5L,2L,3L,23L,523L,4523L,904523L,5L,3L,53L,353L,8284590452353L,2L,7L,360287L,28459045235360287L,7L,47L,8747L,6028747L,BigInteger.Parse("8182845904523536028747"),71L,360287471L,BigInteger.Parse("8281828459045235360287471"),3L,13L,74713L,BigInteger.Parse("82818284590452353602874713") };
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
public class A198188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198188Inst Instance=new A198188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198189
{
public static readonly BigInteger[] Value={ 61L,3L,3L,1618033L,7L,887L,9887L,39887L,339887L,1618033988749L,89L,8874989L,398874989L,803398874989L,61803398874989L,2L,5L,3L,83L,683L,458683L,3L,43L,5L,3L,563L,6563L,36563L,868343656381L,BigInteger.Parse("180339887498948482045868343656381"),11L,811L,58683436563811L };
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
public class A198189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198189Inst Instance=new A198189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198190
{
public static readonly BigInteger[] Value={ 41L,2L,421L,3L,13L,5L,2L,3L,23L,5623L,135623L,42135623L,4142135623L,7L,37L,56237L,3L,73L,373L,3562373L,213562373L,7309L,37309L,5L,5048801L,BigInteger.Parse("414213562373095048801"),7L,887L,488016887L,BigInteger.Parse("142135623730950488016887"),2L,2L,688724209L,BigInteger.Parse("414213562373095048801688724209") };
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
public class A198190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198190Inst Instance=new A198190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198191
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,11L,12L,13L,17L,18L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,41L,43L,44L,45L,47L,52L,53L,59L,60L,61L,67L,68L,71L,73L,74L,75L,77L,78L,79L,81L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L,98L,100L,101L,103L,104L,105L,107L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198191Inst : IEnumerable<long>
{
public static readonly long[] Value=A198191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198191.Bytes);
public long this[int i]=>Value[i];

public static A198191Inst Instance=new A198191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198192
{
public static readonly long[] Value={ 0L,1L,1L,5L,2L,8L,9L,18L,5L,15L,16L,29L,19L,34L,36L,54L,12L,30L,31L,52L,34L,57L,59L,85L,41L,68L,70L,100L,75L,107L,110L,145L,27L,61L,62L,99L,65L,104L,106L,148L,72L,115L,117L,163L,122L,170L,173L,224L,87L,138L,140L,194L,145L,201L,204L,263L,156L,216L,219L,282L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198192Inst : IEnumerable<long>
{
public static readonly long[] Value=A198192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198192.Bytes);
public long this[int i]=>Value[i];

public static A198192Inst Instance=new A198192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198193
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,8L,11L,18L,8L,15L,18L,28L,23L,35L,39L,54L,16L,30L,33L,50L,38L,57L,61L,83L,47L,70L,74L,100L,81L,109L,114L,145L,32L,61L,64L,96L,69L,103L,107L,144L,78L,116L,120L,161L,127L,170L,175L,221L,95L,141L,145L,194L,152L,203L,208L,262L,165L,220L,225L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198193Inst : IEnumerable<long>
{
public static readonly long[] Value=A198193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198193.Bytes);
public long this[int i]=>Value[i];

public static A198193Inst Instance=new A198193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198194
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198194Inst : IEnumerable<long>
{
public static readonly long[] Value=A198194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198194.Bytes);
public long this[int i]=>Value[i];

public static A198194Inst Instance=new A198194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198195
{
public static readonly long[] Value={ 509L,31L,7L,7L,7L,19L,13L,3L,3L,3L,97L,11L,17L,41L,41L,11L,2L,313L,2L,2L,137L,2L,2L,281L,227L,149L,149L,197L,281L,191L,101L,569L,191L,857L,827L,311L,569L,599L,431L,599L,1451L,1091L,809L,1019L,419L,1667L,2237L,4517L,5009L,3671L,1997L,1289L,1451L,3329L,3329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198195Inst : IEnumerable<long>
{
public static readonly long[] Value=A198195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198195.Bytes);
public long this[int i]=>Value[i];

public static A198195Inst Instance=new A198195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198196
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,79L,151L,199L,233L,251L,317L,863L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198196Inst : IEnumerable<long>
{
public static readonly long[] Value=A198196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198196.Bytes);
public long this[int i]=>Value[i];

public static A198196Inst Instance=new A198196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198197
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,-1L,-2L,-3L,-3L,-2L,0L,2L,2L,0L,-1L,2L,8L,12L,11L,8L,7L,7L,5L,2L,1L,2L,4L,7L,7L,-3L,-21L,-34L,-34L,-28L,-28L,-37L,-46L,-42L,-22L,-1L,-1L,-28L,-62L,-75L,-60L,-35L,-16L,1L,25L,53L,77L,93L,97L,90L,91L,121L,165L,175L,129L,70L,64L,127L,213L,267L,273L,261L,278L,329L,340L,225L,11L,-155L,-160L,-50L,25L,-40L,-223L,-406L,-475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198197Inst : IEnumerable<long>
{
public static readonly long[] Value=A198197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198197.Bytes);
public long this[int i]=>Value[i];

public static A198197Inst Instance=new A198197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198198
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,25L,216L,1561L,19328L,225681L,3790720L,54595921L,1141489152L,20620975849L,519551642624L,11074307974185L,325796967940096L,8068953248603809L,271784019897188352L,7647972455738262817L,BigInteger.Parse("290140183695205990400"),BigInteger.Parse("9154902981606486123321") };
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
public class A198198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198198Inst Instance=new A198198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198199
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,-2L,-2L,-1L,2L,5L,6L,7L,10L,12L,8L,-1L,-8L,-11L,-16L,-26L,-38L,-50L,-58L,-52L,-30L,-8L,0L,4L,24L,63L,112L,170L,232L,268L,252L,208L,186L,193L,190L,154L,92L,-5L,-164L,-383L,-630L,-873L,-1062L,-1128L,-1080L,-1055L,-1172L,-1374L,-1508L,-1508L,-1392L,-1139L,-700L,-85L,684L,1627L,2652L,3455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198199Inst : IEnumerable<long>
{
public static readonly long[] Value=A198199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198199.Bytes);
public long this[int i]=>Value[i];

public static A198199Inst Instance=new A198199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198200
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,6L,10L,16L,28L,48L,79L,130L,215L,356L,587L,960L,1566L,2558L,4176L,6804L,11066L,17978L,29198L,47406L,76916L,124716L,202152L,327600L,530775L,859734L,1392265L,2254336L,3649840L,5908632L,9564377L,15480706L,25055322L,40549980L,65624224L,106199306L,171856555L,278099872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198200Inst : IEnumerable<long>
{
public static readonly long[] Value=A198200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198200.Bytes);
public long this[int i]=>Value[i];

public static A198200Inst Instance=new A198200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198201
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,4L,6L,9L,14L,18L,18L,16L,67L,67L,66L,72L,84L,99L,117L,138L,159L,468L,516L,578L,679L,810L,933L,1018L,1072L,1138L,1262L,1448L,4745L,5196L,5851L,6630L,7382L,8031L,8649L,9405L,10409L,11569L,12649L,13530L,14378L,51022L,55567L,60439L,65906L,71953L,78283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198201Inst : IEnumerable<long>
{
public static readonly long[] Value=A198201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198201.Bytes);
public long this[int i]=>Value[i];

public static A198201Inst Instance=new A198201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198202
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,5L,8L,13L,22L,31L,32L,89L,115L,126L,122L,118L,127L,150L,178L,198L,653L,747L,835L,921L,1011L,1113L,1236L,1377L,1520L,1661L,1823L,6483L,6894L,7584L,8646L,9906L,11074L,11995L,12787L,13752L,15105L,16742L,18316L,19608L,71188L,78144L,84610L,90794L,97895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198202Inst : IEnumerable<long>
{
public static readonly long[] Value=A198202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198202.Bytes);
public long this[int i]=>Value[i];

public static A198202Inst Instance=new A198202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198203
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,160L,3418L,179705L,19488053L,4590422901L,2738580784946L,3583015072969210L,9255051219746866753UL,BigInteger.Parse("56916338252385095986978"),BigInteger.Parse("871826913772059843867743765"),BigInteger.Parse("26753845554560439025697319191184"),BigInteger.Parse("1695956186616651065722319776300825712") };
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
public class A198203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198203Inst Instance=new A198203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198204
{
public static readonly long[] Value={ 1L,1L,2L,1L,9L,12L,1L,28L,120L,120L,1L,75L,750L,2100L,1680L,1L,186L,3780L,21840L,45360L,30240L,1L,441L,16856L,176400L,705600L,1164240L,665280L,1L,1016L,69552L,1224720L,8316000L,25280640L,34594560L,17297280L,1L,2295L,272250L,7692300L,82577880L,408648240L,998917920L,1167566400L,518918400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198204Inst : IEnumerable<long>
{
public static readonly long[] Value=A198204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198204.Bytes);
public long this[int i]=>Value[i];

public static A198204Inst Instance=new A198204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198205
{
public static readonly long[] Value={ 4L,43L,658L,11029L,189376L,3272959L,56665678L,981535273L,17003856124L,294580477651L,5103458162314L,88415060881213L,1531751228239288L,26536907089886119L,459740106490112326L,7964792868501695569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198205Inst : IEnumerable<long>
{
public static readonly long[] Value=A198205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198205.Bytes);
public long this[int i]=>Value[i];

public static A198205Inst Instance=new A198205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198206
{
public static readonly BigInteger[] Value={ 43L,1765L,50729L,1660672L,56315642L,1930887802L,66941645630L,2331298473193L,81407459944121L,2846734759084627L,99622031525717855L,3487698946608204322L,BigInteger.Parse("122128077706715335280"),BigInteger.Parse("4277023178407978272400"),BigInteger.Parse("149793878862653254021508") };
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
public class A198206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198206Inst Instance=new A198206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198207
{
public static readonly BigInteger[] Value={ 658L,50729L,3603458L,276030525L,21989253467L,1791994477631L,148260119458624L,12388301166414053L,1042156486950351473L,BigInteger.Parse("88068293220220746165"),BigInteger.Parse("7464940011082766165729"),BigInteger.Parse("634039417143962239696103") };
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
public class A198207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198207Inst Instance=new A198207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198208
{
public static readonly long[] Value={ 11029L,1660672L,276030525L,51432469614L,10120087499636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198208Inst : IEnumerable<long>
{
public static readonly long[] Value=A198208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198208.Bytes);
public long this[int i]=>Value[i];

public static A198208Inst Instance=new A198208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198209
{
public static readonly long[] Value={ 4L,43L,43L,658L,1765L,658L,11029L,50729L,50729L,11029L,189376L,1660672L,3603458L,1660672L,189376L,3272959L,56315642L,276030525L,276030525L,56315642L,3272959L,56665678L,1930887802L,21989253467L,51432469614L,21989253467L,1930887802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198209Inst : IEnumerable<long>
{
public static readonly long[] Value=A198209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198209.Bytes);
public long this[int i]=>Value[i];

public static A198209Inst Instance=new A198209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198210
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,68L,0L,255L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,272L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1020L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198210Inst : IEnumerable<long>
{
public static readonly long[] Value=A198210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198210.Bytes);
public long this[int i]=>Value[i];

public static A198210Inst Instance=new A198210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198211
{
public static readonly long[] Value={ 5L,3L,5L,4L,2L,8L,2L,4L,4L,1L,6L,4L,6L,5L,6L,9L,1L,4L,1L,2L,5L,9L,7L,8L,6L,8L,5L,3L,0L,8L,3L,9L,7L,3L,8L,0L,8L,7L,9L,6L,8L,4L,4L,3L,9L,2L,2L,7L,5L,1L,4L,6L,3L,0L,1L,8L,7L,8L,4L,2L,0L,9L,8L,6L,7L,4L,8L,3L,8L,7L,7L,8L,4L,5L,6L,9L,7L,8L,4L,5L,0L,0L,9L,7L,5L,4L,8L,8L,0L,9L,7L,2L,8L,9L,1L,9L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198211Inst : IEnumerable<long>
{
public static readonly long[] Value=A198211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198211.Bytes);
public long this[int i]=>Value[i];

public static A198211Inst Instance=new A198211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198212
{
public static readonly long[] Value={ 7L,1L,0L,7L,9L,4L,6L,8L,7L,7L,7L,4L,4L,6L,5L,3L,3L,7L,8L,4L,6L,7L,3L,5L,2L,9L,1L,4L,7L,5L,3L,2L,7L,5L,9L,4L,3L,3L,2L,3L,7L,4L,4L,0L,8L,7L,1L,7L,6L,4L,0L,0L,4L,0L,2L,2L,4L,3L,3L,1L,6L,6L,1L,9L,5L,3L,8L,0L,2L,0L,4L,7L,2L,3L,1L,7L,4L,4L,8L,3L,4L,5L,1L,0L,6L,0L,6L,4L,8L,9L,0L,1L,9L,2L,3L,9L,8L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198212Inst : IEnumerable<long>
{
public static readonly long[] Value=A198212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198212.Bytes);
public long this[int i]=>Value[i];

public static A198212Inst Instance=new A198212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198213
{
public static readonly long[] Value={ 9L,0L,6L,5L,9L,2L,4L,7L,4L,0L,9L,2L,4L,3L,7L,9L,6L,6L,9L,7L,9L,3L,0L,6L,8L,2L,4L,6L,7L,2L,1L,4L,9L,3L,8L,0L,6L,0L,4L,9L,7L,0L,7L,3L,7L,7L,5L,2L,2L,3L,6L,1L,4L,9L,7L,3L,2L,4L,7L,2L,0L,4L,1L,9L,2L,1L,2L,1L,6L,4L,9L,5L,8L,2L,5L,2L,1L,8L,0L,7L,1L,5L,3L,3L,3L,1L,3L,1L,1L,3L,6L,8L,2L,3L,7L,4L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198213Inst : IEnumerable<long>
{
public static readonly long[] Value=A198213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198213.Bytes);
public long this[int i]=>Value[i];

public static A198213Inst Instance=new A198213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198214
{
public static readonly long[] Value={ 6L,9L,8L,6L,5L,6L,7L,0L,5L,5L,3L,2L,3L,6L,0L,2L,6L,2L,8L,3L,7L,9L,0L,4L,6L,5L,8L,4L,0L,1L,6L,6L,0L,3L,2L,2L,9L,3L,5L,4L,5L,6L,2L,1L,2L,5L,9L,4L,7L,3L,1L,4L,2L,0L,8L,0L,6L,8L,3L,5L,4L,7L,3L,7L,3L,9L,6L,9L,1L,5L,0L,7L,3L,5L,3L,1L,4L,2L,4L,1L,0L,5L,2L,4L,8L,3L,1L,7L,4L,7L,2L,5L,2L,1L,3L,2L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198214Inst : IEnumerable<long>
{
public static readonly long[] Value=A198214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198214.Bytes);
public long this[int i]=>Value[i];

public static A198214Inst Instance=new A198214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198215
{
public static readonly long[] Value={ 4L,1L,0L,7L,3L,0L,5L,6L,8L,1L,0L,5L,3L,1L,9L,6L,7L,8L,8L,4L,2L,6L,1L,6L,3L,2L,1L,6L,8L,8L,4L,2L,9L,3L,2L,6L,3L,7L,9L,5L,7L,1L,5L,3L,6L,1L,1L,2L,5L,4L,5L,5L,4L,5L,6L,9L,4L,6L,9L,7L,5L,4L,1L,5L,7L,2L,2L,8L,2L,7L,3L,8L,9L,2L,4L,0L,5L,3L,7L,7L,8L,6L,8L,6L,6L,3L,0L,0L,5L,0L,5L,8L,3L,1L,8L,5L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198215Inst : IEnumerable<long>
{
public static readonly long[] Value=A198215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198215.Bytes);
public long this[int i]=>Value[i];

public static A198215Inst Instance=new A198215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198216
{
public static readonly long[] Value={ 8L,5L,0L,4L,4L,0L,0L,8L,1L,4L,2L,7L,0L,0L,8L,5L,3L,8L,5L,4L,7L,9L,1L,3L,1L,7L,7L,8L,9L,1L,5L,5L,7L,8L,2L,5L,8L,5L,6L,6L,9L,5L,9L,9L,1L,4L,6L,9L,9L,8L,3L,3L,9L,3L,8L,3L,7L,3L,5L,4L,8L,7L,8L,8L,1L,2L,2L,2L,4L,3L,4L,5L,2L,2L,6L,4L,2L,2L,8L,7L,0L,0L,8L,6L,1L,1L,9L,6L,7L,7L,4L,3L,3L,7L,5L,9L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198216Inst : IEnumerable<long>
{
public static readonly long[] Value=A198216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198216.Bytes);
public long this[int i]=>Value[i];

public static A198216Inst Instance=new A198216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198217
{
public static readonly long[] Value={ 5L,9L,4L,8L,6L,3L,2L,8L,0L,3L,5L,7L,7L,1L,8L,7L,1L,4L,1L,7L,1L,5L,9L,2L,0L,7L,7L,9L,0L,1L,0L,2L,7L,8L,7L,9L,8L,5L,8L,9L,2L,3L,1L,4L,3L,6L,2L,3L,3L,0L,7L,1L,6L,5L,9L,4L,0L,1L,0L,4L,6L,0L,3L,6L,1L,2L,2L,2L,0L,2L,3L,7L,9L,1L,3L,1L,2L,7L,6L,0L,4L,4L,5L,2L,2L,4L,8L,4L,5L,7L,6L,4L,2L,3L,6L,0L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198217Inst : IEnumerable<long>
{
public static readonly long[] Value=A198217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198217.Bytes);
public long this[int i]=>Value[i];

public static A198217Inst Instance=new A198217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198218
{
public static readonly long[] Value={ 9L,4L,8L,2L,5L,4L,6L,0L,7L,7L,3L,9L,1L,7L,3L,6L,6L,2L,9L,6L,4L,1L,7L,3L,3L,3L,4L,7L,5L,5L,7L,4L,6L,5L,0L,3L,6L,9L,4L,7L,2L,8L,0L,3L,9L,9L,1L,4L,4L,6L,9L,1L,8L,4L,1L,1L,3L,2L,2L,3L,4L,4L,2L,7L,1L,1L,1L,7L,5L,7L,6L,5L,3L,9L,9L,3L,4L,2L,0L,9L,7L,3L,1L,8L,5L,1L,5L,6L,4L,2L,6L,7L,6L,1L,2L,2L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198218Inst : IEnumerable<long>
{
public static readonly long[] Value=A198218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198218.Bytes);
public long this[int i]=>Value[i];

public static A198218Inst Instance=new A198218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198219
{
public static readonly long[] Value={ 7L,1L,7L,2L,8L,5L,1L,7L,0L,8L,0L,2L,5L,7L,9L,3L,7L,2L,6L,8L,0L,2L,5L,0L,7L,2L,8L,2L,8L,2L,1L,1L,6L,9L,1L,5L,3L,4L,4L,4L,6L,0L,8L,6L,7L,8L,7L,1L,9L,5L,8L,6L,9L,1L,4L,1L,2L,2L,9L,6L,0L,1L,7L,4L,4L,9L,3L,9L,0L,5L,6L,7L,3L,6L,8L,7L,6L,5L,9L,2L,4L,9L,9L,2L,3L,2L,3L,6L,1L,3L,6L,5L,4L,4L,1L,7L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198219Inst : IEnumerable<long>
{
public static readonly long[] Value=A198219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198219.Bytes);
public long this[int i]=>Value[i];

public static A198219Inst Instance=new A198219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198220
{
public static readonly long[] Value={ 1L,0L,1L,9L,0L,9L,2L,5L,0L,2L,8L,1L,5L,4L,1L,8L,0L,6L,7L,9L,8L,4L,1L,7L,9L,1L,2L,6L,0L,8L,9L,8L,5L,9L,0L,3L,6L,9L,6L,2L,2L,3L,0L,4L,4L,2L,0L,6L,4L,4L,7L,2L,2L,9L,4L,8L,2L,0L,6L,4L,1L,7L,4L,3L,6L,4L,6L,3L,9L,2L,2L,2L,2L,2L,8L,3L,2L,4L,7L,7L,8L,9L,1L,6L,3L,7L,3L,7L,3L,9L,3L,4L,6L,3L,8L,0L,8L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198220Inst : IEnumerable<long>
{
public static readonly long[] Value=A198220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198220.Bytes);
public long this[int i]=>Value[i];

public static A198220Inst Instance=new A198220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198221
{
public static readonly long[] Value={ 8L,0L,7L,6L,7L,8L,4L,8L,2L,4L,2L,7L,2L,1L,0L,6L,5L,0L,9L,1L,8L,0L,5L,7L,2L,1L,3L,0L,7L,8L,3L,7L,5L,6L,6L,3L,5L,0L,3L,8L,6L,6L,3L,6L,1L,6L,6L,1L,1L,3L,0L,6L,4L,0L,9L,0L,6L,6L,7L,9L,8L,0L,4L,1L,2L,7L,9L,3L,8L,4L,5L,9L,3L,1L,7L,3L,4L,2L,5L,1L,7L,7L,5L,5L,3L,8L,9L,7L,0L,5L,9L,1L,5L,1L,4L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198221Inst : IEnumerable<long>
{
public static readonly long[] Value=A198221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198221.Bytes);
public long this[int i]=>Value[i];

public static A198221Inst Instance=new A198221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198222
{
public static readonly long[] Value={ 8L,9L,7L,9L,9L,1L,2L,1L,7L,8L,1L,5L,7L,7L,3L,7L,2L,3L,2L,7L,0L,9L,4L,3L,4L,7L,4L,5L,5L,1L,2L,3L,8L,3L,2L,2L,3L,4L,4L,2L,6L,5L,1L,2L,3L,7L,9L,3L,4L,8L,0L,7L,1L,3L,1L,4L,1L,5L,1L,3L,4L,7L,0L,8L,1L,2L,5L,4L,3L,5L,5L,9L,8L,9L,3L,2L,4L,5L,5L,8L,5L,1L,9L,4L,4L,4L,4L,2L,6L,7L,2L,5L,8L,4L,4L,1L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198222Inst : IEnumerable<long>
{
public static readonly long[] Value=A198222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198222.Bytes);
public long this[int i]=>Value[i];

public static A198222Inst Instance=new A198222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198223
{
public static readonly long[] Value={ 3L,2L,0L,4L,8L,0L,4L,7L,7L,9L,6L,9L,1L,3L,5L,7L,1L,1L,4L,2L,1L,6L,2L,3L,4L,7L,6L,1L,8L,2L,6L,7L,6L,3L,9L,3L,7L,8L,4L,5L,5L,5L,3L,8L,8L,8L,5L,1L,4L,1L,9L,5L,8L,6L,4L,5L,8L,2L,0L,0L,4L,5L,4L,9L,0L,4L,1L,3L,1L,3L,2L,2L,3L,0L,9L,5L,9L,5L,7L,0L,9L,4L,9L,4L,6L,8L,9L,1L,9L,2L,2L,9L,8L,5L,6L,0L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198223Inst : IEnumerable<long>
{
public static readonly long[] Value=A198223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198223.Bytes);
public long this[int i]=>Value[i];

public static A198223Inst Instance=new A198223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198224
{
public static readonly long[] Value={ 1L,0L,1L,4L,0L,6L,0L,5L,8L,2L,6L,8L,7L,9L,0L,1L,0L,7L,2L,2L,1L,4L,7L,7L,7L,7L,0L,6L,5L,5L,2L,9L,7L,9L,9L,7L,3L,0L,9L,4L,2L,4L,8L,2L,7L,2L,3L,1L,2L,7L,8L,4L,0L,3L,8L,8L,3L,8L,1L,9L,8L,8L,5L,4L,5L,4L,0L,0L,1L,9L,0L,1L,3L,1L,2L,9L,2L,8L,6L,2L,4L,3L,0L,8L,1L,8L,8L,3L,4L,5L,9L,3L,5L,7L,0L,7L,5L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198224Inst : IEnumerable<long>
{
public static readonly long[] Value=A198224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198224.Bytes);
public long this[int i]=>Value[i];

public static A198224Inst Instance=new A198224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198225
{
public static readonly long[] Value={ 5L,0L,0L,8L,6L,6L,3L,1L,0L,2L,5L,3L,0L,1L,1L,7L,6L,9L,7L,9L,0L,8L,0L,2L,7L,5L,4L,6L,9L,4L,6L,5L,6L,3L,3L,0L,3L,2L,1L,5L,5L,6L,9L,7L,4L,9L,5L,5L,9L,5L,6L,2L,7L,5L,7L,4L,5L,2L,1L,3L,3L,0L,3L,1L,2L,7L,4L,0L,4L,8L,0L,4L,4L,3L,8L,4L,7L,3L,5L,1L,5L,1L,5L,2L,3L,9L,2L,8L,1L,5L,2L,3L,5L,5L,3L,9L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198225Inst : IEnumerable<long>
{
public static readonly long[] Value=A198225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198225.Bytes);
public long this[int i]=>Value[i];

public static A198225Inst Instance=new A198225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198226
{
public static readonly long[] Value={ 1L,0L,9L,0L,4L,3L,8L,2L,5L,6L,0L,3L,8L,8L,7L,4L,4L,0L,8L,9L,2L,5L,2L,0L,3L,5L,1L,2L,6L,0L,6L,8L,0L,6L,5L,3L,7L,2L,5L,2L,4L,7L,5L,9L,2L,4L,1L,5L,3L,5L,9L,8L,0L,5L,0L,3L,7L,7L,3L,9L,4L,4L,1L,1L,3L,8L,6L,7L,7L,7L,3L,1L,4L,3L,0L,8L,6L,0L,7L,4L,9L,8L,1L,3L,9L,1L,7L,6L,9L,1L,1L,0L,3L,1L,0L,8L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198226Inst : IEnumerable<long>
{
public static readonly long[] Value=A198226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198226.Bytes);
public long this[int i]=>Value[i];

public static A198226Inst Instance=new A198226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198227
{
public static readonly long[] Value={ 6L,2L,6L,4L,6L,6L,3L,3L,7L,8L,4L,9L,2L,9L,1L,8L,6L,3L,0L,1L,2L,3L,5L,0L,1L,0L,6L,3L,3L,5L,8L,7L,6L,2L,0L,5L,1L,7L,8L,9L,2L,9L,3L,3L,5L,8L,2L,0L,0L,9L,5L,1L,5L,5L,0L,3L,9L,9L,0L,7L,8L,1L,3L,9L,4L,8L,6L,1L,4L,5L,9L,9L,3L,6L,8L,6L,8L,3L,4L,8L,4L,1L,9L,0L,9L,8L,8L,5L,9L,7L,9L,7L,7L,0L,7L,2L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198227Inst : IEnumerable<long>
{
public static readonly long[] Value=A198227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198227.Bytes);
public long this[int i]=>Value[i];

public static A198227Inst Instance=new A198227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198228
{
public static readonly long[] Value={ 1L,1L,4L,6L,0L,6L,9L,5L,8L,0L,2L,1L,0L,4L,4L,1L,8L,1L,3L,3L,9L,4L,3L,5L,1L,1L,9L,5L,7L,8L,0L,6L,1L,1L,8L,3L,1L,9L,6L,9L,7L,1L,2L,7L,5L,0L,3L,5L,7L,5L,4L,0L,7L,7L,1L,5L,5L,7L,0L,1L,3L,0L,4L,9L,3L,6L,2L,3L,7L,0L,6L,6L,8L,2L,1L,7L,8L,2L,2L,1L,5L,8L,2L,5L,7L,1L,7L,2L,9L,2L,4L,0L,2L,2L,2L,0L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198228Inst : IEnumerable<long>
{
public static readonly long[] Value=A198228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198228.Bytes);
public long this[int i]=>Value[i];

public static A198228Inst Instance=new A198228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198229
{
public static readonly long[] Value={ 7L,2L,1L,3L,4L,1L,3L,0L,7L,6L,4L,8L,0L,1L,5L,5L,8L,2L,4L,2L,1L,0L,3L,1L,7L,2L,2L,8L,7L,2L,3L,0L,6L,4L,4L,8L,0L,7L,1L,3L,2L,7L,4L,5L,7L,8L,8L,7L,2L,6L,1L,7L,7L,3L,1L,8L,9L,8L,8L,0L,8L,7L,2L,0L,6L,2L,1L,0L,8L,1L,3L,0L,5L,2L,7L,1L,2L,8L,1L,1L,4L,2L,2L,4L,1L,6L,5L,1L,3L,1L,8L,1L,0L,5L,3L,3L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198229Inst : IEnumerable<long>
{
public static readonly long[] Value=A198229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198229.Bytes);
public long this[int i]=>Value[i];

public static A198229Inst Instance=new A198229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198230
{
public static readonly long[] Value={ 1L,1L,2L,6L,9L,9L,6L,5L,9L,6L,1L,1L,1L,3L,9L,9L,6L,5L,8L,3L,4L,5L,2L,3L,7L,3L,8L,4L,3L,2L,5L,4L,0L,4L,8L,5L,4L,9L,3L,7L,7L,7L,1L,3L,8L,6L,4L,4L,6L,8L,9L,1L,7L,0L,7L,6L,6L,3L,8L,2L,1L,6L,3L,8L,9L,7L,3L,2L,5L,0L,6L,1L,3L,0L,0L,6L,9L,5L,4L,3L,3L,5L,9L,8L,1L,1L,2L,2L,2L,6L,6L,1L,7L,3L,1L,2L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198230Inst : IEnumerable<long>
{
public static readonly long[] Value=A198230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198230.Bytes);
public long this[int i]=>Value[i];

public static A198230Inst Instance=new A198230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198231
{
public static readonly long[] Value={ 2L,5L,6L,5L,8L,4L,9L,3L,4L,2L,2L,3L,5L,6L,9L,4L,4L,0L,1L,5L,0L,4L,5L,7L,9L,4L,7L,4L,9L,9L,0L,9L,3L,5L,5L,9L,7L,4L,9L,3L,1L,3L,4L,1L,1L,9L,4L,6L,0L,6L,7L,2L,9L,3L,7L,2L,5L,2L,0L,1L,7L,4L,8L,4L,7L,5L,7L,2L,0L,4L,3L,3L,0L,3L,2L,9L,1L,8L,9L,9L,0L,1L,8L,4L,9L,6L,1L,4L,3L,3L,4L,1L,3L,0L,9L,1L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198231Inst : IEnumerable<long>
{
public static readonly long[] Value=A198231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198231.Bytes);
public long this[int i]=>Value[i];

public static A198231Inst Instance=new A198231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198232
{
public static readonly long[] Value={ 1L,2L,0L,0L,7L,7L,7L,2L,7L,8L,5L,1L,7L,3L,9L,1L,2L,9L,0L,6L,6L,3L,6L,5L,4L,5L,8L,7L,6L,8L,2L,6L,7L,1L,2L,8L,3L,9L,0L,6L,4L,6L,0L,6L,7L,4L,0L,2L,6L,8L,3L,9L,5L,7L,3L,8L,7L,5L,7L,4L,8L,1L,3L,5L,6L,4L,6L,4L,3L,0L,1L,6L,8L,4L,8L,9L,1L,9L,8L,5L,8L,9L,2L,9L,7L,8L,0L,6L,7L,0L,0L,6L,1L,6L,9L,7L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198232Inst : IEnumerable<long>
{
public static readonly long[] Value=A198232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198232.Bytes);
public long this[int i]=>Value[i];

public static A198232Inst Instance=new A198232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198233
{
public static readonly long[] Value={ 4L,2L,5L,8L,1L,5L,7L,1L,0L,7L,4L,8L,3L,1L,6L,9L,8L,4L,5L,6L,8L,9L,2L,2L,3L,2L,1L,6L,3L,4L,1L,4L,8L,0L,8L,7L,0L,5L,3L,8L,5L,1L,4L,4L,7L,8L,5L,9L,6L,2L,9L,9L,8L,0L,0L,1L,1L,5L,3L,5L,2L,9L,4L,3L,8L,6L,2L,1L,4L,1L,1L,7L,9L,7L,6L,1L,3L,3L,1L,6L,0L,9L,1L,4L,5L,3L,3L,8L,4L,6L,5L,8L,4L,5L,7L,1L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198233Inst : IEnumerable<long>
{
public static readonly long[] Value=A198233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198233.Bytes);
public long this[int i]=>Value[i];

public static A198233Inst Instance=new A198233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198234
{
public static readonly long[] Value={ 1L,2L,8L,8L,3L,8L,9L,2L,3L,7L,3L,2L,2L,8L,2L,6L,9L,2L,0L,4L,4L,6L,9L,5L,3L,7L,6L,1L,9L,8L,4L,1L,5L,2L,6L,3L,6L,5L,4L,6L,9L,2L,7L,5L,3L,7L,0L,8L,5L,4L,5L,5L,9L,2L,9L,1L,2L,6L,9L,9L,7L,2L,0L,6L,3L,6L,3L,3L,2L,7L,2L,4L,5L,6L,6L,2L,9L,8L,9L,2L,8L,5L,0L,3L,6L,9L,9L,0L,3L,4L,9L,0L,3L,7L,6L,8L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198234Inst : IEnumerable<long>
{
public static readonly long[] Value=A198234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198234.Bytes);
public long this[int i]=>Value[i];

public static A198234Inst Instance=new A198234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198235
{
public static readonly long[] Value={ 6L,4L,6L,4L,3L,5L,5L,6L,7L,5L,2L,7L,7L,2L,2L,5L,8L,8L,3L,7L,9L,1L,3L,3L,8L,2L,8L,1L,0L,8L,7L,4L,3L,8L,8L,9L,3L,9L,7L,9L,1L,9L,1L,6L,8L,5L,7L,2L,7L,9L,8L,9L,6L,7L,9L,8L,9L,0L,5L,4L,7L,6L,1L,3L,1L,2L,9L,2L,5L,5L,6L,6L,3L,6L,3L,9L,0L,5L,4L,5L,4L,8L,0L,5L,8L,4L,8L,6L,8L,1L,2L,8L,3L,7L,0L,5L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198235Inst : IEnumerable<long>
{
public static readonly long[] Value=A198235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198235.Bytes);
public long this[int i]=>Value[i];

public static A198235Inst Instance=new A198235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198236
{
public static readonly long[] Value={ 1L,3L,7L,9L,3L,2L,3L,3L,2L,0L,9L,8L,6L,8L,8L,7L,6L,5L,8L,6L,3L,7L,2L,5L,6L,1L,8L,9L,5L,6L,0L,1L,7L,3L,7L,8L,7L,6L,6L,2L,5L,8L,2L,2L,2L,4L,2L,6L,9L,6L,0L,7L,5L,0L,0L,8L,7L,2L,2L,6L,0L,0L,6L,2L,4L,6L,3L,9L,2L,1L,1L,7L,7L,2L,4L,9L,2L,0L,8L,1L,2L,3L,8L,0L,4L,4L,9L,4L,7L,9L,7L,6L,9L,8L,2L,0L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198236Inst : IEnumerable<long>
{
public static readonly long[] Value=A198236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198236.Bytes);
public long this[int i]=>Value[i];

public static A198236Inst Instance=new A198236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198237
{
public static readonly long[] Value={ 2L,1L,1L,0L,4L,7L,2L,9L,4L,4L,9L,0L,0L,4L,0L,2L,8L,4L,2L,0L,8L,2L,1L,9L,2L,9L,2L,6L,6L,0L,1L,9L,0L,8L,2L,8L,8L,0L,8L,4L,5L,8L,3L,4L,0L,1L,0L,3L,0L,2L,3L,9L,4L,9L,9L,4L,3L,9L,5L,2L,1L,7L,4L,2L,3L,5L,6L,7L,1L,9L,7L,8L,1L,2L,9L,8L,7L,1L,4L,9L,3L,9L,2L,3L,8L,1L,5L,5L,4L,6L,8L,2L,7L,8L,7L,6L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198237Inst : IEnumerable<long>
{
public static readonly long[] Value=A198237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198237.Bytes);
public long this[int i]=>Value[i];

public static A198237Inst Instance=new A198237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198238
{
public static readonly long[] Value={ 1L,4L,0L,9L,3L,6L,3L,9L,2L,1L,6L,3L,5L,7L,7L,7L,8L,4L,4L,7L,7L,2L,8L,6L,9L,3L,6L,8L,8L,0L,1L,5L,3L,9L,7L,9L,5L,1L,1L,7L,7L,3L,5L,0L,3L,8L,5L,9L,2L,6L,5L,8L,5L,5L,0L,3L,9L,0L,2L,5L,4L,6L,5L,2L,1L,7L,9L,0L,0L,3L,7L,0L,4L,7L,8L,5L,6L,4L,0L,7L,7L,3L,9L,9L,1L,4L,4L,8L,5L,5L,7L,3L,0L,5L,7L,4L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198238Inst : IEnumerable<long>
{
public static readonly long[] Value=A198238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198238.Bytes);
public long this[int i]=>Value[i];

public static A198238Inst Instance=new A198238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198239
{
public static readonly long[] Value={ 3L,6L,6L,2L,4L,0L,8L,1L,5L,6L,6L,0L,4L,6L,3L,7L,1L,8L,3L,8L,4L,1L,5L,8L,1L,8L,8L,6L,9L,7L,6L,4L,4L,4L,0L,5L,4L,7L,4L,3L,1L,6L,0L,8L,8L,4L,0L,0L,7L,0L,5L,9L,1L,1L,9L,3L,7L,7L,4L,4L,5L,1L,4L,1L,3L,6L,4L,9L,0L,2L,2L,0L,6L,8L,1L,8L,3L,5L,2L,1L,5L,9L,0L,0L,0L,7L,9L,7L,9L,3L,0L,3L,4L,1L,8L,4L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198239Inst : IEnumerable<long>
{
public static readonly long[] Value=A198239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198239.Bytes);
public long this[int i]=>Value[i];

public static A198239Inst Instance=new A198239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198240
{
public static readonly long[] Value={ 1L,4L,3L,0L,8L,3L,3L,4L,2L,0L,7L,1L,7L,7L,2L,8L,5L,4L,2L,5L,6L,6L,5L,4L,3L,9L,3L,3L,6L,3L,9L,1L,3L,8L,8L,5L,9L,9L,0L,2L,1L,8L,3L,5L,9L,2L,1L,4L,8L,4L,4L,4L,7L,5L,8L,6L,5L,1L,2L,9L,3L,6L,0L,4L,8L,3L,7L,1L,3L,3L,8L,0L,5L,4L,1L,2L,3L,2L,2L,6L,5L,7L,9L,2L,4L,5L,7L,1L,3L,4L,4L,7L,6L,3L,9L,6L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198240Inst : IEnumerable<long>
{
public static readonly long[] Value=A198240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198240.Bytes);
public long this[int i]=>Value[i];

public static A198240Inst Instance=new A198240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198241
{
public static readonly long[] Value={ 4L,8L,6L,0L,0L,4L,4L,3L,5L,9L,9L,2L,2L,9L,3L,0L,4L,0L,8L,1L,6L,1L,9L,8L,9L,8L,1L,5L,0L,3L,5L,7L,8L,5L,6L,4L,6L,9L,2L,1L,1L,0L,8L,7L,9L,7L,3L,0L,9L,4L,7L,7L,4L,2L,5L,5L,3L,7L,9L,8L,3L,9L,2L,2L,9L,1L,8L,0L,2L,6L,8L,1L,9L,8L,3L,7L,6L,9L,9L,0L,9L,0L,6L,2L,7L,7L,5L,3L,7L,1L,6L,2L,9L,0L,0L,4L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198241Inst : IEnumerable<long>
{
public static readonly long[] Value=A198241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198241.Bytes);
public long this[int i]=>Value[i];

public static A198241Inst Instance=new A198241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198242
{
public static readonly long[] Value={ 1L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,2L,3L,2L,1L,2L,4L,5L,5L,5L,5L,4L,1L,-3L,-5L,-4L,-2L,-1L,-3L,-9L,-15L,-16L,-14L,-15L,-21L,-29L,-33L,-26L,-7L,12L,14L,-3L,-21L,-22L,-7L,9L,16L,17L,20L,31L,52L,75L,84L,76L,72L,92L,124L,131L,91L,27L,-8L,18L,83L,132L,127L,81L,46L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198242Inst : IEnumerable<long>
{
public static readonly long[] Value=A198242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198242.Bytes);
public long this[int i]=>Value[i];

public static A198242Inst Instance=new A198242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198243
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,-1L,-2L,-2L,-1L,0L,0L,-1L,-2L,-2L,0L,4L,7L,6L,3L,2L,3L,4L,5L,6L,6L,6L,8L,10L,6L,-6L,-18L,-20L,-13L,-7L,-8L,-13L,-16L,-15L,-13L,-15L,-25L,-41L,-53L,-53L,-44L,-32L,-16L,5L,22L,25L,18L,13L,14L,19L,29L,41L,44L,38L,43L,72L,109L,130L,135L,146L,180L,232L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198243Inst : IEnumerable<long>
{
public static readonly long[] Value=A198243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198243.Bytes);
public long this[int i]=>Value[i];

public static A198243Inst Instance=new A198243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198244
{
public static readonly BigInteger[] Value={ 11L,10778947368421L,17513875027111L,610851724137931L,614910264406779661L,BigInteger.Parse("22390512687494871811"),BigInteger.Parse("22793803793211153712637"),BigInteger.Parse("79905927161140977116221"),BigInteger.Parse("184251916941751188170917"),BigInteger.Parse("319465039747605973452001"),BigInteger.Parse("1311848376806967295019263"),BigInteger.Parse("1918542715220370688851293") };
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
public class A198244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198244Inst Instance=new A198244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198245
{
public static readonly long[] Value={ 149L,241L,2946901L,16467631L,17613227L,327784727L,426369739L,1062232319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198245Inst : IEnumerable<long>
{
public static readonly long[] Value=A198245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198245.Bytes);
public long this[int i]=>Value[i];

public static A198245Inst Instance=new A198245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198246
{
public static readonly long[] Value={ 1L,5L,1675L,14520192L,1683040515731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198246Inst : IEnumerable<long>
{
public static readonly long[] Value=A198246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198246.Bytes);
public long this[int i]=>Value[i];

public static A198246Inst Instance=new A198246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198247
{
public static readonly long[] Value={ 1L,5L,40L,485L,6528L,90641L,1268648L,17794141L,249720000L,3505037833L,49198133832L,690571872597L,9693269289152L,136060470673025L,1909825721373608L,26807451423465421L,376285360845321600L,5281765543824353657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198247Inst : IEnumerable<long>
{
public static readonly long[] Value=A198247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198247.Bytes);
public long this[int i]=>Value[i];

public static A198247Inst Instance=new A198247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198248
{
public static readonly BigInteger[] Value={ 2L,40L,1675L,81440L,4059950L,203087097L,10164141586L,508740409496L,25464106707391L,1274565023173456L,63796351813851410L,3193226785065121249L,BigInteger.Parse("159831987739494226958"),BigInteger.Parse("8000141016276333546184"),BigInteger.Parse("400434589880788614683443") };
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
public class A198248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198248Inst Instance=new A198248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198249
{
public static readonly BigInteger[] Value={ 5L,485L,81440L,14520192L,2606019472L,468268681671L,84165911962889L,15129042589276259L,2719545932661264380L,BigInteger.Parse("488859618202335884730"),BigInteger.Parse("87876498667057316198136"),BigInteger.Parse("15796525069912515393284021") };
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
public class A198249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198249Inst Instance=new A198249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198250
{
public static readonly long[] Value={ 15L,6528L,4059950L,2606019472L,1683040515731L,1088857594220452L,704825868750085006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198250Inst : IEnumerable<long>
{
public static readonly long[] Value=A198250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198250.Bytes);
public long this[int i]=>Value[i];

public static A198250Inst Instance=new A198250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198251
{
public static readonly long[] Value={ 51L,90641L,203087097L,468268681671L,1088857594220452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198251Inst : IEnumerable<long>
{
public static readonly long[] Value=A198251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198251.Bytes);
public long this[int i]=>Value[i];

public static A198251Inst Instance=new A198251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198252
{
public static readonly long[] Value={ 187L,1268648L,10164141586L,84165911962889L,704825868750085006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198252Inst : IEnumerable<long>
{
public static readonly long[] Value=A198252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198252.Bytes);
public long this[int i]=>Value[i];

public static A198252Inst Instance=new A198252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198253
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,5L,40L,40L,5L,15L,485L,1675L,485L,15L,51L,6528L,81440L,81440L,6528L,51L,187L,90641L,4059950L,14520192L,4059950L,90641L,187L,715L,1268648L,203087097L,2606019472L,2606019472L,203087097L,1268648L,715L,2795L,17794141L,10164141586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198253Inst : IEnumerable<long>
{
public static readonly long[] Value=A198253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198253.Bytes);
public long this[int i]=>Value[i];

public static A198253Inst Instance=new A198253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198254
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198254Inst : IEnumerable<long>
{
public static readonly long[] Value=A198254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198254.Bytes);
public long this[int i]=>Value[i];

public static A198254Inst Instance=new A198254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198255
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,1L,0L,1L,0L,2L,0L,5L,0L,0L,0L,1L,0L,3L,1L,2L,0L,3L,0L,4L,1L,0L,1L,3L,0L,5L,0L,2L,0L,4L,0L,1L,2L,2L,0L,3L,0L,4L,2L,2L,1L,3L,0L,6L,1L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198255Inst : IEnumerable<long>
{
public static readonly long[] Value=A198255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198255.Bytes);
public long this[int i]=>Value[i];

public static A198255Inst Instance=new A198255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198256
{
public static readonly BigInteger[] Value={ 1L,5L,46L,485L,5626L,69062L,882540L,11614437L,156343330L,2142556130L,29791689148L,419260001030L,5960334608788L,85469709312860L,1234797737654296L,17955907741675749L,262607675818816050L,3860239468267647914L,BigInteger.Parse("57002176852356800700"),BigInteger.Parse("845159480056345448610") };
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
public class A198256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198256Inst Instance=new A198256Inst();

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