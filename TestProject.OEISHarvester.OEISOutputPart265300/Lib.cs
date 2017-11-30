using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A025000
{
public static readonly long[] Value={ 3L,4L,6L,9L,14L,21L,30L,42L,57L,77L,102L,133L,171L,217L,274L,341L,422L,518L,632L,766L,922L,1106L,1320L,1565L,1846L,2171L,2541L,2967L,3447L,3996L,4618L,5321L,6117L,7018L,8027L,9162L,10438L,11858L,13450L,15225L,17205L,19400L,21849L,24573L,27584L,30916L,34612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025000Inst : IEnumerable<long>
{
public static readonly long[] Value=A025000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025000.Bytes);
public long this[int i]=>Value[i];

public static A025000Inst Instance=new A025000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025001
{
public static readonly long[] Value={ 5L,8L,12L,18L,26L,36L,50L,68L,91L,120L,155L,200L,253L,318L,394L,485L,591L,717L,866L,1040L,1242L,1474L,1744L,2052L,2408L,2816L,3277L,3805L,4403L,5080L,5846L,6711L,7684L,8776L,10004L,11376L,12912L,14622L,16535L,18665L,21030L,23660L,26575L,29802L,33375L,37326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025001Inst : IEnumerable<long>
{
public static readonly long[] Value=A025001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025001.Bytes);
public long this[int i]=>Value[i];

public static A025001Inst Instance=new A025001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025002
{
public static readonly long[] Value={ 7L,10L,15L,22L,32L,45L,62L,84L,112L,145L,186L,236L,297L,369L,455L,555L,676L,816L,980L,1172L,1392L,1650L,1944L,2282L,2667L,3108L,3611L,4184L,4833L,5566L,6399L,7332L,8380L,9562L,10884L,12358L,14010L,15856L,17906L,20189L,22728L,25539L,28659L,32103L,35917L,40132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025002Inst : IEnumerable<long>
{
public static readonly long[] Value=A025002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025002.Bytes);
public long this[int i]=>Value[i];

public static A025002Inst Instance=new A025002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025003
{
public static readonly long[] Value={ 2L,4L,8L,14L,22L,33L,48L,66L,90L,120L,156L,202L,256L,322L,400L,494L,604L,734L,888L,1067L,1272L,1512L,1790L,2107L,2472L,2890L,3364L,3903L,4515L,5207L,5990L,6875L,7868L,8984L,10238L,11637L,13207L,14959L,16909L,19075L,21483L,24173L,27149L,30436L,34080L,38103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025003Inst : IEnumerable<long>
{
public static readonly long[] Value=A025003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025003.Bytes);
public long this[int i]=>Value[i];

public static A025003Inst Instance=new A025003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025004
{
public static readonly long[] Value={ 3L,6L,10L,16L,25L,36L,51L,70L,94L,124L,161L,207L,262L,328L,407L,502L,614L,746L,900L,1080L,1288L,1529L,1808L,2127L,2494L,2915L,3393L,3939L,4556L,5253L,6040L,6930L,7931L,9056L,10322L,11729L,13308L,15067L,17031L,19208L,21637L,24340L,27330L,30633L,34296L,38344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025004Inst : IEnumerable<long>
{
public static readonly long[] Value=A025004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025004.Bytes);
public long this[int i]=>Value[i];

public static A025004Inst Instance=new A025004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025021
{
public static readonly long[] Value={ 7L,14L,17L,31L,34L,41L,49L,62L,79L,82L,89L,98L,103L,113L,119L,127L,137L,151L,158L,161L,178L,199L,206L,217L,223L,226L,233L,238L,254L,257L,271L,274L,281L,287L,289L,302L,322L,329L,343L,353L,367L,391L,398L,401L,434L,439L,446L,449L,463L,466L,487L,497L,511L,514L,521L,527L,542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025021Inst : IEnumerable<long>
{
public static readonly long[] Value=A025021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025021.Bytes);
public long this[int i]=>Value[i];

public static A025021Inst Instance=new A025021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025022
{
public static readonly long[] Value={ 23L,46L,47L,73L,94L,97L,146L,167L,193L,194L,263L,313L,334L,337L,383L,386L,433L,457L,503L,526L,529L,577L,626L,647L,673L,674L,743L,766L,863L,866L,887L,914L,937L,983L,1006L,1033L,1058L,1081L,1103L,1153L,1154L,1223L,1294L,1297L,1346L,1367L,1486L,1487L,1583L,1607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025022Inst : IEnumerable<long>
{
public static readonly long[] Value=A025022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025022.Bytes);
public long this[int i]=>Value[i];

public static A025022Inst Instance=new A025022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025023
{
public static readonly long[] Value={ 71L,142L,191L,239L,241L,359L,382L,409L,431L,478L,482L,599L,601L,718L,769L,818L,862L,911L,1031L,1198L,1202L,1249L,1321L,1439L,1489L,1538L,1609L,1822L,1871L,2039L,2062L,2089L,2111L,2161L,2281L,2498L,2591L,2642L,2711L,2878L,2879L,2978L,3001L,3119L,3121L,3169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025023Inst : IEnumerable<long>
{
public static readonly long[] Value=A025023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025023.Bytes);
public long this[int i]=>Value[i];

public static A025023Inst Instance=new A025023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025024
{
public static readonly long[] Value={ 311L,622L,719L,839L,1009L,1129L,1201L,1438L,1511L,1678L,1801L,2018L,2258L,2399L,2402L,2521L,3022L,3049L,3191L,3359L,3361L,3602L,3889L,4079L,4201L,4561L,4679L,4729L,4798L,4871L,5039L,5042L,5209L,5351L,5591L,5879L,5881L,6098L,6359L,6382L,6718L,6719L,6722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025024Inst : IEnumerable<long>
{
public static readonly long[] Value=A025024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025024.Bytes);
public long this[int i]=>Value[i];

public static A025024Inst Instance=new A025024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025025
{
public static readonly long[] Value={ 479L,958L,1151L,1319L,2302L,2351L,2638L,2689L,3529L,3671L,3911L,4702L,4751L,4919L,5378L,5519L,5569L,6599L,7058L,7342L,7559L,7561L,7681L,7822L,8951L,9241L,9502L,9601L,9719L,9769L,9838L,11038L,11138L,12049L,12239L,12721L,12911L,13151L,13198L,14159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025025Inst : IEnumerable<long>
{
public static readonly long[] Value=A025025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025025.Bytes);
public long this[int i]=>Value[i];

public static A025025Inst Instance=new A025025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025026
{
public static readonly long[] Value={ 1559L,2999L,3118L,5998L,6551L,8089L,8761L,13102L,13729L,14759L,16178L,16631L,17522L,18119L,19009L,21121L,21961L,23399L,24049L,27431L,27458L,27551L,28081L,29518L,31249L,33262L,33289L,33479L,35281L,35591L,36238L,36791L,38018L,42242L,43391L,43922L,43991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025026Inst : IEnumerable<long>
{
public static readonly long[] Value=A025026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025026.Bytes);
public long this[int i]=>Value[i];

public static A025026Inst Instance=new A025026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025027
{
public static readonly long[] Value={ 5711L,9239L,10391L,10799L,11422L,14951L,18478L,20782L,21598L,29902L,33049L,34319L,36599L,37489L,40031L,42719L,44641L,49009L,49921L,51769L,53089L,55441L,57119L,59929L,61151L,61871L,63361L,66098L,67369L,67679L,68638L,69001L,71569L,73198L,74978L,75479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025027Inst : IEnumerable<long>
{
public static readonly long[] Value=A025027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025027.Bytes);
public long this[int i]=>Value[i];

public static A025027Inst Instance=new A025027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025028
{
public static readonly long[] Value={ 10559L,15791L,21118L,31582L,50951L,53231L,53881L,88079L,88919L,92569L,97919L,101902L,102001L,106462L,107762L,123191L,128519L,130729L,138311L,142271L,144169L,158759L,166319L,166609L,167879L,173209L,174599L,176158L,176401L,177838L,185138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025028Inst : IEnumerable<long>
{
public static readonly long[] Value=A025028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025028.Bytes);
public long this[int i]=>Value[i];

public static A025028Inst Instance=new A025028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025029
{
public static readonly long[] Value={ 18191L,35279L,36382L,38639L,63839L,70558L,77278L,87481L,95471L,104711L,127678L,147671L,174962L,185641L,190942L,193751L,199559L,209422L,217439L,284231L,290351L,295342L,312311L,322559L,336361L,363359L,371282L,375359L,387502L,394969L,399118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025029Inst : IEnumerable<long>
{
public static readonly long[] Value=A025029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025029.Bytes);
public long this[int i]=>Value[i];

public static A025029Inst Instance=new A025029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025030
{
public static readonly long[] Value={ 1L,7L,28L,140L,658L,3164L,15106L,72302L,345775L,1654092L,7911970L,37846314L,181033035L,865951710L,4142180085L,19813648817L,94776329265L,453351783116L,2168556616440L,10373043626906L,49618272850056L,237343357526002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025030Inst : IEnumerable<long>
{
public static readonly long[] Value=A025030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025030.Bytes);
public long this[int i]=>Value[i];

public static A025030Inst Instance=new A025030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025031
{
public static readonly long[] Value={ 1L,32L,675L,11830L,186641L,2752932L,38765455L,527869010L,7009691181L,91304772832L,1171464693035L,14850954198990L,186462962442121L,2322930268904732L,28754646814361415L,354082225170989770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025031Inst : IEnumerable<long>
{
public static readonly long[] Value=A025031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025031.Bytes);
public long this[int i]=>Value[i];

public static A025031Inst Instance=new A025031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025032
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,12L,15L,16L,20L,24L,28L,32L,36L,40L,44L,45L,48L,56L,60L,64L,72L,80L,88L,96L,104L,108L,112L,120L,128L,132L,136L,140L,144L,160L,168L,176L,180L,192L,208L,216L,220L,224L,240L,252L,264L,272L,280L,288L,304L,312L,320L,336L,352L,360L,384L,396L,400L,416L,420L,432L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025032Inst : IEnumerable<long>
{
public static readonly long[] Value=A025032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025032.Bytes);
public long this[int i]=>Value[i];

public static A025032Inst Instance=new A025032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025033
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,8L,9L,12L,14L,18L,20L,25L,28L,31L,32L,33L,40L,44L,48L,52L,60L,68L,70L,82L,83L,86L,96L,102L,105L,108L,109L,116L,128L,139L,144L,152L,156L,168L,180L,183L,184L,196L,216L,220L,228L,236L,244L,260L,264L,270L,284L,304L,310L,324L,338L,348L,356L,367L,372L,388L,400L,404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025033Inst : IEnumerable<long>
{
public static readonly long[] Value=A025033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025033.Bytes);
public long this[int i]=>Value[i];

public static A025033Inst Instance=new A025033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025034
{
public static readonly long[] Value={ 3L,4L,8L,12L,21L,16L,24L,36L,95L,40L,48L,68L,171L,80L,88L,203L,531L,140L,264L,176L,759L,144L,240L,352L,819L,424L,532L,592L,1005L,520L,528L,616L,1435L,336L,1092L,944L,1767L,624L,680L,912L,1995L,2316L,720L,1040L,5115L,672L,1008L,2080L,4305L,1260L,2856L,3552L,5247L,1540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025034Inst : IEnumerable<long>
{
public static readonly long[] Value=A025034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025034.Bytes);
public long this[int i]=>Value[i];

public static A025034Inst Instance=new A025034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025035
{
public static readonly BigInteger[] Value={ 1L,1L,10L,280L,15400L,1401400L,190590400L,36212176000L,9161680528000L,2977546171600000L,1208883745669600000L,BigInteger.Parse("599606337852121600000"),BigInteger.Parse("356765771022012352000000"),BigInteger.Parse("250806337028474683456000000"),BigInteger.Parse("205661196363349240433920000000"),BigInteger.Parse("194555491759728381450488320000000") };
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
public class A025035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A025035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025035Inst Instance=new A025035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025036
{
public static readonly BigInteger[] Value={ 1L,1L,35L,5775L,2627625L,2546168625L,4509264634875L,13189599057009375L,BigInteger.Parse("59287247761257140625"),BigInteger.Parse("388035036597427985390625"),BigInteger.Parse("3546252199463894358484921875"),BigInteger.Parse("43764298393583920278062420859375") };
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
public class A025036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025036.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A025036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025036Inst Instance=new A025036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025053
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,12L,13L,16L,22L,23L,29L,33L,34L,38L,44L,49L,51L,57L,60L,62L,67L,71L,77L,85L,89L,90L,94L,96L,100L,114L,117L,123L,125L,134L,136L,142L,148L,152L,158L,164L,166L,175L,177L,181L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025053Inst : IEnumerable<long>
{
public static readonly long[] Value=A025053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025053.Bytes);
public long this[int i]=>Value[i];

public static A025053Inst Instance=new A025053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025054
{
public static readonly long[] Value={ 4L,7L,9L,11L,14L,17L,19L,21L,24L,26L,28L,30L,32L,35L,37L,39L,41L,43L,45L,47L,50L,52L,54L,56L,58L,61L,63L,65L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,118L,120L,122L,124L,126L,129L,131L,133L,135L,137L,139L,141L,143L,145L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025054Inst : IEnumerable<long>
{
public static readonly long[] Value=A025054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025054.Bytes);
public long this[int i]=>Value[i];

public static A025054Inst Instance=new A025054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025055
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,10L,12L,13L,15L,16L,18L,20L,22L,23L,25L,27L,29L,31L,33L,34L,36L,38L,40L,42L,44L,46L,48L,49L,51L,53L,55L,57L,59L,60L,62L,64L,66L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,117L,119L,121L,123L,125L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025055Inst : IEnumerable<long>
{
public static readonly long[] Value=A025055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025055.Bytes);
public long this[int i]=>Value[i];

public static A025055Inst Instance=new A025055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025056
{
public static readonly long[] Value={ 1L,7L,20L,39L,65L,95L,132L,176L,225L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025056Inst : IEnumerable<long>
{
public static readonly long[] Value=A025056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025056.Bytes);
public long this[int i]=>Value[i];

public static A025056Inst Instance=new A025056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025057
{
public static readonly long[] Value={ 2L,4L,6L,9L,12L,14L,16L,19L,22L,24L,27L,30L,33L,35L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025057Inst : IEnumerable<long>
{
public static readonly long[] Value=A025057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025057.Bytes);
public long this[int i]=>Value[i];

public static A025057Inst Instance=new A025057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025058
{
public static readonly long[] Value={ 11L,14L,17L,19L,20L,23L,23L,26L,26L,27L,29L,29L,31L,31L,32L,34L,35L,35L,36L,38L,38L,39L,39L,41L,41L,41L,43L,44L,44L,44L,46L,47L,47L,47L,47L,49L,50L,50L,51L,51L,52L,53L,53L,54L,54L,55L,55L,56L,56L,56L,59L,59L,59L,59L,59L,61L,61L,62L,62L,62L,63L,63L,64L,65L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025058Inst : IEnumerable<long>
{
public static readonly long[] Value=A025058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025058.Bytes);
public long this[int i]=>Value[i];

public static A025058Inst Instance=new A025058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025059
{
public static readonly long[] Value={ 23L,26L,29L,31L,35L,38L,39L,41L,44L,47L,50L,51L,53L,54L,55L,56L,59L,61L,62L,63L,65L,66L,68L,69L,71L,74L,75L,76L,77L,79L,80L,81L,83L,84L,86L,87L,89L,90L,91L,92L,94L,95L,96L,98L,99L,101L,103L,104L,106L,107L,108L,109L,110L,111L,113L,114L,115L,116L,117L,118L,119L,121L,122L,123L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025059Inst : IEnumerable<long>
{
public static readonly long[] Value=A025059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025059.Bytes);
public long this[int i]=>Value[i];

public static A025059Inst Instance=new A025059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025060
{
public static readonly long[] Value={ 11L,14L,17L,19L,20L,23L,26L,27L,29L,31L,32L,34L,35L,36L,38L,39L,41L,43L,44L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,71L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L,84L,86L,87L,89L,90L,91L,92L,94L,95L,96L,97L,98L,99L,100L,101L,103L,104L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025060Inst : IEnumerable<long>
{
public static readonly long[] Value=A025060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025060.Bytes);
public long this[int i]=>Value[i];

public static A025060Inst Instance=new A025060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025061
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,17L,18L,21L,26L,30L,31L,37L,40L,41L,46L,50L,54L,61L,65L,66L,69L,71L,74L,87L,90L,95L,97L,107L,109L,115L,121L,124L,129L,134L,136L,145L,147L,151L,153L,164L,176L,180L,182L,185L,191L,192L,202L,207L,213L,219L,221L,226L,229L,231L,241L,255L,259L,260L,264L,277L,283L,292L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025061Inst : IEnumerable<long>
{
public static readonly long[] Value=A025061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025061.Bytes);
public long this[int i]=>Value[i];

public static A025061Inst Instance=new A025061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025062
{
public static readonly long[] Value={ 2L,5L,7L,11L,12L,14L,15L,19L,20L,23L,25L,27L,29L,32L,34L,36L,38L,42L,44L,47L,49L,51L,52L,55L,57L,58L,60L,62L,64L,67L,68L,70L,72L,75L,77L,79L,82L,84L,86L,88L,91L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,123L,126L,128L,130L,132L,133L,135L,137L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025062Inst : IEnumerable<long>
{
public static readonly long[] Value=A025062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025062.Bytes);
public long this[int i]=>Value[i];

public static A025062Inst Instance=new A025062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025063
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,10L,13L,16L,17L,18L,21L,22L,24L,26L,28L,30L,31L,33L,35L,37L,39L,40L,41L,43L,45L,46L,48L,50L,53L,54L,56L,59L,61L,63L,65L,66L,69L,71L,73L,74L,76L,78L,80L,81L,83L,85L,87L,89L,90L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,124L,125L,127L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025063Inst : IEnumerable<long>
{
public static readonly long[] Value=A025063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025063.Bytes);
public long this[int i]=>Value[i];

public static A025063Inst Instance=new A025063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025064
{
public static readonly long[] Value={ 8L,43L,70L,105L,146L,194L,248L,307L,374L,448L,528L,615L,707L,805L,910L,1021L,1138L,1260L,1388L,1523L,1664L,1810L,1963L,2122L,2287L,2458L,2635L,2818L,3007L,3202L,3403L,3610L,3823L,4042L,4267L,4498L,4735L,4978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025064Inst : IEnumerable<long>
{
public static readonly long[] Value=A025064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025064.Bytes);
public long this[int i]=>Value[i];

public static A025064Inst Instance=new A025064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025065
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,7L,7L,12L,12L,19L,19L,30L,30L,45L,45L,67L,67L,97L,97L,139L,139L,195L,195L,272L,272L,373L,373L,508L,508L,684L,684L,915L,915L,1212L,1212L,1597L,1597L,2087L,2087L,2714L,2714L,3506L,3506L,4508L,4508L,5763L,5763L,7338L,7338L,9296L,9296L,11732L,11732L,14742L,14742L,18460L,18460L,23025L,23025L,28629L,28629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025065Inst : IEnumerable<long>
{
public static readonly long[] Value=A025065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025065.Bytes);
public long this[int i]=>Value[i];

public static A025065Inst Instance=new A025065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025066
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,1L,2L,2L,3L,2L,3L,4L,3L,4L,4L,5L,6L,5L,5L,6L,7L,6L,8L,7L,8L,8L,10L,8L,9L,10L,10L,11L,11L,11L,12L,11L,12L,14L,14L,13L,14L,15L,14L,15L,16L,15L,18L,16L,17L,17L,19L,19L,19L,19L,19L,20L,21L,20L,21L,22L,23L,23L,23L,22L,24L,24L,24L,26L,26L,25L,26L,28L,27L,27L,28L,27L,31L,28L,30L,30L,30L,30L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025066Inst : IEnumerable<long>
{
public static readonly long[] Value=A025066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025066.Bytes);
public long this[int i]=>Value[i];

public static A025066Inst Instance=new A025066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025067
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,18L,34L,55L,89L,144L,246L,398L,665L,1076L,1775L,2872L,4647L,7519L,12255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025067Inst : IEnumerable<long>
{
public static readonly long[] Value=A025067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025067.Bytes);
public long this[int i]=>Value[i];

public static A025067Inst Instance=new A025067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025068
{
public static readonly long[] Value={ 3L,4L,7L,11L,25L,40L,76L,123L,199L,322L,550L,890L,1487L,2406L,3969L,6422L,10391L,16813L,27403L,44339L,72064L,116602L,189187L,306111L,496141L,802773L,1298914L,2101687L,3402808L,5505859L,8912238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025068Inst : IEnumerable<long>
{
public static readonly long[] Value=A025068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025068.Bytes);
public long this[int i]=>Value[i];

public static A025068Inst Instance=new A025068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025069
{
public static readonly long[] Value={ 2L,3L,5L,7L,16L,20L,35L,43L,53L,65L,86L,106L,137L,153L,196L,220L,246L,270L,329L,353L,412L,454L,521L,559L,642L,686L,732L,780L,869L,917L,1032L,1080L,1199L,1263L,1388L,1456L,1597L,1673L,1735L,1823L,1974L,2062L,2227L,2301L,2476L,2572L,2761L,2863L,3062L,3166L,3365L,3475L,3591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025069Inst : IEnumerable<long>
{
public static readonly long[] Value=A025069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025069.Bytes);
public long this[int i]=>Value[i];

public static A025069Inst Instance=new A025069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025070
{
public static readonly long[] Value={ 6L,8L,9L,10L,21L,24L,37L,42L,47L,51L,69L,75L,96L,102L,126L,135L,142L,150L,178L,187L,217L,227L,259L,272L,307L,319L,332L,345L,385L,401L,443L,457L,503L,522L,568L,587L,636L,656L,675L,693L,747L,769L,825L,847L,906L,929L,991L,1016L,1079L,1105L,1172L,1201L,1230L,1256L,1324L,1354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025070Inst : IEnumerable<long>
{
public static readonly long[] Value=A025070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025070.Bytes);
public long this[int i]=>Value[i];

public static A025070Inst Instance=new A025070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025071
{
public static readonly long[] Value={ 2L,3L,5L,8L,18L,29L,55L,89L,144L,233L,398L,644L,1076L,1741L,2872L,4647L,7519L,12166L,19829L,32084L,52146L,84374L,136897L,221504L,359011L,580892L,939903L,1520795L,2462295L,3984077L,6448956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025071Inst : IEnumerable<long>
{
public static readonly long[] Value=A025071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025071.Bytes);
public long this[int i]=>Value[i];

public static A025071Inst Instance=new A025071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025072
{
public static readonly long[] Value={ 3L,5L,7L,9L,18L,22L,35L,41L,47L,53L,72L,80L,103L,113L,140L,152L,164L,176L,209L,223L,260L,276L,317L,335L,380L,400L,420L,440L,491L,513L,568L,592L,651L,677L,740L,768L,835L,865L,895L,925L,998L,1030L,1107L,1141L,1222L,1258L,1343L,1381L,1470L,1510L,1603L,1645L,1687L,1729L,1828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025072Inst : IEnumerable<long>
{
public static readonly long[] Value=A025072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025072.Bytes);
public long this[int i]=>Value[i];

public static A025072Inst Instance=new A025072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025073
{
public static readonly long[] Value={ 3L,4L,6L,8L,15L,19L,29L,34L,39L,43L,60L,66L,84L,94L,115L,125L,135L,144L,172L,182L,213L,226L,259L,274L,310L,326L,343L,359L,400L,418L,463L,483L,531L,551L,603L,626L,680L,704L,729L,754L,812L,839L,901L,928L,995L,1023L,1093L,1124L,1196L,1228L,1303L,1337L,1372L,1405L,1486L,1521L,1605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025073Inst : IEnumerable<long>
{
public static readonly long[] Value=A025073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025073.Bytes);
public long this[int i]=>Value[i];

public static A025073Inst Instance=new A025073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025074
{
public static readonly long[] Value={ 5L,7L,10L,13L,25L,31L,48L,56L,64L,71L,98L,108L,138L,153L,188L,204L,220L,235L,280L,297L,347L,368L,422L,446L,505L,531L,558L,584L,651L,680L,753L,785L,863L,896L,980L,1017L,1105L,1144L,1184L,1224L,1319L,1362L,1463L,1507L,1615L,1661L,1774L,1824L,1941L,1993L,2115L,2170L,2226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025074Inst : IEnumerable<long>
{
public static readonly long[] Value=A025074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025074.Bytes);
public long this[int i]=>Value[i];

public static A025074Inst Instance=new A025074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025075
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,2L,1L,2L,2L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025075Inst : IEnumerable<long>
{
public static readonly long[] Value=A025075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025075.Bytes);
public long this[int i]=>Value[i];

public static A025075Inst Instance=new A025075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025076
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,3L,3L,2L,3L,3L,3L,5L,4L,5L,5L,6L,6L,6L,7L,7L,7L,9L,8L,9L,9L,10L,9L,10L,10L,11L,12L,12L,11L,13L,12L,13L,15L,14L,14L,15L,16L,16L,16L,17L,17L,19L,18L,19L,19L,20L,20L,21L,20L,20L,21L,21L,21L,23L,23L,23L,23L,25L,24L,25L,25L,26L,28L,27L,27L,28L,28L,29L,30L,30L,30L,31L,31L,32L,32L,34L,33L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025076Inst : IEnumerable<long>
{
public static readonly long[] Value=A025076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025076.Bytes);
public long this[int i]=>Value[i];

public static A025076Inst Instance=new A025076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025077
{
public static readonly long[] Value={ 3L,5L,7L,11L,20L,28L,43L,53L,65L,73L,106L,120L,153L,177L,220L,246L,270L,300L,353L,381L,454L,484L,559L,601L,686L,732L,780L,822L,917L,979L,1080L,1140L,1263L,1327L,1456L,1530L,1673L,1735L,1823L,1901L,2062L,2148L,2301L,2393L,2572L,2672L,2863L,2965L,3166L,3264L,3475L,3591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025077Inst : IEnumerable<long>
{
public static readonly long[] Value=A025077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025077.Bytes);
public long this[int i]=>Value[i];

public static A025077Inst Instance=new A025077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025078
{
public static readonly long[] Value={ 1L,2L,5L,8L,19L,31L,65L,105L,210L,340L,654L,1058L,1985L,3212L,5911L,9564L,17345L,28065L,50305L,81395L,144516L,233832L,411900L,666468L,1166209L,1886966L,3283145L,5312240L,9197455L,14881795L,25655489L,41511453L,71293590L,115355452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025078Inst : IEnumerable<long>
{
public static readonly long[] Value=A025078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025078.Bytes);
public long this[int i]=>Value[i];

public static A025078Inst Instance=new A025078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025079
{
public static readonly long[] Value={ 3L,4L,11L,18L,43L,69L,145L,235L,470L,760L,1462L,2366L,4439L,7182L,13217L,21386L,38785L,62755L,112485L,182005L,323148L,522864L,921036L,1490268L,2607723L,4219384L,7341335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025079Inst : IEnumerable<long>
{
public static readonly long[] Value=A025079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025079.Bytes);
public long this[int i]=>Value[i];

public static A025079Inst Instance=new A025079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025080
{
public static readonly long[] Value={ 2L,3L,8L,12L,28L,38L,73L,95L,170L,206L,352L,426L,715L,827L,1368L,1602L,2630L,3028L,4943L,5461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025080Inst : IEnumerable<long>
{
public static readonly long[] Value=A025080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025080.Bytes);
public long this[int i]=>Value[i];

public static A025080Inst Instance=new A025080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025081
{
public static readonly long[] Value={ 6L,8L,17L,19L,40L,46L,83L,95L,166L,185L,312L,337L,561L,608L,1000L,1091L,1783L,1914L,3117L,3284L,5335L,5630L,9132L,9674L,15677L,16343L,26470L,27607L,44697L,46688L,75573L,79191L,128165L,135055L,218556L,228235L,369326L,381137L,616728L,636705L,1030248L,1064841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025081Inst : IEnumerable<long>
{
public static readonly long[] Value=A025081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025081.Bytes);
public long this[int i]=>Value[i];

public static A025081Inst Instance=new A025081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025082
{
public static readonly long[] Value={ 2L,3L,8L,13L,31L,50L,105L,170L,340L,550L,1058L,1712L,3212L,5197L,9564L,15475L,28065L,45410L,81395L,131700L,233832L,378348L,666468L,1078368L,1886966L,3053175L,5312240L,8595385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025082Inst : IEnumerable<long>
{
public static readonly long[] Value=A025082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025082.Bytes);
public long this[int i]=>Value[i];

public static A025082Inst Instance=new A025082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025083
{
public static readonly long[] Value={ 3L,5L,12L,16L,34L,42L,77L,91L,160L,184L,312L,352L,587L,653L,1076L,1184L,1938L,2114L,3445L,3731L,6064L,6528L,10592L,11344L,18387L,19605L,31756L,33728L,54610L,57802L,93565L,98731L,159792L,168152L,272120L,285648L,462235L,484125L,783380L,818800L,1324898L,1382210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025083Inst : IEnumerable<long>
{
public static readonly long[] Value=A025083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025083.Bytes);
public long this[int i]=>Value[i];

public static A025083Inst Instance=new A025083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025084
{
public static readonly long[] Value={ 3L,4L,10L,14L,29L,36L,65L,75L,132L,152L,258L,288L,480L,540L,889L,980L,1604L,1734L,2826L,3080L,5006L,5387L,8740L,9274L,15032L,16055L,26006L,27467L,44473L,47315L,76589L,80838L,130833L,136791L,221369L,232789L,376699L,393071L,636042L,667961L,1080825L,1128970L,1826756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025084Inst : IEnumerable<long>
{
public static readonly long[] Value=A025084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025084.Bytes);
public long this[int i]=>Value[i];

public static A025084Inst Instance=new A025084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025149
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,6L,6L,8L,9L,11L,12L,15L,17L,20L,23L,27L,31L,36L,41L,47L,55L,62L,71L,81L,93L,105L,120L,135L,154L,174L,197L,221L,251L,281L,317L,356L,400L,447L,502L,561L,628L,701L,782L,871L,972L,1081L,1202L,1336L,1483L,1645L,1825L,2021L,2237L,2476L,2736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025149Inst : IEnumerable<long>
{
public static readonly long[] Value=A025149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025149.Bytes);
public long this[int i]=>Value[i];

public static A025149Inst Instance=new A025149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025150
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,7L,8L,10L,11L,13L,15L,17L,20L,23L,26L,30L,35L,39L,45L,51L,58L,66L,75L,84L,96L,108L,122L,137L,155L,173L,195L,219L,245L,274L,307L,342L,383L,427L,475L,529L,589L,654L,727L,807L,894L,991L,1098L,1214L,1343L,1485L,1638L,1809L,1995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025150Inst : IEnumerable<long>
{
public static readonly long[] Value=A025150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025150.Bytes);
public long this[int i]=>Value[i];

public static A025150Inst Instance=new A025150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025151
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,7L,7L,9L,10L,12L,13L,16L,17L,20L,23L,26L,29L,34L,38L,43L,49L,55L,62L,70L,79L,88L,100L,111L,125L,140L,157L,174L,196L,217L,243L,270L,301L,333L,372L,411L,457L,506L,561L,619L,687L,757L,837L,924L,1019L,1122L,1238L,1361L,1498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025151Inst : IEnumerable<long>
{
public static readonly long[] Value=A025151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025151.Bytes);
public long this[int i]=>Value[i];

public static A025151Inst Instance=new A025151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025152
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,7L,8L,9L,11L,12L,14L,16L,18L,20L,23L,26L,29L,33L,37L,42L,47L,53L,59L,67L,74L,83L,93L,104L,115L,129L,143L,160L,177L,197L,218L,243L,268L,297L,329L,364L,401L,444L,489L,540L,595L,655L,721L,794L,872L,958L,1053L,1156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025152Inst : IEnumerable<long>
{
public static readonly long[] Value=A025152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025152.Bytes);
public long this[int i]=>Value[i];

public static A025152Inst Instance=new A025152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025153
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,8L,8L,10L,11L,13L,14L,17L,18L,21L,23L,26L,29L,33L,36L,41L,46L,51L,57L,64L,71L,79L,88L,97L,109L,120L,133L,147L,164L,180L,200L,220L,244L,268L,297L,325L,360L,395L,435L,477L,526L,575L,633L,693L,761L,832L,913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025153Inst : IEnumerable<long>
{
public static readonly long[] Value=A025153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025153.Bytes);
public long this[int i]=>Value[i];

public static A025153Inst Instance=new A025153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025154
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,8L,9L,10L,12L,13L,15L,17L,19L,21L,24L,26L,29L,33L,36L,40L,45L,50L,55L,62L,68L,76L,84L,93L,102L,114L,125L,138L,152L,168L,184L,204L,223L,246L,270L,297L,325L,358L,391L,429L,470L,515L,562L,616L,672L,735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025154Inst : IEnumerable<long>
{
public static readonly long[] Value=A025154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025154.Bytes);
public long this[int i]=>Value[i];

public static A025154Inst Instance=new A025154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025155
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,9L,9L,11L,12L,14L,15L,18L,19L,22L,24L,27L,29L,33L,36L,40L,44L,49L,54L,60L,66L,73L,81L,89L,98L,108L,119L,130L,144L,157L,173L,189L,208L,227L,250L,272L,299L,326L,358L,389L,427L,464L,508L,553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025155Inst : IEnumerable<long>
{
public static readonly long[] Value=A025155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025155.Bytes);
public long this[int i]=>Value[i];

public static A025155Inst Instance=new A025155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025156
{
public static readonly long[] Value={ 7L,8L,13L,14L,19L,20L,23L,25L,26L,31L,33L,34L,37L,38L,43L,44L,47L,49L,50L,53L,55L,56L,61L,63L,64L,67L,68L,73L,75L,76L,79L,80L,83L,85L,86L,89L,91L,93L,94L,97L,98L,103L,104L,109L,110L,113L,115L,119L,121L,123L,124L,127L,128L,131L,133L,134L,141L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025156Inst : IEnumerable<long>
{
public static readonly long[] Value=A025156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025156.Bytes);
public long this[int i]=>Value[i];

public static A025156Inst Instance=new A025156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025157
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,7L,8L,10L,11L,13L,15L,17L,19L,22L,25L,28L,32L,36L,41L,46L,52L,58L,66L,73L,82L,91L,102L,113L,126L,139L,155L,171L,190L,209L,232L,255L,282L,310L,342L,375L,413L,452L,497L,544L,596L,651L,713L,778L,850L,927L,1011L,1101L,1200L,1305L,1420L,1544L,1677L,1821L,1977L,2144L,2324L,2519L,2728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025157Inst : IEnumerable<long>
{
public static readonly long[] Value=A025157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025157.Bytes);
public long this[int i]=>Value[i];

public static A025157Inst Instance=new A025157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025158
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,7L,8L,9L,11L,12L,14L,16L,18L,20L,23L,25L,28L,31L,35L,38L,43L,47L,53L,58L,65L,71L,80L,87L,97L,106L,118L,128L,142L,154L,170L,185L,203L,220L,242L,262L,287L,311L,340L,368L,402L,435L,474L,513L,558L,603L,656L,708L,768L,829L,898L,968L,1048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025158Inst : IEnumerable<long>
{
public static readonly long[] Value=A025158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025158.Bytes);
public long this[int i]=>Value[i];

public static A025158Inst Instance=new A025158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025159
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,8L,9L,10L,12L,13L,15L,17L,19L,21L,24L,26L,29L,32L,35L,38L,42L,46L,50L,55L,60L,66L,72L,79L,86L,95L,103L,113L,123L,135L,146L,160L,173L,189L,204L,222L,239L,260L,280L,303L,326L,353L,379L,410L,440L,475L,510L,550L,590L,636L,682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025159Inst : IEnumerable<long>
{
public static readonly long[] Value=A025159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025159.Bytes);
public long this[int i]=>Value[i];

public static A025159Inst Instance=new A025159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025160
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,10L,11L,13L,14L,16L,18L,20L,22L,25L,27L,30L,33L,36L,39L,43L,46L,50L,54L,59L,63L,69L,74L,81L,87L,95L,102L,112L,120L,131L,141L,154L,165L,180L,193L,210L,225L,244L,261L,283L,302L,326L,348L,375L,400L,430L,458L,492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025160Inst : IEnumerable<long>
{
public static readonly long[] Value=A025160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025160.Bytes);
public long this[int i]=>Value[i];

public static A025160Inst Instance=new A025160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025161
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,10L,11L,12L,14L,15L,17L,19L,21L,23L,26L,28L,31L,34L,37L,40L,44L,47L,51L,55L,59L,63L,68L,73L,78L,84L,90L,97L,104L,112L,120L,130L,139L,150L,161L,174L,186L,201L,215L,232L,248L,267L,285L,307L,327L,351L,374L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025161Inst : IEnumerable<long>
{
public static readonly long[] Value=A025161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025161.Bytes);
public long this[int i]=>Value[i];

public static A025161Inst Instance=new A025161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025162
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,11L,12L,13L,15L,16L,18L,20L,22L,24L,27L,29L,32L,35L,38L,41L,45L,48L,52L,56L,60L,64L,69L,73L,78L,83L,89L,94L,101L,107L,115L,122L,131L,139L,150L,159L,171L,182L,196L,208L,224L,238L,256L,272L,292L,310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025162Inst : IEnumerable<long>
{
public static readonly long[] Value=A025162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025162.Bytes);
public long this[int i]=>Value[i];

public static A025162Inst Instance=new A025162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025163
{
public static readonly long[] Value={ 0L,1L,6L,18L,20L,-90L,-588L,-1708L,-1944L,7110L,47300L,136092L,156312L,-528164L,-3540600L,-10141080L,-11703344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025163Inst : IEnumerable<long>
{
public static readonly long[] Value=A025163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025163.Bytes);
public long this[int i]=>Value[i];

public static A025163Inst Instance=new A025163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025164
{
public static readonly BigInteger[] Value={ 1L,1L,4L,21L,151L,1380L,15331L,200683L,3025576L,51635475L,984099601L,20717727096L,477491822809L,11958013297321L,323343850850476L,9388929687961125L,291380164177645351L,9624934347550257708UL,BigInteger.Parse("337164082328436665131"),BigInteger.Parse("12484695980499706867555"),BigInteger.Parse("487240307321817004499776") };
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
public class A025164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025164Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A025164.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025164Inst Instance=new A025164Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025165
{
public static readonly long[] Value={ 1L,2L,1L,-2L,-5L,-2L,23L,58L,-103L,-670L,257L,7214L,4387L,-77794L,-134825L,819466L,2841841L,-7427774L,-55739071L,22221790L,1081264139L,1718092478L,-20988454441L,-79774943398L,402959508745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025165Inst : IEnumerable<long>
{
public static readonly long[] Value=A025165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025165.Bytes);
public long this[int i]=>Value[i];

public static A025165Inst Instance=new A025165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025166
{
public static readonly BigInteger[] Value={ -1L,-1L,-1L,7L,127L,1711L,23231L,334391L,5144063L,84149983L,1446872959L,25661798119L,454494403199L,7489030040207L,89680375568447L,-759618144120809L,-127049044802971649L,-7480338932613448769L,BigInteger.Parse("-369274690558092738817"),BigInteger.Parse("-17262533154073740329017") };
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
public class A025166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A025166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025166Inst Instance=new A025166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025167
{
public static readonly BigInteger[] Value={ 1L,3L,17L,139L,1473L,19091L,291793L,5129307L,101817089L,2250495523L,54780588561L,1455367098923L,41888448785857L,1298019439099059L,43074477771208913L,1523746948247663611L,BigInteger.Parse("57229027745514785793"),BigInteger.Parse("2274027983943883110467") };
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
public class A025167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A025167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025167Inst Instance=new A025167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025168
{
public static readonly BigInteger[] Value={ 1L,1L,5L,37L,361L,4361L,62701L,1044205L,19748177L,417787921L,9770678101L,250194150581L,6959638411705L,208919770666777L,6729933476435261L,231512615111396221L,8469125401589550241L,BigInteger.Parse("328241040596380393505"),BigInteger.Parse("13434223364220816489637"),BigInteger.Parse("578931271898150002093381") };
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
public class A025168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A025168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025168Inst Instance=new A025168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025169
{
public static readonly long[] Value={ 2L,6L,16L,42L,110L,288L,754L,1974L,5168L,13530L,35422L,92736L,242786L,635622L,1664080L,4356618L,11405774L,29860704L,78176338L,204668310L,535828592L,1402817466L,3672623806L,9615053952L,25172538050L,65902560198L,172535142544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025169Inst : IEnumerable<long>
{
public static readonly long[] Value=A025169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025169.Bytes);
public long this[int i]=>Value[i];

public static A025169Inst Instance=new A025169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025170
{
public static readonly long[] Value={ 1L,-2L,-5L,28L,-11L,-230L,559L,952L,-6935L,5302L,51811L,-151340L,-163619L,1689298L,-1906025L,-11391632L,39937489L,22649710L,-404736821L,605626252L,2431378885L,-10313394038L,-1255621889L,95331790120L,-179362983239L,-499260144602L,2612787138355L,-732232975292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025170Inst : IEnumerable<long>
{
public static readonly long[] Value=A025170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025170.Bytes);
public long this[int i]=>Value[i];

public static A025170Inst Instance=new A025170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025171
{
public static readonly long[] Value={ 1L,-2L,-12L,56L,80L,-1056L,832L,15232L,-43776L,-156160L,1012736L,473088L,-17149952L,26730496L,220938240L,-869564416L,-1795883008L,17504796672L,-6275465216L,-267525816320L,635459076096L,3009494908928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025171Inst : IEnumerable<long>
{
public static readonly long[] Value=A025171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025171.Bytes);
public long this[int i]=>Value[i];

public static A025171Inst Instance=new A025171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025172
{
public static readonly long[] Value={ 1L,1L,-7L,-23L,17L,241L,329L,-1511L,-5983L,1633L,57113L,99529L,-314959L,-1525679L,-216727L,13297657L,28545857L,-62587199L,-382087111L,-200889431L,3037005137L,7882015153L,-11569015927L,-94076168231L,-84031193119L,678623127841L,2113526993753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025172Inst : IEnumerable<long>
{
public static readonly long[] Value=A025172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025172.Bytes);
public long this[int i]=>Value[i];

public static A025172Inst Instance=new A025172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025173
{
public static readonly long[] Value={ 0L,1L,-5L,-42L,-22L,575L,1677L,-3332L,-27740L,-23859L,259055L,832370L,-981714L,-10980437L,-13342175L,85437240L,319499912L,-192522535L,-3642631389L,-5753449394L,24313788850L,108290637399L,-13811840779L,-1096315586380L,-2152355798868L,6240751807525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025173Inst : IEnumerable<long>
{
public static readonly long[] Value=A025173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025173.Bytes);
public long this[int i]=>Value[i];

public static A025173Inst Instance=new A025173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025174
{
public static readonly long[] Value={ 0L,1L,5L,28L,165L,1001L,6188L,38760L,245157L,1562275L,10015005L,64512240L,417225900L,2707475148L,17620076360L,114955808528L,751616304549L,4923689695575L,32308782859535L,212327989773900L,1397281501935165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025174Inst : IEnumerable<long>
{
public static readonly long[] Value=A025174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025174.Bytes);
public long this[int i]=>Value[i];

public static A025174Inst Instance=new A025174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025175
{
public static readonly long[] Value={ 1L,4L,3L,-40L,-190L,-168L,2023L,10096L,9486L,-110440L,-564322L,-547248L,6266884L,32468464L,32101935L,-364054048L,-1903389802L,-1906695144L,21484821178L,113055206800L,114325154076L,-1282403513776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025175Inst : IEnumerable<long>
{
public static readonly long[] Value=A025175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025175.Bytes);
public long this[int i]=>Value[i];

public static A025175Inst Instance=new A025175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025176
{
public static readonly long[] Value={ 1L,2L,9L,22L,114L,308L,1717L,4902L,28526L,84284L,504410L,1525500L,9311140L,28638504L,177367949L,552532742L,3460680278L,10888711788L,68810154286L,218247846932L,1389230689596L,4435391806552L,28403131135554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025176Inst : IEnumerable<long>
{
public static readonly long[] Value=A025176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025176.Bytes);
public long this[int i]=>Value[i];

public static A025176Inst Instance=new A025176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025177
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,2L,4L,4L,4L,2L,1L,1L,3L,7L,10L,12L,10L,7L,3L,1L,1L,4L,11L,20L,29L,32L,29L,20L,11L,4L,1L,1L,5L,16L,35L,60L,81L,90L,81L,60L,35L,16L,5L,1L,1L,6L,22L,56L,111L,176L,231L,252L,231L,176L,111L,56L,22L,6L,1L,1L,7L,29L,84L,189L,343L,518L,659L,714L,659L,518L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025177Inst : IEnumerable<long>
{
public static readonly long[] Value=A025177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025177.Bytes);
public long this[int i]=>Value[i];

public static A025177Inst Instance=new A025177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025178
{
public static readonly long[] Value={ 0L,2L,4L,12L,32L,90L,252L,714L,2032L,5814L,16700L,48136L,139152L,403286L,1171380L,3409020L,9938304L,29017878L,84844044L,248382516L,727971360L,2135784798L,6272092596L,18435108258L,54228499920L,159636389850L,470256930052L,1386170197704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025178Inst : IEnumerable<long>
{
public static readonly long[] Value=A025178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025178.Bytes);
public long this[int i]=>Value[i];

public static A025178Inst Instance=new A025178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025179
{
public static readonly long[] Value={ 1L,4L,10L,29L,81L,231L,659L,1891L,5443L,15718L,45508L,132067L,384047L,1118820L,3264642L,9539787L,27913083L,81769236L,239794422L,703906719L,2068153899L,6081507831L,17896695831L,52703944965L,155310270101L,457956633826L,1351132539604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025179Inst : IEnumerable<long>
{
public static readonly long[] Value=A025179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025179.Bytes);
public long this[int i]=>Value[i];

public static A025179Inst Instance=new A025179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025180
{
public static readonly long[] Value={ 1L,2L,7L,20L,60L,176L,518L,1520L,4461L,13090L,38423L,112828L,331487L,974442L,2866125L,8434992L,24838275L,73181142L,215729781L,636275820L,1877569134L,5543095404L,16372140876L,48377825216L,143009973875L,422918975726L,1251154692297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025180Inst : IEnumerable<long>
{
public static readonly long[] Value=A025180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025180.Bytes);
public long this[int i]=>Value[i];

public static A025180Inst Instance=new A025180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025197
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,16L,27L,43L,64L,92L,128L,172L,227L,294L,373L,467L,576L,703L,849L,1015L,1203L,1414L,1652L,1916L,2209L,2533L,2890L,3282L,3710L,4177L,4684L,5234L,5829L,6470L,7161L,7903L,8698L,9549L,10458L,11427L,12458L,13555L,14719L,15933L,17259L,18640L,20098L,21636L,23257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025197Inst : IEnumerable<long>
{
public static readonly long[] Value=A025197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025197.Bytes);
public long this[int i]=>Value[i];

public static A025197Inst Instance=new A025197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025198
{
public static readonly long[] Value={ 1L,2L,5L,13L,35L,97L,285L,877L,2834L,9564L,33627L,122806L,464672L,1817558L,7334633L,30482068L,130254933L,571484558L,2571058274L,11846898738L,55849086530L,269103228643L,1324099867934L,6647523717749L,34025304081591L,177434116933088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025198Inst : IEnumerable<long>
{
public static readonly long[] Value=A025198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025198.Bytes);
public long this[int i]=>Value[i];

public static A025198Inst Instance=new A025198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025199
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,10L,11L,13L,15L,17L,18L,20L,23L,25L,27L,29L,31L,34L,36L,38L,41L,43L,46L,48L,51L,54L,57L,59L,62L,65L,68L,71L,74L,77L,80L,83L,86L,90L,93L,96L,99L,103L,106L,110L,113L,116L,120L,124L,127L,131L,135L,139L,142L,146L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025199Inst : IEnumerable<long>
{
public static readonly long[] Value=A025199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025199.Bytes);
public long this[int i]=>Value[i];

public static A025199Inst Instance=new A025199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025200
{
public static readonly long[] Value={ 0L,2L,5L,11L,18L,28L,42L,60L,82L,107L,140L,176L,218L,267L,324L,389L,455L,538L,622L,726L,830L,945L,1072L,1211L,1363L,1513L,1692L,1868L,2076L,2282L,2502L,2759L,3013L,3283L,3572L,3854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025200Inst : IEnumerable<long>
{
public static readonly long[] Value=A025200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025200.Bytes);
public long this[int i]=>Value[i];

public static A025200Inst Instance=new A025200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025201
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,6L,8L,10L,12L,15L,17L,19L,22L,25L,27L,30L,33L,36L,39L,42L,45L,48L,51L,54L,58L,61L,64L,67L,71L,74L,78L,81L,85L,88L,92L,95L,99L,102L,106L,110L,114L,117L,121L,125L,129L,132L,136L,140L,144L,148L,152L,156L,160L,164L,168L,172L,176L,180L,184L,188L,192L,196L,201L,205L,209L,213L,217L,221L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025201Inst : IEnumerable<long>
{
public static readonly long[] Value=A025201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025201.Bytes);
public long this[int i]=>Value[i];

public static A025201Inst Instance=new A025201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025202
{
public static readonly long[] Value={ 0L,3L,8L,16L,29L,47L,70L,100L,136L,179L,231L,290L,358L,436L,523L,620L,727L,845L,973L,1114L,1266L,1430L,1606L,1795L,1997L,2212L,2441L,2683L,2939L,3210L,3495L,3795L,4110L,4440L,4786L,5147L,5524L,5918L,6327L,6754L,7197L,7657L,8134L,8628L,9140L,9669L,10217L,10782L,11366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025202Inst : IEnumerable<long>
{
public static readonly long[] Value=A025202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025202.Bytes);
public long this[int i]=>Value[i];

public static A025202Inst Instance=new A025202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025203
{
public static readonly long[] Value={ 1L,6L,21L,54L,116L,220L,383L,623L,962L,1424L,2034L,2821L,3817L,5053L,6565L,8391L,10569L,13142L,16153L,19646L,23671L,28274L,33509L,39426L,46082L,53533L,61836L,71051L,81240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025203Inst : IEnumerable<long>
{
public static readonly long[] Value=A025203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025203.Bytes);
public long this[int i]=>Value[i];

public static A025203Inst Instance=new A025203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025204
{
public static readonly long[] Value={ 1L,12L,54L,167L,422L,929L,1848L,3398L,5867L,9627L,15136L,22960L,33775L,48381L,67713L,92851L,125032L,165656L,216305L,278744L,354938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025204Inst : IEnumerable<long>
{
public static readonly long[] Value=A025204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025204.Bytes);
public long this[int i]=>Value[i];

public static A025204Inst Instance=new A025204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025205
{
public static readonly long[] Value={ 0L,1L,3L,6L,9L,13L,17L,22L,27L,33L,39L,46L,53L,60L,68L,76L,84L,93L,102L,111L,120L,130L,140L,151L,161L,172L,183L,195L,206L,218L,230L,242L,255L,267L,280L,293L,306L,320L,334L,347L,361L,375L,390L,404L,419L,434L,449L,464L,479L,495L,510L,526L,542L,558L,574L,591L,607L,624L,640L,657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025205Inst : IEnumerable<long>
{
public static readonly long[] Value=A025205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025205.Bytes);
public long this[int i]=>Value[i];

public static A025205Inst Instance=new A025205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025206
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,10L,14L,20L,27L,35L,45L,55L,67L,81L,96L,112L,129L,148L,169L,191L,214L,239L,266L,294L,324L,355L,388L,422L,458L,496L,535L,576L,618L,662L,708L,756L,805L,855L,908L,962L,1018L,1076L,1135L,1196L,1258L,1323L,1389L,1457L,1526L,1598L,1671L,1746L,1822L,1900L,1980L,2062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025206Inst : IEnumerable<long>
{
public static readonly long[] Value=A025206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025206.Bytes);
public long this[int i]=>Value[i];

public static A025206Inst Instance=new A025206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025207
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,9L,15L,22L,31L,42L,55L,71L,88L,108L,131L,157L,185L,216L,249L,286L,326L,369L,415L,464L,516L,572L,632L,694L,760L,830L,903L,980L,1060L,1144L,1232L,1323L,1418L,1517L,1620L,1727L,1837L,1952L,2070L,2192L,2319L,2449L,2584L,2722L,2865L,3011L,3162L,3317L,3476L,3639L,3807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025207Inst : IEnumerable<long>
{
public static readonly long[] Value=A025207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025207.Bytes);
public long this[int i]=>Value[i];

public static A025207Inst Instance=new A025207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025208
{
public static readonly long[] Value={ 1L,1L,3L,6L,12L,28L,64L,154L,382L,979L,2583L,6998L,19421L,55106L,159595L,471041L,1414958L,4320813L,13399076L,42157076L,134459874L,434427716L,1420861672L,4701420879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025208Inst : IEnumerable<long>
{
public static readonly long[] Value=A025208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025208.Bytes);
public long this[int i]=>Value[i];

public static A025208Inst Instance=new A025208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025209
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,5L,6L,8L,9L,10L,11L,13L,14L,15L,17L,18L,20L,21L,23L,24L,26L,27L,29L,31L,33L,34L,36L,37L,39L,41L,43L,44L,46L,48L,50L,52L,53L,55L,57L,59L,61L,63L,65L,67L,69L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025209Inst : IEnumerable<long>
{
public static readonly long[] Value=A025209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025209.Bytes);
public long this[int i]=>Value[i];

public static A025209Inst Instance=new A025209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025210
{
public static readonly long[] Value={ 0L,1L,3L,6L,11L,18L,25L,36L,50L,64L,81L,104L,127L,153L,182L,215L,251L,292L,336L,385L,438L,487L,549L,616L,687L,753L,835L,910L,1002L,1087L,1190L,1285L,1400L,1505L,1632L,1748L,1870L,1997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025210Inst : IEnumerable<long>
{
public static readonly long[] Value=A025210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025210.Bytes);
public long this[int i]=>Value[i];

public static A025210Inst Instance=new A025210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025211
{
public static readonly long[] Value={ 1L,14L,125L,910L,5901L,35574L,204205L,1132670L,6129101L,32566534L,170691885L,885423630L,4556561101L,23305343894L,118631189165L,601616805790L,3042056477901L,15346559343654L,77279066272045L,388583895311150L,1951684190615501L,9793511186181814L,49108010998116525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025211Inst : IEnumerable<long>
{
public static readonly long[] Value=A025211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025211.Bytes);
public long this[int i]=>Value[i];

public static A025211Inst Instance=new A025211Inst();

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