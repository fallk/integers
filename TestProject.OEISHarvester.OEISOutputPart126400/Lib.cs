using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A155705
{
public static readonly long[] Value={ 6L,9L,14L,12L,19L,26L,15L,24L,33L,42L,18L,29L,40L,51L,62L,21L,34L,47L,60L,73L,86L,24L,39L,54L,69L,84L,99L,114L,27L,44L,61L,78L,95L,112L,129L,146L,30L,49L,68L,87L,106L,125L,144L,163L,182L,33L,54L,75L,96L,117L,138L,159L,180L,201L,222L,36L,59L,82L,105L,128L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155705Inst : IEnumerable<long>
{
public static readonly long[] Value=A155705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155705.Bytes);
public long this[int i]=>Value[i];

public static A155705Inst Instance=new A155705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155706
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,5L,9L,9L,5L,9L,20L,24L,20L,9L,17L,45L,60L,60L,45L,17L,33L,102L,150L,160L,150L,102L,33L,65L,231L,378L,420L,420L,378L,231L,65L,129L,520L,952L,1120L,1120L,1120L,952L,520L,129L,257L,1161L,2376L,3024L,3024L,3024L,3024L,2376L,1161L,257L,513L,2570L,5850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155706Inst : IEnumerable<long>
{
public static readonly long[] Value=A155706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155706.Bytes);
public long this[int i]=>Value[i];

public static A155706Inst Instance=new A155706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155707
{
public static readonly long[] Value={ 144L,576L,1009L,1129L,1201L,1296L,1801L,1849L,2304L,2521L,2689L,2881L,3049L,3361L,3529L,3600L,3889L,4036L,4201L,4356L,4489L,4516L,4561L,4729L,4804L,5184L,5209L,5569L,5881L,5929L,6841L,7009L,7056L,7204L,7396L,7561L,7681L,8089L,8521L,8689L,8761L,8929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155707Inst : IEnumerable<long>
{
public static readonly long[] Value=A155707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155707.Bytes);
public long this[int i]=>Value[i];

public static A155707Inst Instance=new A155707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155708
{
public static readonly long[] Value={ 36L,129L,144L,201L,241L,324L,409L,441L,489L,516L,576L,601L,769L,804L,849L,900L,921L,964L,1009L,1129L,1161L,1201L,1249L,1296L,1321L,1489L,1521L,1569L,1609L,1636L,1641L,1764L,1801L,1809L,1849L,1929L,1956L,2064L,2089L,2161L,2169L,2281L,2304L,2361L,2404L,2521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155708Inst : IEnumerable<long>
{
public static readonly long[] Value=A155708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155708.Bytes);
public long this[int i]=>Value[i];

public static A155708Inst Instance=new A155708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155709
{
public static readonly long[] Value={ 22L,33L,73L,88L,97L,118L,121L,132L,150L,166L,177L,193L,198L,214L,225L,241L,249L,262L,292L,294L,297L,313L,321L,337L,352L,358L,388L,393L,409L,433L,438L,441L,454L,457L,472L,484L,502L,528L,537L,550L,577L,582L,600L,601L,649L,657L,664L,673L,681L,694L,708L,726L,753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155709Inst : IEnumerable<long>
{
public static readonly long[] Value=A155709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155709.Bytes);
public long this[int i]=>Value[i];

public static A155709Inst Instance=new A155709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155710
{
public static readonly long[] Value={ 21L,36L,49L,61L,84L,109L,129L,144L,181L,189L,196L,201L,229L,241L,244L,301L,309L,324L,336L,349L,381L,409L,421L,436L,441L,469L,489L,516L,525L,541L,549L,576L,601L,661L,669L,709L,721L,724L,756L,769L,784L,804L,829L,849L,889L,900L,916L,921L,964L,976L,981L,1009L,1021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155710Inst : IEnumerable<long>
{
public static readonly long[] Value=A155710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155710.Bytes);
public long this[int i]=>Value[i];

public static A155710Inst Instance=new A155710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155711
{
public static readonly long[] Value={ 11L,43L,44L,67L,72L,88L,99L,107L,113L,121L,137L,144L,163L,172L,176L,179L,193L,211L,233L,268L,275L,281L,288L,331L,337L,344L,347L,352L,379L,387L,396L,401L,428L,443L,449L,452L,457L,473L,484L,491L,499L,536L,539L,547L,548L,569L,571L,576L,603L,617L,641L,648L,652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155711Inst : IEnumerable<long>
{
public static readonly long[] Value=A155711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155711.Bytes);
public long this[int i]=>Value[i];

public static A155711Inst Instance=new A155711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155712
{
public static readonly long[] Value={ 7L,28L,31L,49L,63L,73L,79L,97L,100L,103L,112L,124L,127L,151L,175L,193L,196L,199L,217L,223L,241L,252L,271L,279L,292L,313L,316L,337L,343L,367L,388L,400L,409L,412L,433L,439L,441L,448L,457L,463L,484L,487L,496L,508L,511L,553L,567L,577L,601L,604L,607L,631L,657L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155712Inst : IEnumerable<long>
{
public static readonly long[] Value=A155712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155712.Bytes);
public long this[int i]=>Value[i];

public static A155712Inst Instance=new A155712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155713
{
public static readonly long[] Value={ 49L,70L,105L,145L,150L,166L,196L,214L,225L,241L,249L,280L,294L,321L,406L,409L,420L,441L,454L,505L,580L,600L,601L,609L,630L,664L,681L,694L,721L,726L,745L,769L,784L,841L,856L,870L,886L,889L,900L,934L,945L,964L,996L,1009L,1030L,1041L,1089L,1120L,1126L,1129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155713Inst : IEnumerable<long>
{
public static readonly long[] Value=A155713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155713.Bytes);
public long this[int i]=>Value[i];

public static A155713Inst Instance=new A155713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155714
{
public static readonly long[] Value={ 3L,12L,36L,144L,144L,4356L,4356L,4356L,7056L,17424L,176400L,2547216L,2547216L,6290064L,6780816L,6780816L,6780816L,6780816L,93315600L,93315600L,271986064L,271986064L,271986064L,271986064L,271986064L,308213136L,308213136L,308213136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155714Inst : IEnumerable<long>
{
public static readonly long[] Value=A155714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155714.Bytes);
public long this[int i]=>Value[i];

public static A155714Inst Instance=new A155714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155715
{
public static readonly long[] Value={ 2L,17L,73L,73L,241L,241L,1009L,1009L,1009L,1009L,7561L,7561L,21961L,32356L,32356L,32356L,44641L,44641L,349924L,349924L,349924L,349924L,1399696L,1399696L,1399696L,3027249L,3027249L,3027249L,4349601L,4349601L,18567396L,18567396L,18567396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155715Inst : IEnumerable<long>
{
public static readonly long[] Value=A155715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155715.Bytes);
public long this[int i]=>Value[i];

public static A155715Inst Instance=new A155715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155716
{
public static readonly long[] Value={ 7L,10L,15L,22L,25L,28L,31L,33L,40L,42L,49L,55L,58L,60L,63L,70L,73L,79L,87L,88L,90L,97L,100L,103L,105L,106L,112L,118L,121L,124L,127L,132L,135L,145L,150L,151L,154L,159L,160L,166L,168L,175L,177L,186L,193L,196L,198L,199L,202L,214L,217L,220L,223L,225L,231L,232L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155716Inst : IEnumerable<long>
{
public static readonly long[] Value=A155716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155716.Bytes);
public long this[int i]=>Value[i];

public static A155716Inst Instance=new A155716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155717
{
public static readonly long[] Value={ 8L,11L,16L,23L,29L,32L,37L,43L,44L,53L,56L,64L,67L,71L,72L,77L,79L,88L,92L,99L,107L,109L,112L,113L,116L,121L,127L,128L,137L,144L,148L,149L,151L,161L,163L,172L,176L,179L,184L,191L,193L,197L,200L,203L,207L,211L,212L,224L,232L,233L,239L,253L,256L,259L,261L,263L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155717Inst : IEnumerable<long>
{
public static readonly long[] Value=A155717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155717.Bytes);
public long this[int i]=>Value[i];

public static A155717Inst Instance=new A155717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155718
{
public static readonly long[] Value={ 2L,-1L,-1L,9L,-12L,9L,-47L,32L,32L,-47L,385L,-420L,280L,-420L,385L,-3839L,4354L,-1460L,-1460L,4354L,-3839L,46081L,-56490L,26684L,-11760L,26684L,-56490L,46081L,-645119L,836296L,-418936L,92624L,92624L,-418936L,836296L,-645119L,10321921L,-14026824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155718Inst : IEnumerable<long>
{
public static readonly long[] Value=A155718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155718.Bytes);
public long this[int i]=>Value[i];

public static A155718Inst Instance=new A155718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155719
{
public static readonly long[] Value={ 2L,0L,0L,4L,-8L,4L,-14L,14L,14L,-14L,106L,-192L,172L,-192L,106L,-944L,1664L,-720L,-720L,1664L,-944L,10396L,-19560L,12644L,-6960L,12644L,-19560L,10396L,-135134L,264158L,-176358L,47334L,47334L,-176358L,264158L,-135134L,2027026L,-4098304L,2925880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155719Inst : IEnumerable<long>
{
public static readonly long[] Value=A155719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155719.Bytes);
public long this[int i]=>Value[i];

public static A155719Inst Instance=new A155719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155720
{
public static readonly long[] Value={ 2L,4L,4L,21L,8L,21L,211L,35L,35L,211L,3025L,342L,84L,342L,3025L,55441L,5047L,560L,560L,5047L,55441L,1235521L,95048L,7992L,1440L,7992L,95048L,1235521L,32432401L,2162169L,154530L,12870L,12870L,154530L,2162169L,32432401L,980179201L,57657610L,3603710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155720Inst : IEnumerable<long>
{
public static readonly long[] Value=A155720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155720.Bytes);
public long this[int i]=>Value[i];

public static A155720Inst Instance=new A155720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155721
{
public static readonly long[] Value={ 4L,20L,84L,340L,1364L,5460L,21844L,87380L,349524L,1398100L,5592404L,22369620L,89478484L,357913940L,1431655764L,5726623060L,22906492244L,91625968980L,366503875924L,1466015503700L,5864062014804L,23456248059220L,93824992236884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155721Inst : IEnumerable<long>
{
public static readonly long[] Value=A155721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155721.Bytes);
public long this[int i]=>Value[i];

public static A155721Inst Instance=new A155721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155722
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,11L,14L,16L,17L,19L,22L,25L,26L,29L,31L,32L,35L,37L,40L,44L,46L,47L,49L,50L,52L,59L,61L,64L,65L,70L,71L,74L,77L,79L,82L,85L,86L,91L,92L,94L,95L,101L,107L,109L,110L,112L,115L,116L,121L,124L,127L,130L,131L,134L,136L,137L,142L,149L,151L,152L,154L,161L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155722Inst : IEnumerable<long>
{
public static readonly long[] Value=A155722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155722.Bytes);
public long this[int i]=>Value[i];

public static A155722Inst Instance=new A155722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155723
{
public static readonly long[] Value={ 0L,3L,6L,8L,9L,12L,13L,15L,18L,20L,21L,23L,24L,27L,28L,30L,33L,34L,36L,38L,39L,41L,42L,43L,45L,48L,51L,53L,54L,55L,56L,57L,58L,60L,62L,63L,66L,67L,68L,69L,72L,73L,75L,76L,78L,80L,81L,83L,84L,87L,88L,89L,90L,93L,96L,97L,98L,99L,100L,102L,103L,104L,105L,106L,108L,111L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155723Inst : IEnumerable<long>
{
public static readonly long[] Value=A155723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155723.Bytes);
public long this[int i]=>Value[i];

public static A155723Inst Instance=new A155723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155724
{
public static readonly long[] Value={ 0L,3L,8L,6L,13L,20L,9L,18L,27L,36L,12L,23L,34L,45L,56L,15L,28L,41L,54L,67L,80L,18L,33L,48L,63L,78L,93L,108L,21L,38L,55L,72L,89L,106L,123L,140L,24L,43L,62L,81L,100L,119L,138L,157L,176L,27L,48L,69L,90L,111L,132L,153L,174L,195L,216L,30L,53L,76L,99L,122L,145L,168L,191L,214L,237L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155724Inst : IEnumerable<long>
{
public static readonly long[] Value=A155724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155724.Bytes);
public long this[int i]=>Value[i];

public static A155724Inst Instance=new A155724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155725
{
public static readonly long[] Value={ 2L,4L,4L,21L,18L,21L,211L,125L,125L,211L,3025L,1680L,670L,1680L,3025L,55441L,31639L,7960L,7960L,31639L,55441L,1235521L,725655L,178199L,45570L,178199L,725655L,1235521L,32432401L,19471584L,4988326L,765289L,765289L,4988326L,19471584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155725Inst : IEnumerable<long>
{
public static readonly long[] Value=A155725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155725.Bytes);
public long this[int i]=>Value[i];

public static A155725Inst Instance=new A155725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155726
{
public static readonly long[] Value={ 0L,1L,2L,-1L,1L,3L,0L,-1L,1L,4L,0L,0L,-1L,1L,5L,0L,0L,0L,-1L,1L,6L,0L,0L,0L,0L,-1L,1L,7L,0L,0L,0L,0L,0L,-1L,1L,8L,0L,0L,0L,0L,0L,0L,-1L,1L,9L,0L,0L,0L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155726Inst : IEnumerable<long>
{
public static readonly long[] Value=A155726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155726.Bytes);
public long this[int i]=>Value[i];

public static A155726Inst Instance=new A155726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155727
{
public static readonly long[] Value={ 0L,1L,3L,-1L,1L,5L,0L,-1L,1L,7L,0L,0L,-1L,1L,9L,0L,0L,0L,-1L,1L,11L,0L,0L,0L,0L,-1L,1L,13L,0L,0L,0L,0L,0L,-1L,1L,15L,0L,0L,0L,0L,0L,0L,-1L,1L,17L,0L,0L,0L,0L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155727Inst : IEnumerable<long>
{
public static readonly long[] Value=A155727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155727.Bytes);
public long this[int i]=>Value[i];

public static A155727Inst Instance=new A155727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155728
{
public static readonly BigInteger[] Value={ 1L,2L,14L,121L,1383L,19108L,309708L,5751027L,120357325L,2803145494L,71926499002L,2016492639229L,61338391284387L,2012321446421976L,70833707268623448L,2663117961930477847L,BigInteger.Parse("106515148705020928105"),BigInteger.Parse("4516063573152118802282"),BigInteger.Parse("202328834841437929100838") };
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
public class A155728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155728Inst Instance=new A155728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155729
{
public static readonly long[] Value={ 1L,2L,1L,14L,2L,13L,121L,14L,6L,19L,1383L,121L,42L,38L,160L,19108L,1383L,363L,266L,320L,1744L,19108L,1383L,363L,266L,320L,1744L,309708L,19108L,4149L,2299L,2240L,3488L,23184L,2751027L,309708L,57324L,26277L,19360L,24416L,46368L,364176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155729Inst : IEnumerable<long>
{
public static readonly long[] Value=A155729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155729.Bytes);
public long this[int i]=>Value[i];

public static A155729Inst Instance=new A155729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155730
{
public static readonly long[] Value={ 3L,4L,8L,10L,11L,15L,28L,35L,43L,45L,46L,50L,56L,57L,61L,64L,70L,72L,78L,81L,91L,107L,109L,119L,126L,128L,135L,141L,147L,149L,158L,170L,179L,181L,187L,193L,208L,210L,220L,221L,223L,225L,236L,245L,254L,257L,263L,264L,268L,275L,276L,280L,286L,288L,297L,298L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155730Inst : IEnumerable<long>
{
public static readonly long[] Value=A155730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155730.Bytes);
public long this[int i]=>Value[i];

public static A155730Inst Instance=new A155730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155731
{
public static readonly BigInteger[] Value={ 1L,3L,30L,810004L,BigInteger.Parse("348687049529230979905036801029") };
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
public class A155731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155731Inst Instance=new A155731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155732
{
public static readonly long[] Value={ 1L,5L,7L,9L,13L,19L,31L,33L,35L,37L,49L,57L,61L,71L,75L,77L,83L,85L,101L,103L,105L,107L,117L,127L,129L,141L,143L,147L,159L,161L,163L,169L,181L,187L,205L,209L,215L,227L,229L,231L,237L,255L,271L,281L,295L,299L,303L,313L,315L,323L,339L,343L,345L,357L,363L,381L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155732Inst : IEnumerable<long>
{
public static readonly long[] Value=A155732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155732.Bytes);
public long this[int i]=>Value[i];

public static A155732Inst Instance=new A155732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155733
{
public static readonly BigInteger[] Value={ 1L,2L,10L,10003L,BigInteger.Parse("100150090027004050247") };
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
public class A155733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155733.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155733Inst Instance=new A155733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155734
{
public static readonly long[] Value={ 3L,1L,3L,9L,27L,81L,243L,729L,2187L,6561L,19683L,59049L,177147L,531441L,1594323L,4782969L,14348907L,43046721L,129140163L,387420489L,1162261467L,3486784401L,10460353203L,31381059609L,94143178827L,282429536481L,847288609443L,2541865828329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155734Inst : IEnumerable<long>
{
public static readonly long[] Value=A155734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155734.Bytes);
public long this[int i]=>Value[i];

public static A155734Inst Instance=new A155734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155735
{
public static readonly long[] Value={ 1L,5L,8L,8L,4L,8L,1L,5L,9L,2L,9L,7L,5L,3L,6L,5L,9L,3L,8L,3L,7L,4L,9L,3L,3L,9L,4L,5L,6L,5L,6L,9L,1L,9L,8L,2L,8L,4L,5L,0L,5L,9L,7L,0L,5L,6L,0L,5L,9L,6L,3L,1L,2L,5L,5L,6L,6L,5L,8L,9L,9L,5L,9L,2L,5L,8L,7L,6L,9L,7L,0L,8L,4L,6L,0L,1L,0L,2L,9L,4L,3L,5L,5L,5L,2L,5L,4L,7L,8L,2L,5L,8L,4L,6L,8L,9L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155735Inst : IEnumerable<long>
{
public static readonly long[] Value=A155735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155735.Bytes);
public long this[int i]=>Value[i];

public static A155735Inst Instance=new A155735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155736
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,10L,12L,13L,14L,15L,19L,22L,23L,24L,25L,27L,28L,30L,32L,33L,34L,35L,38L,43L,47L,48L,50L,57L,60L,63L,65L,67L,69L,70L,72L,74L,77L,79L,80L,82L,87L,88L,90L,92L,93L,94L,98L,103L,109L,110L,115L,118L,120L,122L,123L,124L,129L,132L,134L,144L,145L,147L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155736Inst : IEnumerable<long>
{
public static readonly long[] Value=A155736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155736.Bytes);
public long this[int i]=>Value[i];

public static A155736Inst Instance=new A155736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155737
{
public static readonly long[] Value={ 5L,19L,41L,71L,109L,271L,419L,599L,701L,811L,929L,1481L,1979L,2161L,2351L,2549L,2969L,3191L,3659L,4159L,4421L,4691L,4969L,5851L,7481L,8929L,9311L,10099L,13109L,14519L,16001L,17029L,18089L,19181L,19739L,20879L,22051L,23869L,25121L,25759L,27059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155737Inst : IEnumerable<long>
{
public static readonly long[] Value=A155737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155737.Bytes);
public long this[int i]=>Value[i];

public static A155737Inst Instance=new A155737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155738
{
public static readonly long[] Value={ 2L,3L,5L,13L,19L,23L,43L,47L,67L,79L,103L,109L,149L,157L,179L,193L,239L,353L,373L,397L,419L,487L,499L,503L,523L,547L,563L,569L,587L,619L,677L,683L,787L,797L,839L,853L,863L,929L,1013L,1093L,1193L,1229L,1289L,1303L,1319L,1423L,1433L,1499L,1553L,1619L,1669L,1733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155738Inst : IEnumerable<long>
{
public static readonly long[] Value=A155738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155738.Bytes);
public long this[int i]=>Value[i];

public static A155738Inst Instance=new A155738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155739
{
public static readonly long[] Value={ 2L,8L,8L,6L,0L,7L,8L,3L,2L,4L,5L,0L,7L,6L,6L,4L,3L,0L,3L,0L,3L,2L,5L,6L,0L,4L,5L,0L,4L,1L,2L,0L,1L,2L,1L,5L,5L,2L,1L,0L,7L,9L,6L,6L,7L,9L,6L,9L,9L,6L,1L,7L,9L,9L,4L,0L,2L,8L,8L,3L,6L,1L,7L,4L,4L,2L,4L,3L,3L,8L,6L,3L,3L,8L,8L,8L,3L,2L,3L,3L,5L,4L,6L,8L,4L,7L,3L,5L,3L,1L,6L,4L,5L,8L,7L,3L,3L,7L,4L,7L,5L,7L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155739Inst : IEnumerable<long>
{
public static readonly long[] Value=A155739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155739.Bytes);
public long this[int i]=>Value[i];

public static A155739Inst Instance=new A155739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155740
{
public static readonly long[] Value={ 21L,1725L,1927L,2333L,3751L,79105L,83111L,131169L,167213L,173219L,191243L,193245L,197249L,227287L,229289L,251315L,269335L,307381L,317393L,367453L,379469L,383473L,397489L,419515L,421517L,431529L,433531L,439537L,449549L,463565L,499609L,521635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155740Inst : IEnumerable<long>
{
public static readonly long[] Value=A155740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155740.Bytes);
public long this[int i]=>Value[i];

public static A155740Inst Instance=new A155740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155741
{
public static readonly long[] Value={ 1L,4L,8L,6L,4L,7L,7L,2L,0L,6L,2L,1L,2L,4L,3L,2L,4L,1L,8L,7L,3L,3L,1L,2L,1L,0L,1L,5L,5L,7L,5L,2L,6L,4L,3L,1L,9L,5L,6L,7L,7L,4L,3L,8L,4L,1L,8L,9L,3L,9L,2L,2L,6L,9L,0L,4L,3L,7L,6L,0L,0L,5L,4L,8L,5L,7L,5L,4L,4L,3L,5L,3L,9L,9L,0L,6L,6L,7L,2L,7L,8L,4L,2L,3L,6L,4L,9L,7L,0L,9L,9L,7L,6L,2L,3L,0L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155741Inst : IEnumerable<long>
{
public static readonly long[] Value=A155741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155741.Bytes);
public long this[int i]=>Value[i];

public static A155741Inst Instance=new A155741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155742
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,6L,6L,0L,0L,36L,121L,36L,0L,0L,240L,1750L,1750L,240L,0L,0L,1800L,23290L,50625L,23290L,1800L,0L,0L,15120L,308700L,1193640L,1193640L,308700L,15120L,0L,0L,141120L,4207896L,25738720L,45819361L,25738720L,4207896L,141120L,0L,0L,1451520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155742Inst : IEnumerable<long>
{
public static readonly long[] Value=A155742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155742.Bytes);
public long this[int i]=>Value[i];

public static A155742Inst Instance=new A155742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155743
{
public static readonly long[] Value={ 1L,4L,0L,6L,7L,9L,4L,0L,4L,6L,1L,0L,7L,7L,9L,7L,7L,5L,9L,0L,7L,4L,2L,5L,3L,7L,6L,4L,5L,3L,7L,3L,4L,4L,8L,8L,8L,9L,2L,1L,2L,7L,3L,5L,8L,2L,6L,6L,6L,4L,1L,2L,3L,9L,4L,0L,5L,3L,9L,7L,3L,9L,7L,7L,0L,0L,5L,2L,4L,6L,9L,1L,7L,6L,3L,6L,1L,6L,3L,5L,8L,4L,1L,9L,3L,2L,1L,6L,8L,5L,9L,3L,5L,6L,7L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155743Inst : IEnumerable<long>
{
public static readonly long[] Value=A155743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155743.Bytes);
public long this[int i]=>Value[i];

public static A155743Inst Instance=new A155743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155744
{
public static readonly long[] Value={ 3L,1L,1L,1L,3L,1L,1L,11L,11L,1L,1L,48L,143L,48L,1L,1L,274L,1835L,1835L,274L,1L,1L,1935L,23649L,51075L,23649L,1935L,1L,1L,15861L,310639L,1195999L,1195999L,310639L,15861L,1L,1L,146188L,4221286L,25753812L,45832899L,25753812L,4221286L,146188L,1L,1L,1491876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155744Inst : IEnumerable<long>
{
public static readonly long[] Value=A155744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155744.Bytes);
public long this[int i]=>Value[i];

public static A155744Inst Instance=new A155744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155745
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,21L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155745Inst : IEnumerable<long>
{
public static readonly long[] Value=A155745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155745.Bytes);
public long this[int i]=>Value[i];

public static A155745Inst Instance=new A155745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155746
{
public static readonly long[] Value={ 1L,3L,4L,2L,4L,2L,2L,6L,8L,0L,8L,2L,2L,2L,0L,6L,2L,3L,5L,9L,6L,3L,9L,3L,8L,8L,6L,5L,9L,6L,7L,5L,1L,7L,2L,6L,8L,4L,7L,4L,8L,9L,2L,0L,7L,1L,9L,2L,8L,5L,6L,1L,6L,3L,5L,9L,0L,6L,9L,6L,6L,4L,7L,9L,8L,0L,6L,8L,6L,1L,2L,2L,1L,5L,0L,7L,6L,7L,3L,8L,5L,7L,0L,5L,8L,2L,2L,2L,0L,3L,8L,5L,0L,3L,9L,1L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155746Inst : IEnumerable<long>
{
public static readonly long[] Value=A155746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155746.Bytes);
public long this[int i]=>Value[i];

public static A155746Inst Instance=new A155746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155747
{
public static readonly long[] Value={ 2L,4L,12L,60L,60L,120L,360L,3960L,27720L,27720L,27720L,27720L,27720L,637560L,8288280L,240360120L,240360120L,240360120L,240360120L,240360120L,240360120L,9854764920L,9854764920L,19709529840L,98547649200L,1675310036400L,88791431929200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155747Inst : IEnumerable<long>
{
public static readonly long[] Value=A155747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155747.Bytes);
public long this[int i]=>Value[i];

public static A155747Inst Instance=new A155747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155748
{
public static readonly long[] Value={ 1L,2L,8L,9L,0L,6L,4L,8L,2L,6L,3L,1L,7L,8L,8L,7L,8L,5L,9L,2L,6L,6L,2L,1L,1L,0L,0L,7L,7L,0L,0L,2L,6L,3L,5L,6L,6L,1L,9L,1L,2L,9L,4L,6L,1L,5L,9L,8L,5L,6L,9L,6L,0L,0L,3L,6L,2L,6L,3L,4L,1L,5L,6L,7L,7L,9L,8L,5L,3L,1L,5L,8L,3L,5L,5L,6L,9L,1L,5L,7L,7L,1L,9L,3L,2L,9L,7L,7L,0L,9L,1L,5L,3L,9L,1L,9L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155748Inst : IEnumerable<long>
{
public static readonly long[] Value=A155748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155748.Bytes);
public long this[int i]=>Value[i];

public static A155748Inst Instance=new A155748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155749
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,2L,6L,9L,9L,1L,6L,3L,2L,4L,7L,3L,5L,9L,4L,0L,4L,9L,1L,5L,7L,0L,8L,7L,2L,8L,5L,1L,4L,0L,5L,1L,5L,6L,8L,6L,6L,0L,2L,1L,0L,9L,4L,6L,1L,7L,6L,6L,9L,4L,5L,9L,8L,0L,0L,0L,2L,4L,3L,8L,1L,6L,4L,6L,4L,2L,8L,0L,8L,8L,9L,6L,1L,0L,0L,8L,8L,6L,4L,7L,4L,4L,0L,9L,6L,7L,4L,1L,2L,5L,0L,5L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155749Inst : IEnumerable<long>
{
public static readonly long[] Value=A155749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155749.Bytes);
public long this[int i]=>Value[i];

public static A155749Inst Instance=new A155749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155750
{
public static readonly long[] Value={ 4L,6L,6L,10L,8L,6L,10L,8L,10L,8L,10L,12L,6L,6L,18L,8L,12L,12L,10L,8L,12L,6L,24L,6L,10L,12L,12L,8L,10L,12L,18L,6L,20L,12L,10L,14L,10L,14L,12L,12L,12L,10L,14L,6L,16L,12L,12L,18L,20L,16L,12L,8L,16L,8L,12L,6L,22L,6L,12L,14L,10L,18L,18L,14L,10L,14L,12L,18L,22L,12L,6L,12L,18L,6L,18L,6L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155750Inst : IEnumerable<long>
{
public static readonly long[] Value=A155750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155750.Bytes);
public long this[int i]=>Value[i];

public static A155750Inst Instance=new A155750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155751
{
public static readonly long[] Value={ 1L,-7L,-2L,-3L,4L,6L,-8L,5L,-1L,7L,2L,3L,-4L,-6L,8L,-5L,1L,-7L,-2L,-3L,4L,6L,-8L,5L,-1L,7L,2L,3L,-4L,-6L,8L,-5L,1L,-7L,-2L,-3L,4L,6L,-8L,5L,-1L,7L,2L,3L,-4L,-6L,8L,-5L,1L,-7L,-2L,-3L,4L,6L,-8L,5L,-1L,7L,2L,3L,-4L,-6L,8L,-5L,1L,-7L,-2L,-3L,4L,6L,-8L,5L,-1L,7L,2L,3L,-4L,-6L,8L,-5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155751Inst : IEnumerable<long>
{
public static readonly long[] Value=A155751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155751.Bytes);
public long this[int i]=>Value[i];

public static A155751Inst Instance=new A155751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155752
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,16L,19L,25L,27L,32L,34L,40L,42L,44L,48L,51L,56L,59L,63L,68L,80L,82L,88L,97L,103L,108L,112L,115L,119L,139L,141L,143L,147L,151L,170L,172L,175L,177L,181L,189L,200L,205L,208L,211L,214L,224L,229L,233L,235L,252L,255L,261L,264L,267L,276L,285L,287L,293L,295L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155752Inst : IEnumerable<long>
{
public static readonly long[] Value=A155752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155752.Bytes);
public long this[int i]=>Value[i];

public static A155752Inst Instance=new A155752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155753
{
public static readonly long[] Value={ 3L,5L,11L,23L,43L,73L,115L,171L,243L,333L,443L,575L,731L,913L,1123L,1363L,1635L,1941L,2283L,2663L,3083L,3545L,4051L,4603L,5203L,5853L,6555L,7311L,8123L,8993L,9923L,10915L,11971L,13093L,14283L,15543L,16875L,18281L,19763L,21323L,22963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155753Inst : IEnumerable<long>
{
public static readonly long[] Value=A155753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155753.Bytes);
public long this[int i]=>Value[i];

public static A155753Inst Instance=new A155753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155754
{
public static readonly long[] Value={ 1L,-9L,5L,-7L,6L,3L,-8L,-4L,-2L,-1L,9L,-5L,7L,-6L,-3L,8L,4L,2L,1L,-9L,5L,-7L,6L,3L,-8L,-4L,-2L,-1L,9L,-5L,7L,-6L,-3L,8L,4L,2L,1L,-9L,5L,-7L,6L,3L,-8L,-4L,-2L,-1L,9L,-5L,7L,-6L,-3L,8L,4L,2L,1L,-9L,5L,-7L,6L,3L,-8L,-4L,-2L,-1L,9L,-5L,7L,-6L,-3L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155754Inst : IEnumerable<long>
{
public static readonly long[] Value=A155754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155754.Bytes);
public long this[int i]=>Value[i];

public static A155754Inst Instance=new A155754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155755
{
public static readonly long[] Value={ 2L,3L,3L,7L,10L,7L,25L,35L,35L,25L,121L,168L,142L,168L,121L,721L,1064L,735L,735L,1064L,721L,5041L,8055L,5399L,3330L,5399L,8055L,5041L,40321L,69299L,49371L,22449L,22449L,49371L,69299L,40321L,362881L,663740L,509830L,223300L,109298L,223300L,509830L,663740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155755Inst : IEnumerable<long>
{
public static readonly long[] Value=A155755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155755.Bytes);
public long this[int i]=>Value[i];

public static A155755Inst Instance=new A155755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155756
{
public static readonly long[] Value={ 1L,2L,1L,9L,33L,17L,1L,64L,610L,1180L,595L,70L,1L,625L,11315L,48135L,67245L,33309L,5463L,227L,1L,7776L,228531L,1708496L,4680256L,5339376L,2610776L,522256L,36996L,656L,1L,117649L,5104701L,59221547L,268424247L,551826072L,547629432L,265213752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155756Inst : IEnumerable<long>
{
public static readonly long[] Value=A155756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155756.Bytes);
public long this[int i]=>Value[i];

public static A155756Inst Instance=new A155756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155757
{
public static readonly long[] Value={ 5L,7L,13L,25L,45L,75L,117L,173L,245L,335L,445L,577L,733L,915L,1125L,1365L,1637L,1943L,2285L,2665L,3085L,3547L,4053L,4605L,5205L,5855L,6557L,7313L,8125L,8995L,9925L,10917L,11973L,13095L,14285L,15545L,16877L,18283L,19765L,21325L,22965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155757Inst : IEnumerable<long>
{
public static readonly long[] Value=A155757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155757.Bytes);
public long this[int i]=>Value[i];

public static A155757Inst Instance=new A155757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155758
{
public static readonly long[] Value={ 2L,3L,3L,10L,50L,50L,10L,65L,680L,1775L,1775L,680L,65L,626L,11542L,53598L,100554L,100554L,53598L,11542L,626L,7777L,229187L,1745492L,5202512L,7950152L,7950152L,5202512L,1745492L,229187L,7777L,117650L,5106474L,59432614L,274397694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155758Inst : IEnumerable<long>
{
public static readonly long[] Value=A155758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155758.Bytes);
public long this[int i]=>Value[i];

public static A155758Inst Instance=new A155758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155759
{
public static readonly long[] Value={ 1L,2L,0L,5L,1L,0L,8L,5L,7L,0L,4L,1L,5L,3L,7L,8L,3L,7L,1L,6L,5L,9L,4L,3L,6L,0L,9L,2L,0L,6L,4L,1L,9L,8L,0L,6L,8L,5L,1L,2L,7L,4L,1L,6L,5L,1L,8L,8L,9L,7L,1L,1L,8L,5L,4L,8L,0L,7L,7L,3L,2L,0L,5L,7L,5L,0L,7L,4L,9L,2L,5L,6L,5L,1L,1L,2L,8L,5L,2L,0L,1L,5L,5L,5L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155759Inst : IEnumerable<long>
{
public static readonly long[] Value=A155759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155759.Bytes);
public long this[int i]=>Value[i];

public static A155759Inst Instance=new A155759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155760
{
public static readonly long[] Value={ 7L,11L,13L,23L,29L,37L,41L,43L,53L,67L,71L,79L,97L,107L,137L,151L,163L,167L,181L,197L,211L,233L,251L,277L,307L,337L,349L,359L,379L,389L,401L,419L,431L,449L,461L,541L,547L,557L,571L,587L,601L,613L,617L,631L,709L,727L,797L,823L,827L,877L,881L,907L,911L,937L,953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155760Inst : IEnumerable<long>
{
public static readonly long[] Value=A155760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155760.Bytes);
public long this[int i]=>Value[i];

public static A155760Inst Instance=new A155760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155761
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,4L,0L,1L,8L,0L,6L,0L,1L,0L,20L,0L,8L,0L,1L,40L,0L,36L,0L,10L,0L,1L,0L,112L,0L,56L,0L,12L,0L,1L,224L,0L,224L,0L,80L,0L,14L,0L,1L,0L,672L,0L,384L,0L,108L,0L,16L,0L,1L,1344L,0L,1440L,0L,600L,0L,140L,0L,18L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155761Inst : IEnumerable<long>
{
public static readonly long[] Value=A155761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155761.Bytes);
public long this[int i]=>Value[i];

public static A155761Inst Instance=new A155761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155762
{
public static readonly long[] Value={ 2L,5L,149L,401L,509L,773L,809L,1021L,1103L,1289L,1301L,1451L,1697L,1709L,1747L,1877L,1889L,2087L,2389L,2521L,2663L,3373L,3511L,3631L,3733L,3779L,3821L,3919L,3947L,3989L,4003L,4073L,4241L,4289L,4339L,4637L,4643L,4801L,4931L,5039L,5113L,5387L,5417L,5477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155762Inst : IEnumerable<long>
{
public static readonly long[] Value=A155762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155762.Bytes);
public long this[int i]=>Value[i];

public static A155762Inst Instance=new A155762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155763
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,15L,17L,19L,22L,24L,31L,33L,34L,35L,37L,39L,41L,52L,55L,57L,69L,70L,72L,73L,75L,77L,88L,91L,92L,104L,203L,204L,205L,207L,209L,219L,232L,237L,247L,249L,278L,348L,350L,355L,364L,365L,376L,391L,405L,483L,486L,487L,619L,633L,644L,749L,1475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155763Inst : IEnumerable<long>
{
public static readonly long[] Value=A155763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155763.Bytes);
public long this[int i]=>Value[i];

public static A155763Inst Instance=new A155763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155764
{
public static readonly long[] Value={ 0L,1L,3L,9L,15L,18L,21L,27L,33L,39L,42L,45L,48L,75L,87L,93L,117L,120L,135L,138L,168L,183L,210L,228L,300L,333L,369L,393L,453L,525L,621L,720L,810L,846L,1086L,1281L,1305L,1515L,1590L,1617L,1722L,1794L,1833L,1851L,2010L,2064L,2085L,2112L,2217L,2352L,2754L,2784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155764Inst : IEnumerable<long>
{
public static readonly long[] Value=A155764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155764.Bytes);
public long this[int i]=>Value[i];

public static A155764Inst Instance=new A155764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155765
{
public static readonly long[] Value={ 2L,4L,8L,22L,46L,121L,128L,136L,146L,238L,265L,286L,341L,344L,526L,904L,1114L,1691L,1736L,1751L,1781L,2476L,3097L,3551L,5131L,8504L,10342L,18526L,22564L,24776L,40072L,68707L,125903L,174913L,181267L,371428L,827576L,936118L,1054141L,1159864L,1353559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155765Inst : IEnumerable<long>
{
public static readonly long[] Value=A155765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155765.Bytes);
public long this[int i]=>Value[i];

public static A155765Inst Instance=new A155765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155766
{
public static readonly long[] Value={ 2L,3L,7L,5L,23L,19L,19L,47L,43L,13L,107L,211L,37L,101L,73L,31L,191L,199L,103L,239L,271L,107L,569L,313L,179L,281L,397L,109L,491L,463L,191L,857L,919L,113L,503L,283L,491L,1619L,523L,199L,659L,691L,223L,821L,1321L,241L,1307L,1627L,293L,1373L,1621L,751L,2399L,823L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155766Inst : IEnumerable<long>
{
public static readonly long[] Value=A155766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155766.Bytes);
public long this[int i]=>Value[i];

public static A155766Inst Instance=new A155766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155767
{
public static readonly long[] Value={ 2L,5L,11L,11L,31L,29L,31L,61L,59L,31L,127L,233L,61L,127L,101L,61L,223L,233L,139L,277L,311L,149L,613L,359L,227L,331L,449L,163L,547L,521L,251L,919L,983L,179L,571L,353L,563L,1693L,599L,277L,739L,773L,307L,907L,1409L,331L,1399L,1721L,389L,1471L,1721L,853L,2503L,929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155767Inst : IEnumerable<long>
{
public static readonly long[] Value=A155767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155767.Bytes);
public long this[int i]=>Value[i];

public static A155767Inst Instance=new A155767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155768
{
public static readonly long[] Value={ 1L,2L,3L,4L,11L,13L,14L,16L,18L,20L,21L,23L,25L,82L,83L,98L,100L,115L,116L,117L,119L,132L,133L,135L,142L,147L,150L,160L,162L,164L,166L,717L,835L,843L,933L,956L,968L,970L,1055L,1062L,1066L,1076L,1088L,1090L,1092L,1093L,1166L,1167L,1179L,1190L,1191L,1199L,1202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155768Inst : IEnumerable<long>
{
public static readonly long[] Value=A155768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155768.Bytes);
public long this[int i]=>Value[i];

public static A155768Inst Instance=new A155768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155769
{
public static readonly long[] Value={ -41L,-37L,-29L,-17L,-1L,19L,43L,71L,103L,139L,179L,223L,271L,323L,379L,439L,503L,571L,643L,719L,799L,883L,971L,1063L,1159L,1259L,1363L,1471L,1583L,1699L,1819L,1943L,2071L,2203L,2339L,2479L,2623L,2771L,2923L,3079L,3239L,3403L,3571L,3743L,3919L,4099L,4283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155769Inst : IEnumerable<long>
{
public static readonly long[] Value=A155769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155769.Bytes);
public long this[int i]=>Value[i];

public static A155769Inst Instance=new A155769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155770
{
public static readonly long[] Value={ 19L,43L,71L,103L,139L,179L,223L,271L,379L,439L,503L,571L,643L,719L,883L,971L,1063L,1259L,1471L,1583L,1699L,2203L,2339L,3079L,3571L,3919L,4099L,4283L,4663L,5059L,5471L,5683L,6343L,6571L,6803L,7039L,7523L,8539L,8803L,9343L,9619L,11059L,11971L,12919L,13903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155770Inst : IEnumerable<long>
{
public static readonly long[] Value=A155770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155770.Bytes);
public long this[int i]=>Value[i];

public static A155770Inst Instance=new A155770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155771
{
public static readonly long[] Value={ 5L,6L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,21L,22L,23L,25L,27L,28L,29L,33L,34L,39L,42L,44L,45L,46L,48L,50L,52L,53L,56L,57L,58L,59L,61L,65L,66L,68L,69L,74L,77L,80L,83L,86L,87L,90L,91L,93L,95L,96L,99L,101L,103L,104L,106L,107L,110L,116L,121L,126L,128L,130L,131L,133L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155771Inst : IEnumerable<long>
{
public static readonly long[] Value=A155771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155771.Bytes);
public long this[int i]=>Value[i];

public static A155771Inst Instance=new A155771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155772
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,23L,29L,53L,59L,61L,83L,101L,103L,107L,131L,151L,179L,181L,191L,193L,199L,227L,239L,269L,281L,293L,313L,367L,383L,389L,419L,439L,467L,487L,503L,521L,541L,569L,587L,599L,601L,607L,617L,641L,647L,653L,673L,677L,691L,709L,733L,739L,757L,769L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155772Inst : IEnumerable<long>
{
public static readonly long[] Value=A155772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155772.Bytes);
public long this[int i]=>Value[i];

public static A155772Inst Instance=new A155772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155773
{
public static readonly long[] Value={ 1L,1L,7L,1L,2L,6L,7L,6L,4L,1L,1L,6L,5L,2L,4L,5L,5L,4L,1L,8L,6L,3L,9L,7L,9L,2L,0L,4L,3L,5L,0L,4L,8L,0L,7L,6L,1L,5L,3L,8L,1L,8L,7L,6L,6L,3L,3L,2L,9L,0L,3L,8L,4L,4L,6L,5L,5L,0L,4L,9L,6L,8L,1L,2L,0L,9L,0L,3L,8L,1L,3L,0L,7L,1L,7L,5L,7L,1L,8L,6L,1L,6L,7L,7L,1L,5L,7L,1L,1L,0L,6L,1L,8L,1L,3L,3L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155773Inst : IEnumerable<long>
{
public static readonly long[] Value=A155773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155773.Bytes);
public long this[int i]=>Value[i];

public static A155773Inst Instance=new A155773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155774
{
public static readonly long[] Value={ 7L,17L,19L,31L,37L,41L,73L,487L,619L,1487L,1489L,1597L,11699L,29629L,95443L,111119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155774Inst : IEnumerable<long>
{
public static readonly long[] Value=A155774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155774.Bytes);
public long this[int i]=>Value[i];

public static A155774Inst Instance=new A155774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155775
{
public static readonly long[] Value={ 9L,15L,33L,35L,39L,55L,57L,69L,75L,77L,91L,203L,205L,207L,209L,219L,237L,247L,249L,355L,365L,391L,405L,483L,633L,749L,1475L,1501L,1515L,1595L,1605L,1615L,1631L,2611L,2637L,2829L,11603L,11803L,13479L,20797L,20891L,95375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155775Inst : IEnumerable<long>
{
public static readonly long[] Value=A155775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155775.Bytes);
public long this[int i]=>Value[i];

public static A155775Inst Instance=new A155775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155776
{
public static readonly long[] Value={ 6L,8L,10L,12L,22L,24L,34L,52L,70L,72L,88L,92L,104L,204L,232L,278L,348L,350L,364L,376L,486L,644L,1478L,1504L,1830L,2622L,2646L,3694L,3704L,11602L,11706L,12560L,20884L,21698L,29630L,96140L,809912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155776Inst : IEnumerable<long>
{
public static readonly long[] Value=A155776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155776.Bytes);
public long this[int i]=>Value[i];

public static A155776Inst Instance=new A155776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155777
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,23L,31L,37L,47L,53L,67L,71L,73L,103L,107L,113L,127L,131L,137L,151L,157L,167L,173L,211L,223L,227L,233L,251L,257L,271L,277L,307L,311L,313L,317L,331L,337L,347L,353L,367L,373L,457L,467L,503L,521L,523L,541L,547L,557L,571L,577L,607L,617L,647L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155777Inst : IEnumerable<long>
{
public static readonly long[] Value=A155777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155777.Bytes);
public long this[int i]=>Value[i];

public static A155777Inst Instance=new A155777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155778
{
public static readonly long[] Value={ 3L,5L,23L,83L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155778Inst : IEnumerable<long>
{
public static readonly long[] Value=A155778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155778.Bytes);
public long this[int i]=>Value[i];

public static A155778Inst Instance=new A155778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155779
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,29L,31L,79L,89L,127L,1889L,3511L,8971L,13331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155779Inst : IEnumerable<long>
{
public static readonly long[] Value=A155779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155779.Bytes);
public long this[int i]=>Value[i];

public static A155779Inst Instance=new A155779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155780
{
public static readonly long[] Value={ 3L,5L,7L,23L,29L,31L,71L,1301L,4937L,6959L,47093L,74167L,345547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155780Inst : IEnumerable<long>
{
public static readonly long[] Value=A155780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155780.Bytes);
public long this[int i]=>Value[i];

public static A155780Inst Instance=new A155780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155781
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,2L,7L,3L,0L,8L,8L,8L,0L,8L,4L,0L,9L,7L,7L,0L,3L,5L,0L,5L,7L,2L,0L,5L,6L,3L,5L,6L,1L,4L,6L,1L,5L,7L,0L,7L,8L,3L,0L,3L,8L,4L,6L,5L,9L,9L,3L,2L,8L,2L,4L,1L,7L,0L,2L,0L,7L,4L,1L,6L,4L,5L,5L,1L,3L,2L,8L,8L,2L,4L,8L,0L,5L,5L,8L,5L,0L,6L,6L,3L,6L,7L,3L,6L,8L,6L,6L,9L,1L,5L,5L,3L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155781Inst : IEnumerable<long>
{
public static readonly long[] Value=A155781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155781.Bytes);
public long this[int i]=>Value[i];

public static A155781Inst Instance=new A155781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155782
{
public static readonly long[] Value={ 1L,1L,1L,4L,8L,5L,7L,9L,0L,4L,6L,5L,9L,3L,2L,4L,3L,1L,4L,0L,4L,9L,8L,4L,0L,7L,6L,1L,6L,8L,1L,4L,4L,8L,2L,3L,9L,6L,7L,5L,8L,0L,7L,8L,8L,1L,4L,2L,0L,4L,4L,2L,0L,1L,7L,8L,2L,8L,2L,0L,0L,4L,1L,1L,4L,3L,1L,5L,8L,2L,6L,5L,4L,9L,3L,0L,0L,0L,4L,5L,8L,8L,1L,7L,7L,3L,7L,2L,8L,2L,4L,8L,2L,1L,7L,2L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155782Inst : IEnumerable<long>
{
public static readonly long[] Value=A155782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155782.Bytes);
public long this[int i]=>Value[i];

public static A155782Inst Instance=new A155782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155783
{
public static readonly long[] Value={ 1L,0L,9L,1L,0L,0L,2L,3L,6L,3L,0L,3L,8L,7L,7L,2L,9L,7L,3L,2L,1L,0L,3L,6L,3L,4L,1L,1L,6L,9L,3L,6L,8L,5L,6L,9L,0L,1L,7L,2L,2L,1L,7L,3L,0L,6L,2L,8L,9L,7L,7L,0L,7L,2L,6L,4L,9L,5L,5L,0L,0L,1L,5L,5L,3L,0L,1L,9L,4L,1L,5L,8L,0L,9L,7L,6L,4L,2L,9L,7L,8L,0L,5L,4L,8L,7L,9L,7L,0L,3L,8L,6L,4L,9L,1L,4L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155783Inst : IEnumerable<long>
{
public static readonly long[] Value=A155783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155783.Bytes);
public long this[int i]=>Value[i];

public static A155783Inst Instance=new A155783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155784
{
public static readonly long[] Value={ 1L,0L,6L,9L,4L,2L,7L,2L,9L,5L,9L,5L,7L,3L,2L,5L,1L,4L,2L,7L,8L,0L,6L,0L,1L,2L,6L,8L,6L,1L,9L,1L,2L,9L,8L,9L,7L,1L,4L,2L,5L,9L,8L,0L,5L,6L,7L,2L,6L,6L,8L,1L,9L,3L,6L,1L,6L,1L,6L,0L,5L,4L,1L,5L,3L,0L,6L,1L,0L,1L,3L,5L,9L,2L,3L,2L,5L,0L,8L,3L,6L,8L,1L,0L,6L,0L,7L,3L,0L,6L,4L,3L,0L,0L,7L,0L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155784Inst : IEnumerable<long>
{
public static readonly long[] Value=A155784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155784.Bytes);
public long this[int i]=>Value[i];

public static A155784Inst Instance=new A155784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155785
{
public static readonly long[] Value={ 1L,22L,303L,323L,333L,343L,363L,393L,4004L,4014L,4024L,4034L,4044L,4054L,4064L,4074L,4084L,4094L,4104L,4114L,4124L,4134L,4144L,4154L,4164L,4174L,4184L,4194L,4204L,4214L,4224L,4234L,4244L,4254L,4264L,4274L,4284L,4294L,4304L,4314L,4324L,4334L,4344L,4354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155785Inst : IEnumerable<long>
{
public static readonly long[] Value=A155785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155785.Bytes);
public long this[int i]=>Value[i];

public static A155785Inst Instance=new A155785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155786
{
public static readonly long[] Value={ 23L,43L,67L,89L,211L,223L,233L,241L,251L,263L,271L,281L,283L,293L,433L,443L,463L,607L,617L,647L,677L,809L,827L,829L,839L,857L,859L,877L,887L,2003L,2011L,2053L,2063L,2081L,2083L,2111L,2113L,2131L,2141L,2143L,2153L,2161L,2203L,2213L,2221L,2243L,2251L,2273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155786Inst : IEnumerable<long>
{
public static readonly long[] Value=A155786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155786.Bytes);
public long this[int i]=>Value[i];

public static A155786Inst Instance=new A155786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155787
{
public static readonly long[] Value={ 1L,0L,4L,9L,7L,8L,9L,9L,5L,1L,5L,7L,6L,2L,3L,4L,8L,3L,2L,5L,5L,2L,7L,8L,9L,8L,6L,0L,8L,6L,9L,7L,1L,9L,5L,3L,0L,4L,0L,3L,2L,2L,4L,8L,4L,4L,9L,6L,3L,1L,9L,4L,8L,2L,1L,4L,9L,3L,8L,0L,1L,9L,2L,0L,0L,1L,2L,3L,8L,4L,7L,4L,0L,3L,0L,1L,6L,6L,6L,0L,1L,6L,2L,5L,6L,2L,2L,1L,5L,7L,3L,8L,6L,9L,8L,0L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155787Inst : IEnumerable<long>
{
public static readonly long[] Value=A155787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155787.Bytes);
public long this[int i]=>Value[i];

public static A155787Inst Instance=new A155787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155788
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,9L,7L,3L,1L,29L,24L,12L,4L,1L,97L,85L,46L,18L,5L,1L,333L,306L,177L,76L,25L,6L,1L,1165L,1115L,681L,315L,115L,33L,7L,1L,4135L,4100L,2622L,1288L,510L,164L,42L,8L,1L,14845L,15185L,10104L,5220L,2206L,774L,224L,52L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155788Inst : IEnumerable<long>
{
public static readonly long[] Value=A155788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155788.Bytes);
public long this[int i]=>Value[i];

public static A155788Inst Instance=new A155788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155789
{
public static readonly long[] Value={ 1L,0L,3L,1L,8L,1L,5L,3L,1L,9L,6L,2L,8L,4L,3L,0L,4L,4L,7L,3L,6L,8L,1L,3L,1L,2L,7L,4L,7L,6L,9L,3L,1L,1L,2L,4L,9L,4L,1L,2L,7L,4L,9L,3L,1L,2L,6L,5L,5L,2L,5L,1L,9L,0L,4L,7L,8L,3L,9L,9L,4L,4L,3L,5L,9L,6L,0L,9L,4L,1L,7L,8L,6L,4L,0L,8L,5L,4L,9L,8L,6L,4L,4L,1L,5L,8L,5L,2L,7L,9L,8L,3L,9L,4L,0L,3L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155789Inst : IEnumerable<long>
{
public static readonly long[] Value=A155789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155789.Bytes);
public long this[int i]=>Value[i];

public static A155789Inst Instance=new A155789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155790
{
public static readonly long[] Value={ 1L,0L,1L,5L,2L,7L,9L,9L,0L,5L,6L,6L,2L,2L,0L,9L,1L,2L,4L,2L,7L,3L,9L,5L,4L,5L,4L,2L,8L,6L,8L,7L,9L,3L,2L,9L,0L,1L,4L,3L,6L,9L,9L,0L,4L,1L,0L,0L,7L,9L,0L,9L,4L,6L,2L,2L,5L,2L,0L,3L,6L,6L,9L,8L,1L,4L,0L,8L,7L,7L,9L,5L,7L,1L,6L,7L,7L,1L,3L,0L,8L,2L,1L,6L,7L,6L,1L,4L,9L,6L,1L,0L,2L,8L,2L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155790Inst : IEnumerable<long>
{
public static readonly long[] Value=A155790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155790.Bytes);
public long this[int i]=>Value[i];

public static A155790Inst Instance=new A155790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155791
{
public static readonly long[] Value={ 9L,8L,5L,8L,2L,3L,0L,4L,4L,3L,0L,8L,2L,9L,2L,1L,3L,8L,4L,5L,9L,5L,6L,7L,9L,3L,1L,9L,0L,4L,0L,6L,1L,2L,9L,4L,2L,0L,5L,7L,9L,3L,3L,0L,4L,0L,8L,2L,6L,9L,4L,5L,2L,5L,4L,0L,6L,6L,3L,0L,8L,8L,7L,5L,2L,4L,5L,4L,1L,6L,5L,0L,4L,7L,3L,9L,0L,0L,8L,5L,5L,7L,7L,4L,1L,8L,1L,9L,9L,4L,3L,4L,0L,3L,9L,5L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155791Inst : IEnumerable<long>
{
public static readonly long[] Value=A155791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155791.Bytes);
public long this[int i]=>Value[i];

public static A155791Inst Instance=new A155791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155792
{
public static readonly long[] Value={ 9L,7L,2L,6L,2L,1L,1L,7L,5L,8L,4L,0L,7L,8L,0L,7L,0L,0L,6L,1L,1L,8L,3L,2L,7L,1L,7L,8L,0L,8L,8L,7L,6L,2L,8L,5L,0L,0L,6L,8L,3L,3L,7L,2L,5L,4L,9L,6L,1L,2L,5L,1L,0L,3L,2L,1L,7L,5L,5L,4L,9L,1L,2L,2L,9L,0L,8L,8L,1L,2L,7L,3L,5L,4L,3L,7L,0L,5L,8L,9L,1L,5L,4L,1L,8L,4L,2L,7L,7L,4L,7L,4L,7L,5L,8L,7L,3L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155792Inst : IEnumerable<long>
{
public static readonly long[] Value=A155792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155792.Bytes);
public long this[int i]=>Value[i];

public static A155792Inst Instance=new A155792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155793
{
public static readonly long[] Value={ 4L,5L,2L,3L,5L,6L,1L,9L,5L,6L,0L,5L,7L,0L,1L,2L,8L,7L,2L,2L,9L,4L,1L,4L,8L,2L,4L,4L,1L,6L,2L,6L,6L,8L,8L,4L,4L,4L,9L,8L,8L,2L,5L,1L,2L,5L,4L,4L,2L,5L,5L,5L,0L,5L,9L,4L,9L,4L,4L,4L,3L,7L,3L,2L,0L,1L,4L,7L,7L,8L,1L,4L,5L,5L,6L,2L,7L,6L,4L,6L,9L,6L,1L,1L,0L,7L,5L,4L,5L,2L,5L,8L,6L,2L,0L,8L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155793Inst : IEnumerable<long>
{
public static readonly long[] Value=A155793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155793.Bytes);
public long this[int i]=>Value[i];

public static A155793Inst Instance=new A155793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155794
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,6L,24L,6L,1L,1L,24L,720L,720L,24L,1L,1L,120L,40320L,362880L,40320L,120L,1L,1L,720L,3628800L,479001600L,479001600L,3628800L,720L,1L,1L,5040L,479001600L,1307674368000L,20922789888000L,1307674368000L,479001600L,5040L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155794Inst : IEnumerable<long>
{
public static readonly long[] Value=A155794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155794.Bytes);
public long this[int i]=>Value[i];

public static A155794Inst Instance=new A155794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155795
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,6L,1L,1L,24L,24L,24L,1L,1L,120L,0L,0L,120L,1L,1L,720L,0L,0L,0L,720L,1L,1L,5040L,0L,0L,0L,0L,5040L,1L,1L,40320L,0L,0L,0L,0L,0L,40320L,1L,1L,362880L,0L,0L,0L,0L,0L,0L,362880L,1L,1L,3628800L,0L,0L,0L,0L,0L,0L,0L,3628800L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155795Inst : IEnumerable<long>
{
public static readonly long[] Value=A155795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155795.Bytes);
public long this[int i]=>Value[i];

public static A155795Inst Instance=new A155795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155796
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-2L,-33L,1L,1L,-109L,-209L,1L,11L,-324L,-894L,1641L,1L,36L,-867L,-4262L,12951L,85926L,1L,92L,-2085L,-20516L,74369L,625164L,1435939L,1L,211L,-4419L,-93989L,344617L,4306671L,9337441L,-7280909L,1L,457L,-7652L,-402971L,1253140L,28570687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155796Inst : IEnumerable<long>
{
public static readonly long[] Value=A155796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155796.Bytes);
public long this[int i]=>Value[i];

public static A155796Inst Instance=new A155796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155797
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,6L,6L,0L,0L,0L,0L,28L,84L,28L,0L,0L,0L,0L,120L,792L,792L,120L,0L,0L,0L,0L,495L,6435L,12870L,6435L,495L,0L,0L,0L,0L,2002L,48620L,167960L,167960L,48620L,2002L,0L,0L,0L,0L,8008L,352716L,1961256L,3268760L,1961256L,352716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155797Inst : IEnumerable<long>
{
public static readonly long[] Value=A155797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155797.Bytes);
public long this[int i]=>Value[i];

public static A155797Inst Instance=new A155797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155798
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,7L,4L,1L,1L,5L,16L,16L,5L,1L,1L,6L,43L,104L,43L,6L,1L,1L,7L,141L,827L,827L,141L,7L,1L,1L,8L,523L,6491L,12940L,6491L,523L,8L,1L,1L,9L,2038L,48704L,168086L,168086L,48704L,2038L,9L,1L,1L,10L,8053L,352836L,1961466L,3269012L,1961466L,352836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155798Inst : IEnumerable<long>
{
public static readonly long[] Value=A155798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155798.Bytes);
public long this[int i]=>Value[i];

public static A155798Inst Instance=new A155798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155799
{
public static readonly long[] Value={ 9L,2L,5L,8L,5L,7L,2L,7L,4L,7L,1L,2L,8L,9L,3L,1L,2L,7L,9L,9L,8L,8L,8L,2L,1L,3L,8L,2L,0L,7L,1L,5L,8L,4L,1L,5L,2L,7L,8L,4L,5L,0L,2L,1L,8L,1L,9L,1L,9L,6L,6L,0L,2L,1L,5L,3L,2L,7L,6L,5L,6L,6L,2L,0L,2L,9L,5L,6L,7L,4L,4L,6L,8L,1L,0L,7L,1L,2L,4L,7L,5L,7L,0L,3L,9L,6L,4L,4L,8L,6L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155799Inst : IEnumerable<long>
{
public static readonly long[] Value=A155799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155799.Bytes);
public long this[int i]=>Value[i];

public static A155799Inst Instance=new A155799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155800
{
public static readonly long[] Value={ 2L,0L,3L,5L,7L,19L,17L,31L,97L,191L,127L,449L,769L,3329L,6143L,7937L,12799L,51199L,8191L,165887L,65537L,131071L,1179649L,2654209L,7995391L,524287L,10616831L,12910591L,167772161L,113246209L,169869311L,155189249L,1887436799L,3221225473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155800Inst : IEnumerable<long>
{
public static readonly long[] Value=A155800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155800.Bytes);
public long this[int i]=>Value[i];

public static A155800Inst Instance=new A155800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155801
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,31L,37L,43L,73L,101L,107L,127L,181L,257L,313L,443L,619L,757L,1093L,1193L,1297L,1453L,1571L,1619L,1787L,1831L,1879L,2801L,4889L,5113L,5189L,5557L,5869L,5981L,6211L,6827L,7607L,7759L,7919L,8191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155801Inst : IEnumerable<long>
{
public static readonly long[] Value=A155801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155801.Bytes);
public long this[int i]=>Value[i];

public static A155801Inst Instance=new A155801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155802
{
public static readonly long[] Value={ 3L,5L,7L,15L,65L,105L,135L,155L,235L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155802Inst : IEnumerable<long>
{
public static readonly long[] Value=A155802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155802.Bytes);
public long this[int i]=>Value[i];

public static A155802Inst Instance=new A155802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155803
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,9L,18L,36L,73L,146L,292L,585L,1170L,2340L,4681L,9362L,18724L,37449L,74898L,149796L,299593L,599186L,1198372L,2396745L,4793490L,9586980L,19173961L,38347922L,76695844L,153391689L,306783378L,613566756L,1227133513L,2454267026L,4908534052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155803Inst : IEnumerable<long>
{
public static readonly long[] Value=A155803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155803.Bytes);
public long this[int i]=>Value[i];

public static A155803Inst Instance=new A155803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155804
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,19L,161L,1606L,21022L,323485L,5874913L,122077756L,2871573596L,75437801539L,2193468714373L,70020045331510L,2437979768144026L,92073099488632441L,3753886179551636513L,BigInteger.Parse("164556499026975482008") };
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
public class A155804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155804Inst Instance=new A155804Inst();

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