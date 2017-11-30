using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A179605
{
public static readonly long[] Value={ 1L,5L,17L,81L,325L,1413L,5913L,25193L,106429L,451421L,1911089L,8097825L,34298293L,145299189L,615478665L,2607246617L,11044399597L,46784976077L,198184041761L,839521667409L,3556269662821L,15064602415845L,63814675131897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179605Inst : IEnumerable<long>
{
public static readonly long[] Value=A179605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179605.Bytes);
public long this[int i]=>Value[i];

public static A179605Inst Instance=new A179605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179606
{
public static readonly long[] Value={ 1L,4L,17L,71L,298L,1249L,5237L,21956L,92053L,385939L,1618082L,6783941L,28442233L,119246404L,499950377L,2096083151L,8788001338L,36844419769L,154473265997L,647641896836L,2715292020493L,11384085545659L,47728716739442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179606Inst : IEnumerable<long>
{
public static readonly long[] Value=A179606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179606.Bytes);
public long this[int i]=>Value[i];

public static A179606Inst Instance=new A179606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179607
{
public static readonly long[] Value={ 1L,4L,12L,56L,208L,864L,3392L,13696L,54528L,218624L,873472L,3495936L,13979648L,55926784L,223690752L,894795776L,3579117568L,14316601344L,57266143232L,229065097216L,916259340288L,3665039458304L,14660153638912L,58640622944256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179607Inst : IEnumerable<long>
{
public static readonly long[] Value=A179607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179607.Bytes);
public long this[int i]=>Value[i];

public static A179607Inst Instance=new A179607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179608
{
public static readonly long[] Value={ 1L,3L,10L,24L,64L,144L,352L,768L,1792L,3840L,8704L,18432L,40960L,86016L,188416L,393216L,851968L,1769472L,3801088L,7864320L,16777216L,34603008L,73400320L,150994944L,318767104L,654311424L,1375731712L,2818572288L,5905580032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179608Inst : IEnumerable<long>
{
public static readonly long[] Value=A179608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179608.Bytes);
public long this[int i]=>Value[i];

public static A179608Inst Instance=new A179608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179609
{
public static readonly long[] Value={ 1L,0L,-8L,-24L,-80L,-192L,-512L,-1152L,-2816L,-6144L,-14336L,-30720L,-69632L,-147456L,-327680L,-688128L,-1507328L,-3145728L,-6815744L,-14155776L,-30408704L,-62914560L,-134217728L,-276824064L,-587202560L,-1207959552L,-2550136832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179609Inst : IEnumerable<long>
{
public static readonly long[] Value=A179609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179609.Bytes);
public long this[int i]=>Value[i];

public static A179609Inst Instance=new A179609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179610
{
public static readonly long[] Value={ 1L,3L,14L,53L,217L,860L,3453L,13791L,55198L,220737L,883037L,3532004L,14128249L,56512619L,226051086L,904203357L,3616815025L,14467257516L,57869034245L,231476130215L,925904531806L,3703618109513L,14814472466709L,59257889820468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179610Inst : IEnumerable<long>
{
public static readonly long[] Value=A179610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179610.Bytes);
public long this[int i]=>Value[i];

public static A179610Inst Instance=new A179610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179611
{
public static readonly long[] Value={ 1L,4L,16L,68L,280L,1168L,4848L,20160L,83776L,348224L,1447296L,6015488L,25002240L,103917568L,431915008L,1795179520L,7461349376L,31011794944L,128895102976L,535729963008L,2226667929600L,9254755975168L,38465775239168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179611Inst : IEnumerable<long>
{
public static readonly long[] Value=A179611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179611.Bytes);
public long this[int i]=>Value[i];

public static A179611Inst Instance=new A179611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179612
{
public static readonly long[] Value={ 123L,335L,2975L,3223L,4319L,11903L,25479L,30239L,138239L,393119L,416639L,508895L,773759L,861839L,1071359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179612Inst : IEnumerable<long>
{
public static readonly long[] Value=A179612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179612.Bytes);
public long this[int i]=>Value[i];

public static A179612Inst Instance=new A179612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179613
{
public static readonly long[] Value={ 1L,5L,3L,1L,1L,40L,5L,1L,1L,25L,2L,3L,1L,6L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,7L,2L,7L,1L,1L,1L,2L,1L,1L,32L,4L,1L,6L,2L,1L,1L,1L,15L,1L,5L,1L,4L,1L,1L,1L,3L,1L,3L,7L,2L,7L,1L,1L,3L,31L,1L,3L,1L,3L,1L,9L,18L,4L,5L,3L,1L,2L,3L,2L,1L,3L,7L,1L,3L,1L,9L,10L,2L,1L,2L,1L,14L,1L,17L,1L,2L,2L,1L,7L,1L,5L,3L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179613Inst : IEnumerable<long>
{
public static readonly long[] Value=A179613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179613.Bytes);
public long this[int i]=>Value[i];

public static A179613Inst Instance=new A179613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179614
{
public static readonly long[] Value={ 4L,8L,14L,16L,22L,25L,26L,32L,34L,35L,38L,44L,46L,49L,52L,58L,62L,64L,65L,68L,74L,76L,77L,82L,85L,86L,88L,92L,94L,95L,98L,104L,106L,115L,116L,118L,119L,121L,122L,124L,125L,128L,133L,134L,142L,143L,145L,146L,148L,152L,154L,155L,158L,161L,164L,166L,169L,172L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179614Inst : IEnumerable<long>
{
public static readonly long[] Value=A179614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179614.Bytes);
public long this[int i]=>Value[i];

public static A179614Inst Instance=new A179614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179615
{
public static readonly long[] Value={ 1L,3L,6L,9L,1L,1L,2L,1L,2L,1L,2L,5L,1L,12L,5L,1L,4L,1L,13L,1L,6L,1L,22L,1L,8L,21L,3L,142L,1L,1L,2L,1L,2L,2L,7L,1L,2L,1L,1L,1L,5L,3L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,106L,1L,1L,1L,1L,1L,1L,7L,1L,22L,1L,71L,1L,4L,2L,1L,3L,1L,2L,2L,1L,4L,1L,2L,2L,2L,2L,1L,2L,82L,1L,3L,1L,4L,1L,30L,1L,3L,1L,2L,1L,1L,1L,16L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179615Inst : IEnumerable<long>
{
public static readonly long[] Value=A179615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179615.Bytes);
public long this[int i]=>Value[i];

public static A179615Inst Instance=new A179615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179616
{
public static readonly long[] Value={ 1L,2L,53L,4L,96L,2L,1L,6L,2L,2L,2L,6L,1L,4L,1L,49L,17L,2L,3L,2L,7L,2L,1L,1L,3L,1L,3L,2L,1L,2L,6L,11L,1L,8L,1L,1L,10L,1L,10L,2L,5L,1L,2L,1L,1L,4L,1L,3L,3L,2L,3L,5L,2L,1L,1L,1L,1L,1L,2L,4L,1L,3L,1L,1L,2L,5L,1L,4L,3L,1L,97L,2L,1L,176L,2L,1L,1L,11L,2L,2L,9L,5L,1L,5L,5L,3L,4L,1L,2L,1L,10L,1L,3L,1L,7L,2L,2L,1L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179616Inst : IEnumerable<long>
{
public static readonly long[] Value=A179616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179616.Bytes);
public long this[int i]=>Value[i];

public static A179616Inst Instance=new A179616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179617
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,1L,3L,1L,1L,3L,2L,1L,6L,3L,4L,2L,1L,14L,1L,1L,5L,2L,2L,2L,1L,3L,23L,1L,26L,23L,13L,1L,1L,1L,5L,2L,8L,12L,1L,1L,1L,3L,5L,23L,31L,7L,1L,1L,2L,5L,4L,1L,1L,6L,1L,72L,4L,1L,1L,1L,7L,2L,1L,1L,2L,49L,3L,1L,4L,2L,3L,2L,1L,1L,6L,2L,3L,3L,1L,1L,26L,2L,2L,11L,5L,3L,5L,1L,2L,1L,12L,1L,558L,1L,1L,3L,1L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179617Inst : IEnumerable<long>
{
public static readonly long[] Value=A179617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179617.Bytes);
public long this[int i]=>Value[i];

public static A179617Inst Instance=new A179617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179618
{
public static readonly long[] Value={ 5L,11L,11L,21L,35L,21L,43L,93L,93L,43L,85L,269L,314L,269L,85L,171L,747L,1213L,1213L,747L,171L,341L,2115L,4375L,6427L,4375L,2115L,341L,683L,5933L,16334L,31387L,31387L,16334L,5933L,683L,1365L,16717L,59925L,159651L,202841L,159651L,59925L,16717L,1365L,2731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179618Inst : IEnumerable<long>
{
public static readonly long[] Value=A179618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179618.Bytes);
public long this[int i]=>Value[i];

public static A179618Inst Instance=new A179618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179619
{
public static readonly ulong[] Value={ 1L,13L,135L,1357L,13579L,135801L,1358023L,13580245L,135802467L,1358024689L,13580246911L,135802469133L,1358024691355L,13580246913577L,135802469135799L,1358024691358021L,13580246913580243L,135802469135802465L,1358024691358024687L,13580246913580246909UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179619Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A179619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179619.Bytes);
public ulong this[int i]=>Value[i];

public static A179619Inst Instance=new A179619Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179620
{
public static readonly long[] Value={ 0L,4L,7L,8L,8L,10L,13L,14L,14L,16L,19L,20L,20L,23L,24L,25L,26L,26L,28L,31L,32L,33L,34L,34L,37L,38L,38L,40L,43L,44L,44L,47L,48L,49L,50L,50L,53L,54L,55L,56L,56L,58L,61L,62L,63L,64L,64L,67L,68L,68L,70L,73L,74L,75L,76L,76L,79L,80L,80L,83L,84L,85L,86L,86L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179620Inst : IEnumerable<long>
{
public static readonly long[] Value=A179620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179620.Bytes);
public long this[int i]=>Value[i];

public static A179620Inst Instance=new A179620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179621
{
public static readonly long[] Value={ 0L,1L,1L,4L,2L,2L,1L,7L,2L,4L,1L,10L,5L,1L,12L,5L,13L,2L,7L,1L,16L,11L,17L,2L,1L,19L,2L,10L,1L,22L,11L,1L,24L,7L,25L,10L,1L,27L,11L,28L,14L,2L,1L,31L,21L,32L,16L,1L,34L,17L,14L,1L,37L,25L,38L,19L,1L,40L,20L,1L,42L,17L,43L,2L,1L,45L,13L,46L,31L,47L,2L,1L,49L,14L,25L,1L,52L,26L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179621Inst : IEnumerable<long>
{
public static readonly long[] Value=A179621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179621.Bytes);
public long this[int i]=>Value[i];

public static A179621Inst Instance=new A179621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179622
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,9L,19L,18L,28L,27L,37L,36L,46L,45L,55L,46L,91L,101L,92L,137L,147L,138L,183L,193L,184L,138L,321L,331L,322L,276L,459L,469L,460L,414L,597L,459L,928L,919L,873L,1056L,918L,1387L,1378L,1332L,1515L,1056L,1974L,2443L,2434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179622Inst : IEnumerable<long>
{
public static readonly long[] Value=A179622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179622.Bytes);
public long this[int i]=>Value[i];

public static A179622Inst Instance=new A179622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179623
{
public static readonly long[] Value={ 3711L,11134L,5567L,16702L,8351L,25054L,12527L,37582L,18791L,56374L,28187L,84562L,42281L,126844L,63422L,31711L,95134L,47567L,142702L,71351L,214054L,107027L,321082L,160541L,481624L,240812L,120406L,60203L,180610L,90305L,270916L,135458L,67729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179623Inst : IEnumerable<long>
{
public static readonly long[] Value=A179623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179623.Bytes);
public long this[int i]=>Value[i];

public static A179623Inst Instance=new A179623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179624
{
public static readonly long[] Value={ 230631L,691894L,345947L,1037842L,518921L,1556764L,778382L,389191L,1167574L,583787L,1751362L,875681L,2627044L,1313522L,656761L,1970284L,985142L,492571L,1477714L,738857L,2216572L,1108286L,554143L,1662430L,831215L,2493646L,1246823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179624Inst : IEnumerable<long>
{
public static readonly long[] Value=A179624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179624.Bytes);
public long this[int i]=>Value[i];

public static A179624Inst Instance=new A179624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179625
{
public static readonly long[] Value={ 5L,7L,13L,31L,43L,73L,157L,211L,241L,1093L,2801L,19531L,22621L,30941L,55987L,88741L,245411L,292561L,346201L,797161L,5229043L,8108731L,12207031L,25646167L,305175781L,321272407L,917087137L,16148168401L,2141993519227L,10778947368421L,17513875027111L,610851724137931L,50544702849929377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179625Inst : IEnumerable<long>
{
public static readonly long[] Value=A179625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179625.Bytes);
public long this[int i]=>Value[i];

public static A179625Inst Instance=new A179625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179626
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,3L,1L,1L,1L,3L,1L,5L,3L,1L,5L,1L,1L,5L,1L,7L,3L,1L,1L,1L,3L,1L,7L,13L,1L,1L,1L,5L,1L,5L,3L,5L,1L,1L,3L,1L,5L,1L,3L,1L,1L,5L,9L,11L,5L,9L,11L,1L,1L,1L,1L,5L,1L,1L,3L,1L,1L,1L,5L,3L,1L,5L,1L,7L,11L,13L,1L,1L,1L,3L,7L,13L,5L,3L,5L,1L,1L,3L,1L,1L,5L,7L,1L,5L,5L,1L,1L,1L,3L,7L,3L,1L,7L,5L,7L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179626Inst : IEnumerable<long>
{
public static readonly long[] Value=A179626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179626.Bytes);
public long this[int i]=>Value[i];

public static A179626Inst Instance=new A179626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179627
{
public static readonly long[] Value={ 2L,6L,5L,12L,11L,8L,10L,15L,12L,14L,68L,16L,70L,21L,67L,10L,23L,15L,20L,66L,74L,25L,71L,22L,76L,19L,57L,65L,73L,11L,32L,21L,59L,29L,18L,13L,26L,18L,45L,23L,23L,15L,31L,77L,20L,77L,28L,47L,12L,25L,55L,36L,17L,44L,79L,52L,22L,30L,14L,30L,41L,76L,27L,57L,84L,27L,19L,73L,81L,24L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179627Inst : IEnumerable<long>
{
public static readonly long[] Value=A179627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179627.Bytes);
public long this[int i]=>Value[i];

public static A179627Inst Instance=new A179627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179628
{
public static readonly long[] Value={ 0L,4L,23L,39L,116L,175L,306L,393L,578L,966L,1054L,1483L,1907L,2116L,2608L,3251L,3980L,4398L,5350L,5967L,6469L,7450L,8336L,9624L,11197L,12084L,12796L,13946L,14700L,15916L,19642L,21058L,22795L,23482L,27079L,28127L,30116L,32833L,34643L,37530L,39819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179628Inst : IEnumerable<long>
{
public static readonly long[] Value=A179628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179628.Bytes);
public long this[int i]=>Value[i];

public static A179628Inst Instance=new A179628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179629
{
public static readonly long[] Value={ 23L,59L,83L,89L,127L,181L,229L,233L,239L,241L,257L,283L,293L,359L,383L,389L,421L,457L,523L,541L,547L,557L,563L,571L,577L,599L,659L,683L,751L,787L,809L,811L,829L,839L,853L,859L,877L,883L,887L,1021L,1087L,1129L,1151L,1181L,1187L,1217L,1223L,1249L,1279L,1289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179629Inst : IEnumerable<long>
{
public static readonly long[] Value=A179629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179629.Bytes);
public long this[int i]=>Value[i];

public static A179629Inst Instance=new A179629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179630
{
public static readonly long[] Value={ 11L,23L,31L,41L,43L,53L,61L,71L,73L,101L,103L,109L,113L,137L,149L,163L,167L,173L,179L,191L,193L,199L,223L,229L,239L,269L,283L,307L,337L,349L,359L,367L,373L,397L,401L,419L,431L,433L,439L,461L,463L,467L,479L,491L,503L,509L,563L,593L,599L,601L,607L,613L,641L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179630Inst : IEnumerable<long>
{
public static readonly long[] Value=A179630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179630.Bytes);
public long this[int i]=>Value[i];

public static A179630Inst Instance=new A179630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179631
{
public static readonly long[] Value={ 23L,229L,239L,283L,359L,563L,599L,683L,809L,829L,853L,883L,1181L,1217L,1787L,1811L,1847L,2069L,2411L,2693L,2939L,3329L,3583L,4547L,4871L,4877L,5059L,5099L,5171L,5683L,5693L,5717L,6203L,6269L,6353L,6829L,7487L,7541L,8629L,8747L,9239L,9283L,10181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179631Inst : IEnumerable<long>
{
public static readonly long[] Value=A179631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179631.Bytes);
public long this[int i]=>Value[i];

public static A179631Inst Instance=new A179631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179632
{
public static readonly long[] Value={ 2L,5L,11L,19L,67L,101L,109L,127L,163L,457L,557L,587L,593L,599L,613L,647L,677L,823L,857L,877L,941L,971L,1009L,1097L,1187L,1213L,1277L,1291L,1367L,1427L,1453L,1481L,1483L,1543L,1553L,1559L,1663L,1741L,1753L,1783L,1861L,1871L,1873L,1907L,2083L,2267L,2287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179632Inst : IEnumerable<long>
{
public static readonly long[] Value=A179632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179632.Bytes);
public long this[int i]=>Value[i];

public static A179632Inst Instance=new A179632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179633
{
public static readonly long[] Value={ 3L,5L,7L,13L,31L,47L,103L,179L,197L,227L,269L,281L,317L,353L,359L,379L,383L,389L,439L,467L,499L,547L,577L,593L,619L,647L,739L,757L,829L,887L,953L,983L,1069L,1097L,1129L,1187L,1193L,1229L,1307L,1367L,1453L,1459L,1489L,1579L,1601L,1627L,1663L,1753L,1783L,1873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179633Inst : IEnumerable<long>
{
public static readonly long[] Value=A179633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179633.Bytes);
public long this[int i]=>Value[i];

public static A179633Inst Instance=new A179633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179634
{
public static readonly long[] Value={ 5L,593L,647L,1097L,1187L,1367L,1453L,1663L,1753L,1783L,1873L,1907L,2287L,2377L,2417L,2683L,3463L,3637L,3923L,4513L,5413L,5807L,6263L,6317L,6373L,7523L,7823L,8087L,8117L,8237L,8713L,10853L,11807L,11833L,11903L,15313L,15803L,16063L,16223L,17027L,18223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179634Inst : IEnumerable<long>
{
public static readonly long[] Value=A179634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179634.Bytes);
public long this[int i]=>Value[i];

public static A179634Inst Instance=new A179634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179635
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179635Inst : IEnumerable<long>
{
public static readonly long[] Value=A179635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179635.Bytes);
public long this[int i]=>Value[i];

public static A179635Inst Instance=new A179635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179636
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179636Inst : IEnumerable<long>
{
public static readonly long[] Value=A179636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179636.Bytes);
public long this[int i]=>Value[i];

public static A179636Inst Instance=new A179636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179637
{
public static readonly long[] Value={ 2L,2L,3L,4L,7L,2L,0L,0L,2L,6L,5L,3L,9L,4L,1L,2L,8L,2L,7L,6L,7L,9L,8L,4L,1L,4L,1L,5L,8L,1L,8L,8L,6L,1L,3L,0L,7L,3L,8L,1L,8L,0L,1L,3L,5L,1L,3L,4L,3L,1L,6L,2L,2L,6L,1L,2L,9L,7L,9L,9L,7L,6L,3L,1L,6L,7L,1L,0L,2L,0L,4L,7L,1L,6L,7L,6L,3L,5L,2L,4L,7L,7L,6L,8L,3L,3L,9L,9L,7L,2L,1L,9L,3L,8L,6L,4L,1L,1L,4L,7L,0L,3L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179637Inst : IEnumerable<long>
{
public static readonly long[] Value=A179637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179637.Bytes);
public long this[int i]=>Value[i];

public static A179637Inst Instance=new A179637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179638
{
public static readonly long[] Value={ 1L,1L,9L,2L,7L,0L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L,5L,5L,9L,0L,6L,0L,1L,9L,8L,4L,2L,8L,3L,7L,7L,2L,5L,1L,5L,8L,1L,5L,5L,2L,6L,2L,5L,5L,1L,8L,2L,8L,8L,6L,2L,0L,1L,5L,7L,0L,7L,7L,9L,3L,1L,4L,2L,1L,8L,8L,8L,2L,2L,7L,4L,7L,2L,4L,5L,5L,2L,5L,8L,3L,8L,6L,3L,0L,8L,2L,0L,7L,7L,0L,6L,7L,0L,0L,1L,8L,1L,1L,7L,7L,4L,7L,6L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179638Inst : IEnumerable<long>
{
public static readonly long[] Value=A179638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179638.Bytes);
public long this[int i]=>Value[i];

public static A179638Inst Instance=new A179638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179639
{
public static readonly long[] Value={ 1L,8L,8L,0L,1L,9L,2L,1L,5L,8L,2L,2L,9L,0L,8L,7L,8L,0L,2L,8L,2L,0L,1L,0L,6L,7L,9L,2L,4L,4L,0L,8L,9L,5L,2L,5L,4L,9L,5L,6L,8L,9L,8L,5L,5L,1L,5L,2L,0L,9L,8L,8L,8L,1L,3L,2L,6L,8L,2L,5L,3L,1L,3L,3L,6L,9L,5L,6L,1L,2L,0L,1L,3L,7L,8L,0L,8L,4L,3L,5L,0L,3L,9L,4L,7L,0L,7L,2L,0L,6L,9L,8L,0L,8L,7L,1L,0L,0L,1L,9L,7L,8L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179639Inst : IEnumerable<long>
{
public static readonly long[] Value=A179639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179639.Bytes);
public long this[int i]=>Value[i];

public static A179639Inst Instance=new A179639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179640
{
public static readonly long[] Value={ 8L,2L,1L,5L,6L,6L,7L,9L,2L,8L,9L,7L,2L,2L,5L,6L,7L,7L,3L,4L,8L,6L,9L,3L,5L,7L,5L,8L,0L,3L,5L,6L,3L,0L,9L,7L,5L,4L,4L,2L,8L,9L,3L,8L,7L,1L,7L,9L,9L,1L,2L,5L,6L,8L,4L,4L,1L,6L,3L,7L,0L,8L,7L,9L,9L,6L,8L,6L,1L,7L,8L,0L,5L,6L,1L,6L,9L,6L,6L,3L,7L,0L,3L,8L,6L,7L,3L,9L,4L,4L,1L,7L,2L,7L,2L,6L,9L,8L,9L,9L,2L,7L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179640Inst : IEnumerable<long>
{
public static readonly long[] Value=A179640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179640.Bytes);
public long this[int i]=>Value[i];

public static A179640Inst Instance=new A179640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179641
{
public static readonly long[] Value={ 6L,0L,3L,0L,0L,5L,6L,6L,4L,7L,9L,1L,6L,4L,9L,1L,4L,1L,3L,6L,7L,4L,3L,1L,1L,3L,9L,0L,6L,0L,9L,3L,9L,6L,8L,6L,2L,8L,6L,7L,1L,8L,1L,9L,6L,6L,3L,4L,2L,9L,3L,8L,1L,0L,3L,5L,5L,9L,0L,8L,1L,0L,3L,7L,8L,4L,2L,1L,0L,0L,7L,7L,1L,3L,6L,4L,8L,3L,7L,4L,1L,6L,1L,7L,8L,6L,7L,8L,6L,7L,3L,6L,4L,8L,9L,8L,5L,2L,2L,9L,1L,4L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179641Inst : IEnumerable<long>
{
public static readonly long[] Value=A179641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179641.Bytes);
public long this[int i]=>Value[i];

public static A179641Inst Instance=new A179641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179642
{
public static readonly long[] Value={ 120L,168L,180L,252L,264L,270L,280L,300L,312L,378L,396L,408L,440L,450L,456L,468L,520L,552L,588L,594L,612L,616L,680L,684L,696L,700L,702L,728L,744L,750L,760L,828L,882L,888L,918L,920L,945L,952L,980L,984L,1026L,1032L,1044L,1064L,1100L,1116L,1128L,1144L,1160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179642Inst : IEnumerable<long>
{
public static readonly long[] Value=A179642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179642.Bytes);
public long this[int i]=>Value[i];

public static A179642Inst Instance=new A179642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179643
{
public static readonly long[] Value={ 180L,252L,300L,396L,450L,468L,588L,612L,684L,700L,828L,882L,980L,1044L,1100L,1116L,1300L,1332L,1452L,1476L,1548L,1575L,1692L,1700L,1900L,1908L,2028L,2124L,2156L,2178L,2196L,2205L,2300L,2412L,2420L,2450L,2475L,2548L,2556L,2628L,2844L,2900L,2925L,2988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179643Inst : IEnumerable<long>
{
public static readonly long[] Value=A179643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179643.Bytes);
public long this[int i]=>Value[i];

public static A179643Inst Instance=new A179643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179644
{
public static readonly long[] Value={ 240L,336L,528L,560L,624L,810L,816L,880L,912L,1040L,1104L,1134L,1232L,1360L,1392L,1456L,1488L,1520L,1776L,1782L,1840L,1904L,1968L,2064L,2106L,2128L,2256L,2288L,2320L,2480L,2544L,2576L,2754L,2832L,2835L,2928L,2960L,2992L,3078L,3216L,3248L,3280L,3344L,3408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179644Inst : IEnumerable<long>
{
public static readonly long[] Value=A179644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179644.Bytes);
public long this[int i]=>Value[i];

public static A179644Inst Instance=new A179644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179645
{
public static readonly long[] Value={ 256L,6561L,390625L,5764801L,214358881L,815730721L,6975757441L,16983563041L,78310985281L,500246412961L,852891037441L,3512479453921L,7984925229121L,11688200277601L,23811286661761L,62259690411361L,146830437604321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179645Inst : IEnumerable<long>
{
public static readonly long[] Value=A179645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179645.Bytes);
public long this[int i]=>Value[i];

public static A179645Inst Instance=new A179645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179646
{
public static readonly long[] Value={ 288L,800L,972L,1568L,3872L,5408L,6075L,9248L,11552L,11907L,12500L,16928L,26912L,28125L,29403L,30752L,41067L,43808L,53792L,59168L,67228L,70227L,70688L,87723L,89888L,111392L,119072L,128547L,143648L,151263L,153125L,161312L,170528L,199712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179646Inst : IEnumerable<long>
{
public static readonly long[] Value=A179646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179646.Bytes);
public long this[int i]=>Value[i];

public static A179646Inst Instance=new A179646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179647
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,3L,4L,3L,1L,2L,4L,6L,7L,5L,1L,2L,4L,7L,11L,12L,8L,1L,2L,4L,8L,14L,21L,21L,13L,1L,2L,4L,8L,15L,27L,39L,37L,21L,1L,2L,4L,8L,16L,30L,52L,73L,65L,34L,1L,2L,4L,8L,16L,31L,59L,101L,136L,114L,55L,1L,2L,4L,8L,16L,32L,62L,116L,195L,254L,200L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179647Inst : IEnumerable<long>
{
public static readonly long[] Value=A179647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179647.Bytes);
public long this[int i]=>Value[i];

public static A179647Inst Instance=new A179647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179648
{
public static readonly long[] Value={ 1L,-3L,12L,-47L,190L,-778L,3224L,-13475L,56710L,-239986L,1020200L,-4353430L,18636908L,-80004388L,344264624L,-1484499811L,6413133638L,-27750688914L,120258432264L,-521833284514L,2267084792708L,-9859984425324L,42925569027408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179648Inst : IEnumerable<long>
{
public static readonly long[] Value=A179648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179648.Bytes);
public long this[int i]=>Value[i];

public static A179648Inst Instance=new A179648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179649
{
public static readonly long[] Value={ 3203324994356L,12272577818052L,26942805919966L,47088408550139L,72619548630277L,103468900363400L,139601928199359L,180946446237951L,227485624300931L,279209790387276L,336102842056834L,398010087395245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179649Inst : IEnumerable<long>
{
public static readonly long[] Value=A179649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179649.Bytes);
public long this[int i]=>Value[i];

public static A179649Inst Instance=new A179649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179650
{
public static readonly long[] Value={ 0L,3L,5L,7L,2L,3L,5L,5L,8L,13L,13L,17L,20L,21L,23L,3L,7L,7L,11L,11L,9L,13L,15L,19L,25L,25L,25L,27L,25L,25L,37L,39L,41L,41L,49L,49L,1L,1L,2L,5L,8L,7L,11L,7L,8L,7L,16L,25L,23L,22L,23L,23L,19L,26L,29L,32L,35L,31L,34L,35L,31L,38L,49L,50L,49L,47L,58L,61L,68L,67L,68L,71L,73L,76L,79L,77L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179650Inst : IEnumerable<long>
{
public static readonly long[] Value=A179650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179650.Bytes);
public long this[int i]=>Value[i];

public static A179650Inst Instance=new A179650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179651
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,4L,2L,2L,4L,4L,2L,2L,4L,4L,2L,6L,6L,2L,4L,4L,2L,6L,6L,2L,4L,4L,2L,6L,4L,4L,4L,4L,8L,6L,2L,4L,8L,4L,6L,6L,4L,2L,6L,8L,4L,12L,4L,2L,2L,4L,4L,2L,6L,4L,4L,4L,6L,6L,12L,4L,4L,4L,6L,2L,4L,4L,8L,6L,6L,4L,2L,2L,4L,8L,4L,6L,6L,4L,2L,6L,4L,8L,4L,4L,10L,2L,4L,6L,2L,4L,4L,8L,6L,2L,4L,12L,8L,8L,2L,6L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179651Inst : IEnumerable<long>
{
public static readonly long[] Value=A179651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179651.Bytes);
public long this[int i]=>Value[i];

public static A179651Inst Instance=new A179651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179652
{
public static readonly long[] Value={ 1L,3L,6L,8L,16L,23L,31L,34L,36L,48L,56L,59L,71L,83L,86L,91L,94L,108L,119L,121L,129L,133L,146L,148L,168L,169L,191L,203L,223L,226L,246L,253L,254L,259L,269L,288L,289L,303L,314L,316L,321L,338L,356L,358L,394L,399L,416L,433L,463L,464L,471L,496L,511L,519L,528L,533L,548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179652Inst : IEnumerable<long>
{
public static readonly long[] Value=A179652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179652.Bytes);
public long this[int i]=>Value[i];

public static A179652Inst Instance=new A179652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179653
{
public static readonly long[] Value={ 3L,6L,10L,15L,21L,28L,45L,55L,78L,91L,105L,136L,406L,496L,528L,595L,703L,741L,1035L,1081L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179653Inst : IEnumerable<long>
{
public static readonly long[] Value=A179653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179653.Bytes);
public long this[int i]=>Value[i];

public static A179653Inst Instance=new A179653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179654
{
public static readonly long[] Value={ 4L,10L,33L,53L,138L,201L,340L,431L,624L,1024L,1116L,1557L,1989L,2202L,2702L,3357L,4098L,4520L,5484L,6109L,6615L,7608L,8502L,9802L,11391L,12286L,13002L,14160L,14918L,16142L,19896L,21320L,23069L,23760L,27377L,28429L,30430L,33159L,34977L,37876L,40177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179654Inst : IEnumerable<long>
{
public static readonly long[] Value=A179654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179654.Bytes);
public long this[int i]=>Value[i];

public static A179654Inst Instance=new A179654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179655
{
public static readonly long[] Value={ 3L,9L,2L,6L,3L,9L,4L,6L,3L,9L,2L,6L,3L,7L,9L,6L,8L,3L,7L,9L,6L,1L,3L,5L,9L,4L,6L,3L,9L,6L,3L,5L,9L,6L,3L,7L,9L,6L,3L,5L,9L,6L,3L,7L,9L,2L,6L,1L,3L,9L,4L,6L,8L,3L,9L,6L,3L,9L,6L,8L,3L,9L,2L,6L,1L,3L,9L,6L,3L,7L,9L,2L,6L,3L,5L,9L,6L,3L,7L,9L,6L,8L,1L,3L,9L,4L,6L,8L,3L,9L,2L,6L,3L,5L,9L,4L,6L,3L,9L,2L,6L,3L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179655Inst : IEnumerable<long>
{
public static readonly long[] Value=A179655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179655.Bytes);
public long this[int i]=>Value[i];

public static A179655Inst Instance=new A179655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179656
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,0L,3L,1L,3L,0L,1L,1L,1L,5L,4L,5L,3L,7L,0L,2L,1L,1L,6L,1L,3L,3L,0L,3L,0L,1L,1L,3L,4L,4L,1L,0L,2L,1L,3L,0L,1L,1L,5L,0L,3L,6L,1L,1L,1L,4L,3L,3L,2L,1L,5L,0L,4L,1L,3L,3L,0L,1L,5L,1L,2L,1L,2L,6L,1L,7L,3L,1L,0L,3L,1L,0L,1L,1L,4L,1L,7L,0L,5L,1L,1L,2L,1L,3L,3L,1L,0L,1L,3L,7L,4L,1L,0L,0L,1L,5L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179656Inst : IEnumerable<long>
{
public static readonly long[] Value=A179656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179656.Bytes);
public long this[int i]=>Value[i];

public static A179656Inst Instance=new A179656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179657
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,3L,7L,9L,2L,6L,1L,3L,5L,9L,4L,6L,3L,9L,2L,6L,1L,3L,9L,6L,8L,3L,7L,9L,6L,1L,5L,9L,4L,3L,9L,2L,6L,5L,9L,6L,3L,7L,9L,6L,5L,9L,3L,7L,9L,2L,6L,1L,3L,9L,4L,8L,3L,9L,6L,9L,4L,8L,3L,9L,2L,6L,1L,9L,6L,3L,7L,9L,2L,6L,5L,9L,6L,3L,7L,9L,6L,1L,9L,4L,8L,9L,2L,6L,3L,5L,9L,4L,3L,9L,2L,6L,9L,8L,7L,9L,6L,1L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179657Inst : IEnumerable<long>
{
public static readonly long[] Value=A179657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179657.Bytes);
public long this[int i]=>Value[i];

public static A179657Inst Instance=new A179657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179658
{
public static readonly long[] Value={ 3L,1L,3L,15L,45L,3L,99L,45L,51L,141L,153L,177L,411L,45L,45L,267L,237L,75L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179658Inst : IEnumerable<long>
{
public static readonly long[] Value=A179658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179658.Bytes);
public long this[int i]=>Value[i];

public static A179658Inst Instance=new A179658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179659
{
public static readonly long[] Value={ 7L,8L,7L,7L,1L,1L,2L,8L,4L,1L,1L,7L,8L,5L,2L,7L,5L,1L,2L,7L,1L,4L,5L,1L,2L,8L,4L,1L,2L,8L,5L,2L,7L,4L,5L,1L,8L,7L,8L,4L,5L,4L,1L,8L,4L,5L,2L,4L,1L,7L,8L,5L,7L,8L,1L,8L,4L,2L,7L,4L,5L,2L,4L,5L,1L,2L,5L,7L,8L,1L,2L,8L,2L,7L,7L,4L,2L,8L,5L,1L,7L,5L,2L,8L,4L,1L,7L,8L,4L,7L,5L,1L,2L,5L,8L,5L,1L,4L,5L,2L,4L,2L,4L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179659Inst : IEnumerable<long>
{
public static readonly long[] Value=A179659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179659.Bytes);
public long this[int i]=>Value[i];

public static A179659Inst Instance=new A179659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179660
{
public static readonly long[] Value={ 279209790387276L,1075207199997334L,2367646772295462L,4146437503168147L,6404774487532576L,9137303389808024L,12340337443955708L,16010026481858292L,20143329357815162L,24739512092254535L,29795030058292249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179660Inst : IEnumerable<long>
{
public static readonly long[] Value=A179660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179660.Bytes);
public long this[int i]=>Value[i];

public static A179660Inst Instance=new A179660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179661
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,6L,4L,12L,12L,12L,5L,20L,60L,60L,60L,6L,30L,60L,60L,60L,60L,7L,42L,210L,420L,420L,420L,420L,8L,56L,280L,840L,840L,840L,840L,840L,9L,72L,504L,2520L,2520L,2520L,2520L,2520L,2520L,10L,90L,630L,2520L,2520L,2520L,2520L,2520L,2520L,2520L,11L,110L,990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179661Inst : IEnumerable<long>
{
public static readonly long[] Value=A179661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179661.Bytes);
public long this[int i]=>Value[i];

public static A179661Inst Instance=new A179661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179662
{
public static readonly long[] Value={ 1L,1L,1L,5L,6L,9L,11L,15L,30L,41L,54L,73L,94L,123L,157L,231L,296L,383L,486L,620L,780L,983L,1225L,1530L,1958L,2435L,3008L,3714L,4558L,5592L,6823L,8319L,10098L,12243L,14786L,17977L,21636L,26013L,31181L,37331L,44571L,53155L,63231L,75130L,89067L,105461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179662Inst : IEnumerable<long>
{
public static readonly long[] Value=A179662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179662.Bytes);
public long this[int i]=>Value[i];

public static A179662Inst Instance=new A179662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179663
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1L,5L,16L,79L,421L,2674L,19244L,156612L,1423028L,14320350L,158390872L,1912977222L,25083283995L,355246037162L,5409471180024L,88200546561838L,1534120589972637L,28369229081383675L,556021169447494656L,11517512836906556032UL,BigInteger.Parse("251487262264563372960") };
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
public class A179663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179663Inst Instance=new A179663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179664
{
public static readonly long[] Value={ 384L,640L,896L,1408L,1664L,2176L,2432L,2944L,3712L,3968L,4374L,4736L,5248L,5504L,6016L,6784L,7552L,7808L,8576L,9088L,9344L,10112L,10624L,10935L,11392L,12416L,12928L,13184L,13696L,13952L,14464L,15309L,16256L,16768L,17536L,17792L,19072L,19328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179664Inst : IEnumerable<long>
{
public static readonly long[] Value=A179664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179664.Bytes);
public long this[int i]=>Value[i];

public static A179664Inst Instance=new A179664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179665
{
public static readonly long[] Value={ 512L,19683L,1953125L,40353607L,2357947691L,10604499373L,118587876497L,322687697779L,1801152661463L,14507145975869L,26439622160671L,129961739795077L,327381934393961L,502592611936843L,1119130473102767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179665Inst : IEnumerable<long>
{
public static readonly long[] Value=A179665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179665.Bytes);
public long this[int i]=>Value[i];

public static A179665Inst Instance=new A179665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179666
{
public static readonly long[] Value={ 432L,648L,2000L,5000L,5488L,10125L,16875L,19208L,21296L,27783L,35152L,64827L,78608L,107811L,109744L,117128L,177957L,194672L,214375L,228488L,300125L,390224L,395307L,397953L,476656L,555579L,668168L,771147L,810448L,831875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179666Inst : IEnumerable<long>
{
public static readonly long[] Value=A179666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179666.Bytes);
public long this[int i]=>Value[i];

public static A179666Inst Instance=new A179666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179667
{
public static readonly long[] Value={ 480L,672L,1056L,1120L,1248L,1632L,1760L,1824L,2080L,2208L,2430L,2464L,2720L,2784L,2912L,2976L,3040L,3402L,3552L,3680L,3808L,3936L,4128L,4256L,4512L,4576L,4640L,4960L,5088L,5152L,5346L,5664L,5856L,5920L,5984L,6318L,6432L,6496L,6560L,6688L,6816L,6880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179667Inst : IEnumerable<long>
{
public static readonly long[] Value=A179667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179667.Bytes);
public long this[int i]=>Value[i];

public static A179667Inst Instance=new A179667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179668
{
public static readonly long[] Value={ 768L,1280L,1792L,2816L,3328L,4352L,4864L,5888L,7424L,7936L,9472L,10496L,11008L,12032L,13122L,13568L,15104L,15616L,17152L,18176L,18688L,20224L,21248L,22784L,24832L,25856L,26368L,27392L,27904L,28928L,32512L,32805L,33536L,35072L,35584L,38144L,38656L,40192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179668Inst : IEnumerable<long>
{
public static readonly long[] Value=A179668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179668.Bytes);
public long this[int i]=>Value[i];

public static A179668Inst Instance=new A179668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179669
{
public static readonly long[] Value={ 720L,1008L,1200L,1584L,1620L,1872L,2268L,2352L,2448L,2736L,2800L,3312L,3564L,3920L,4050L,4176L,4212L,4400L,4464L,5200L,5328L,5508L,5808L,5904L,6156L,6192L,6768L,6800L,7452L,7500L,7600L,7632L,7938L,8112L,8496L,8624L,8784L,9200L,9396L,9648L,9680L,10044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179669Inst : IEnumerable<long>
{
public static readonly long[] Value=A179669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179669.Bytes);
public long this[int i]=>Value[i];

public static A179669Inst Instance=new A179669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179670
{
public static readonly long[] Value={ 840L,1320L,1560L,1848L,1890L,2040L,2184L,2280L,2760L,2856L,2970L,3080L,3192L,3432L,3480L,3510L,3640L,3720L,3864L,4158L,4440L,4488L,4590L,4760L,4872L,4914L,4920L,5016L,5130L,5160L,5208L,5250L,5304L,5320L,5640L,5720L,5928L,6072L,6210L,6216L,6360L,6426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179670Inst : IEnumerable<long>
{
public static readonly long[] Value=A179670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179670.Bytes);
public long this[int i]=>Value[i];

public static A179670Inst Instance=new A179670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179671
{
public static readonly long[] Value={ 864L,1944L,4000L,10976L,25000L,30375L,42592L,70304L,83349L,84375L,134456L,157216L,219488L,323433L,389344L,453789L,533871L,780448L,953312L,1071875L,1193859L,1288408L,1620896L,1666737L,2100875L,2205472L,2544224L,2956581L,2970344L,3322336L,4159375L,4348377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179671Inst : IEnumerable<long>
{
public static readonly long[] Value=A179671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179671.Bytes);
public long this[int i]=>Value[i];

public static A179671Inst Instance=new A179671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179672
{
public static readonly long[] Value={ 960L,1344L,2112L,2240L,2496L,3264L,3520L,3648L,4160L,4416L,4928L,5440L,5568L,5824L,5952L,6080L,7104L,7290L,7360L,7616L,7872L,8256L,8512L,9024L,9152L,9280L,9920L,10176L,10206L,10304L,11328L,11712L,11840L,11968L,12864L,12992L,13120L,13376L,13632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179672Inst : IEnumerable<long>
{
public static readonly long[] Value=A179672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179672.Bytes);
public long this[int i]=>Value[i];

public static A179672Inst Instance=new A179672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179673
{
public static readonly long[] Value={ 919L,929L,9029L,9049L,9059L,9109L,9209L,9239L,9319L,9349L,9419L,9439L,9479L,9539L,9619L,9629L,9649L,9679L,9689L,9719L,9739L,9749L,9769L,9829L,9839L,9859L,90149L,90239L,90289L,90359L,90379L,90469L,90679L,91019L,91079L,91249L,91369L,91459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179673Inst : IEnumerable<long>
{
public static readonly long[] Value=A179673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179673.Bytes);
public long this[int i]=>Value[i];

public static A179673Inst Instance=new A179673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179674
{
public static readonly long[] Value={ 0L,2L,6L,12L,30L,54L,98L,160L,234L,400L,462L,864L,806L,1722L,1530L,3328L,1938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179674Inst : IEnumerable<long>
{
public static readonly long[] Value=A179674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179674.Bytes);
public long this[int i]=>Value[i];

public static A179674Inst Instance=new A179674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179675
{
public static readonly long[] Value={ 1L,2L,5L,14L,209L,1364L,714L,62985L,367080L,728364L,64822394L,1306238010L,11182598504L,715041747420L,51913478860880L,454746157008780L,9314160363311804L,560934821217378530L,261062105979210899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179675Inst : IEnumerable<long>
{
public static readonly long[] Value=A179675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179675.Bytes);
public long this[int i]=>Value[i];

public static A179675Inst Instance=new A179675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179676
{
public static readonly long[] Value={ 7L,15L,21L,23L,31L,35L,39L,45L,47L,49L,51L,55L,63L,71L,73L,75L,79L,85L,87L,89L,91L,93L,95L,103L,105L,111L,115L,117L,119L,123L,127L,133L,135L,143L,147L,151L,153L,155L,159L,161L,165L,167L,175L,183L,187L,189L,191L,195L,199L,215L,217L,219L,221L,223L,225L,231L,233L,235L,237L,239L,245L,247L,253L,255L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179676Inst : IEnumerable<long>
{
public static readonly long[] Value=A179676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179676.Bytes);
public long this[int i]=>Value[i];

public static A179676Inst Instance=new A179676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179677
{
public static readonly long[] Value={ 0L,2L,0L,0L,0L,12L,0L,32L,0L,140L,0L,264L,0L,868L,0L,1792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179677Inst : IEnumerable<long>
{
public static readonly long[] Value=A179677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179677.Bytes);
public long this[int i]=>Value[i];

public static A179677Inst Instance=new A179677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179678
{
public static readonly long[] Value={ 359L,6211L,13477L,19069L,20431L,22567L,32933L,39041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179678Inst : IEnumerable<long>
{
public static readonly long[] Value=A179678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179678.Bytes);
public long this[int i]=>Value[i];

public static A179678Inst Instance=new A179678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179679
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,29L,37L,41L,43L,47L,53L,59L,61L,71L,79L,97L,101L,103L,107L,113L,137L,139L,149L,151L,157L,163L,167L,173L,179L,191L,193L,197L,223L,227L,229L,239L,257L,263L,269L,277L,283L,293L,311L,313L,317L,337L,347L,349L,359L,367L,397L,401L,409L,419L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179679Inst : IEnumerable<long>
{
public static readonly long[] Value=A179679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179679.Bytes);
public long this[int i]=>Value[i];

public static A179679Inst Instance=new A179679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179680
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,3L,1L,1L,5L,1L,3L,5L,5L,7L,1L,1L,3L,9L,3L,3L,3L,3L,6L,5L,2L,13L,5L,3L,15L,15L,1L,1L,17L,5L,9L,1L,5L,7L,10L,13L,21L,1L,7L,2L,3L,2L,9L,11L,9L,25L,13L,2L,27L,9L,9L,5L,11L,2L,6L,27L,5L,25L,1L,1L,33L,3L,9L,15L,35L,11L,15L,3L,11L,37L,3L,6L,5L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179680Inst : IEnumerable<long>
{
public static readonly long[] Value=A179680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179680.Bytes);
public long this[int i]=>Value[i];

public static A179680Inst Instance=new A179680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179681
{
public static readonly long[] Value={ 8L,21L,36L,55L,78L,119L,171L,190L,210L,253L,300L,377L,465L,496L,528L,595L,666L,779L,903L,946L,990L,1173L,1378L,1431L,1485L,1540L,1596L,1711L,1830L,2077L,2346L,2415L,2485L,2556L,2628L,2849L,3081L,3160L,3240L,3403L,3570L,3827L,4095L,4186L,4278L,4653L,5050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179681Inst : IEnumerable<long>
{
public static readonly long[] Value=A179681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179681.Bytes);
public long this[int i]=>Value[i];

public static A179681Inst Instance=new A179681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179682
{
public static readonly long[] Value={ 1L,8L,24L,48L,80L,120L,168L,224L,49L,360L,440L,528L,624L,728L,840L,960L,1088L,1224L,1368L,1520L,1680L,1848L,2024L,2208L,242L,2600L,2808L,3024L,3248L,3480L,3720L,3968L,4224L,4488L,4760L,5040L,5328L,5624L,5928L,6240L,6560L,6888L,7224L,7568L,7920L,8280L,8648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179682Inst : IEnumerable<long>
{
public static readonly long[] Value=A179682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179682.Bytes);
public long this[int i]=>Value[i];

public static A179682Inst Instance=new A179682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179683
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1L,5L,16L,80L,436L,2877L,21828L,189877L,1865175L,20468437L,248376198L,3303397123L,47785692843L,746841034620L,12538089887528L,224955746518560L,4294093811333388L,86859002770470072L,1855099612560598420L,BigInteger.Parse("41698660497526383757") };
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
public class A179683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179683Inst Instance=new A179683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179684
{
public static readonly long[] Value={ 1L,0L,1L,1L,5L,17L,90L,542L,3962L,33554L,324489L,3520885L,42300709L,556530474L,7945317484L,122145525208L,2008827010000L,35143981009968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179684Inst : IEnumerable<long>
{
public static readonly long[] Value=A179684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179684.Bytes);
public long this[int i]=>Value[i];

public static A179684Inst Instance=new A179684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179685
{
public static readonly long[] Value={ 1L,0L,1L,1L,5L,16L,80L,436L,2891L,22248L,198774L,2029140L,23310386L,296407466L,4109654354L,61348443380L,976111067870L,16423368282336L,290404344321126L,5370042566624118L,103427555919931446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179685Inst : IEnumerable<long>
{
public static readonly long[] Value=A179685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179685.Bytes);
public long this[int i]=>Value[i];

public static A179685Inst Instance=new A179685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179686
{
public static readonly long[] Value={ 1L,2L,4L,2L,2L,2L,4L,2L,6L,4L,4L,6L,8L,6L,4L,2L,4L,10L,4L,6L,2L,4L,12L,12L,4L,14L,12L,2L,14L,14L,4L,2L,18L,12L,16L,4L,8L,16L,16L,14L,18L,4L,12L,4L,4L,4L,20L,10L,6L,22L,24L,4L,26L,6L,16L,6L,20L,4L,12L,26L,8L,22L,4L,2L,34L,8L,20L,14L,34L,24L,32L,6L,20L,42L,4L,12L,8L,10L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179686Inst : IEnumerable<long>
{
public static readonly long[] Value=A179686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179686.Bytes);
public long this[int i]=>Value[i];

public static A179686Inst Instance=new A179686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179687
{
public static readonly long[] Value={ 3L,5L,7L,19L,27L,37L,47L,53L,67L,95L,101L,103L,107L,131L,149L,173L,181L,191L,227L,239L,263L,293L,311L,317L,349L,359L,367L,373L,383L,419L,461L,463L,479L,509L,547L,557L,587L,613L,619L,647L,653L,677L,701L,743L,751L,773L,787L,821L,841L,863L,887L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179687Inst : IEnumerable<long>
{
public static readonly long[] Value=A179687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179687.Bytes);
public long this[int i]=>Value[i];

public static A179687Inst Instance=new A179687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179688
{
public static readonly long[] Value={ 1080L,1512L,2376L,2808L,3000L,3672L,4104L,4968L,6264L,6696L,6750L,7000L,7992L,8232L,8856L,9288L,10152L,11000L,11448L,12744L,13000L,13176L,13720L,14472L,15336L,15768L,17000L,17064L,17928L,18522L,19000L,19224L,20952L,21816L,22248L,23000L,23112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179688Inst : IEnumerable<long>
{
public static readonly long[] Value=A179688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179688.Bytes);
public long this[int i]=>Value[i];

public static A179688Inst Instance=new A179688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179689
{
public static readonly long[] Value={ 1152L,3200L,6272L,8748L,15488L,21632L,36992L,46208L,54675L,67712L,107163L,107648L,123008L,175232L,215168L,236672L,264627L,282752L,312500L,359552L,369603L,445568L,476288L,574592L,632043L,645248L,682112L,703125L,789507L,798848L,881792L,1013888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179689Inst : IEnumerable<long>
{
public static readonly long[] Value=A179689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179689.Bytes);
public long this[int i]=>Value[i];

public static A179689Inst Instance=new A179689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179690
{
public static readonly long[] Value={ 1260L,1980L,2100L,2340L,2772L,2940L,3060L,3150L,3276L,3300L,3420L,3900L,4140L,4284L,4410L,4788L,4950L,5100L,5148L,5220L,5580L,5700L,5796L,5850L,6468L,6660L,6732L,6900L,7260L,7308L,7350L,7380L,7524L,7644L,7650L,7700L,7740L,7812L,7956L,8460L,8550L,8700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179690Inst : IEnumerable<long>
{
public static readonly long[] Value=A179690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179690.Bytes);
public long this[int i]=>Value[i];

public static A179690Inst Instance=new A179690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179691
{
public static readonly long[] Value={ 1440L,2016L,2400L,3168L,3744L,4704L,4860L,4896L,5472L,5600L,6624L,6804L,7840L,8352L,8800L,8928L,10400L,10656L,10692L,11616L,11808L,12150L,12384L,12636L,13536L,13600L,15200L,15264L,16224L,16524L,16992L,17248L,17568L,18400L,18468L,19296L,19360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179691Inst : IEnumerable<long>
{
public static readonly long[] Value=A179691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179691.Bytes);
public long this[int i]=>Value[i];

public static A179691Inst Instance=new A179691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179692
{
public static readonly long[] Value={ 1536L,2560L,3584L,5632L,6656L,8704L,9728L,11776L,14848L,15872L,18944L,20992L,22016L,24064L,27136L,30208L,31232L,34304L,36352L,37376L,39366L,40448L,42496L,45568L,49664L,51712L,52736L,54784L,55808L,57856L,65024L,67072L,70144L,71168L,76288L,77312L,80384L,83456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179692Inst : IEnumerable<long>
{
public static readonly long[] Value=A179692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179692.Bytes);
public long this[int i]=>Value[i];

public static A179692Inst Instance=new A179692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179693
{
public static readonly long[] Value={ 1680L,2640L,3120L,3696L,4080L,4368L,4560L,5520L,5670L,5712L,6160L,6384L,6864L,6960L,7280L,7440L,7728L,8880L,8910L,8976L,9520L,9744L,9840L,10032L,10320L,10416L,10530L,10608L,10640L,11280L,11440L,11856L,12144L,12432L,12474L,12720L,12880L,13770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179693Inst : IEnumerable<long>
{
public static readonly long[] Value=A179693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179693.Bytes);
public long this[int i]=>Value[i];

public static A179693Inst Instance=new A179693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179694
{
public static readonly long[] Value={ 1728L,5832L,8000L,21952L,85184L,91125L,125000L,140608L,250047L,314432L,421875L,438976L,778688L,941192L,970299L,1560896L,1601613L,1906624L,3176523L,3241792L,3581577L,4410944L,5000211L,5088448L,5359375L,6644672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179694Inst : IEnumerable<long>
{
public static readonly long[] Value=A179694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179694.Bytes);
public long this[int i]=>Value[i];

public static A179694Inst Instance=new A179694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179695
{
public static readonly long[] Value={ 1800L,2700L,3528L,4500L,5292L,8712L,9800L,12168L,12348L,13068L,18252L,20808L,24200L,24500L,25992L,31212L,33075L,33800L,34300L,38088L,38988L,47432L,47916L,55125L,57132L,57800L,60500L,60552L,66248L,69192L,72200L,77175L,79092L,81675L,84500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179695Inst : IEnumerable<long>
{
public static readonly long[] Value=A179695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179695.Bytes);
public long this[int i]=>Value[i];

public static A179695Inst Instance=new A179695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179696
{
public static readonly long[] Value={ 1920L,2688L,4224L,4480L,4992L,6528L,7040L,7296L,8320L,8832L,9856L,10880L,11136L,11648L,11904L,12160L,14208L,14720L,15232L,15744L,16512L,17024L,18048L,18304L,18560L,19840L,20352L,20608L,21870L,22656L,23424L,23680L,23936L,25728L,25984L,26240L,26752L,27264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179696Inst : IEnumerable<long>
{
public static readonly long[] Value=A179696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179696.Bytes);
public long this[int i]=>Value[i];

public static A179696Inst Instance=new A179696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179697
{
public static readonly long[] Value={ 90L,186L,378L,762L,1530L,3066L,6138L,12282L,23130L,24570L,46170L,49146L,92250L,95418L,98298L,184410L,190650L,196602L,368730L,381114L,387450L,393210L,737370L,762042L,774522L,786426L,1474650L,1523898L,1548666L,1561338L,1572858L,2949210L,3047610L,3096954L,3121914L,3145722L,5898330L,5921370L,6095034L,6193530L,6243066L,6268410L,6291450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179697Inst : IEnumerable<long>
{
public static readonly long[] Value=A179697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179697.Bytes);
public long this[int i]=>Value[i];

public static A179697Inst Instance=new A179697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179698
{
public static readonly long[] Value={ 2160L,3024L,3240L,4536L,4752L,5616L,6000L,7128L,7344L,8208L,8424L,9936L,11016L,12312L,12528L,13392L,14000L,14904L,15000L,15984L,16464L,17712L,18576L,18792L,20088L,20250L,20304L,22000L,22896L,23976L,25488L,26000L,26352L,26568L,27440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179698Inst : IEnumerable<long>
{
public static readonly long[] Value=A179698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179698.Bytes);
public long this[int i]=>Value[i];

public static A179698Inst Instance=new A179698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179699
{
public static readonly long[] Value={ 2304L,6400L,12544L,26244L,30976L,43264L,73984L,92416L,135424L,164025L,215296L,246016L,321489L,350464L,430336L,473344L,565504L,719104L,793881L,891136L,952576L,1108809L,1149184L,1290496L,1364224L,1562500L,1597696L,1763584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179699Inst : IEnumerable<long>
{
public static readonly long[] Value=A179699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179699.Bytes);
public long this[int i]=>Value[i];

public static A179699Inst Instance=new A179699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179700
{
public static readonly long[] Value={ 2520L,3780L,3960L,4200L,4680L,5544L,5880L,5940L,6120L,6552L,6600L,6840L,7020L,7800L,8280L,8316L,8568L,9180L,9450L,9576L,9828L,10200L,10260L,10296L,10440L,10500L,11160L,11400L,11592L,12420L,12852L,12936L,13230L,13320L,13464L,13800L,14364L,14520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179700Inst : IEnumerable<long>
{
public static readonly long[] Value=A179700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179700.Bytes);
public long this[int i]=>Value[i];

public static A179700Inst Instance=new A179700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179701
{
public static readonly long[] Value={ 3L,1L,1L,1L,6L,9L,8L,4L,4L,7L,1L,9L,8L,4L,2L,1L,6L,3L,7L,9L,4L,7L,8L,0L,6L,9L,4L,8L,3L,2L,4L,4L,0L,3L,6L,1L,6L,7L,0L,5L,3L,3L,8L,6L,8L,1L,7L,5L,1L,1L,0L,3L,4L,7L,1L,5L,2L,7L,7L,1L,8L,0L,3L,4L,0L,6L,4L,1L,6L,1L,5L,0L,6L,0L,1L,3L,2L,2L,4L,2L,9L,5L,5L,2L,8L,0L,9L,8L,9L,9L,1L,2L,3L,4L,2L,1L,5L,4L,3L,2L,6L,9L,9L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179701Inst : IEnumerable<long>
{
public static readonly long[] Value=A179701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179701.Bytes);
public long this[int i]=>Value[i];

public static A179701Inst Instance=new A179701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179702
{
public static readonly long[] Value={ 2592L,3888L,20000L,50000L,76832L,151875L,253125L,268912L,468512L,583443L,913952L,1361367L,2576816L,2672672L,3557763L,4170272L,5940688L,6940323L,7503125L,8954912L,10504375L,13045131L,20295603L,22632992L,22717712L,29552672L,30074733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179702Inst : IEnumerable<long>
{
public static readonly long[] Value=A179702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179702.Bytes);
public long this[int i]=>Value[i];

public static A179702Inst Instance=new A179702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179703
{
public static readonly long[] Value={ 2880L,4032L,4800L,6336L,7488L,9408L,9792L,10944L,11200L,13248L,14580L,15680L,16704L,17600L,17856L,20412L,20800L,21312L,23232L,23616L,24768L,27072L,27200L,30400L,30528L,32076L,32448L,33984L,34496L,35136L,36450L,36800L,37908L,38592L,38720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179703Inst : IEnumerable<long>
{
public static readonly long[] Value=A179703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179703.Bytes);
public long this[int i]=>Value[i];

public static A179703Inst Instance=new A179703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179704
{
public static readonly long[] Value={ 3360L,5280L,6240L,7392L,8160L,8736L,9120L,11040L,11424L,12320L,12768L,13728L,13920L,14560L,14880L,15456L,17010L,17760L,17952L,19040L,19488L,19680L,20064L,20640L,20832L,21216L,21280L,22560L,22880L,23712L,24288L,24864L,25440L,25760L,26730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179704Inst : IEnumerable<long>
{
public static readonly long[] Value=A179704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179704.Bytes);
public long this[int i]=>Value[i];

public static A179704Inst Instance=new A179704Inst();

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