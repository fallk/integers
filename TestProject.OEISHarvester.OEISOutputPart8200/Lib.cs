using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142628
{
public static readonly long[] Value={ 313L,643L,863L,1193L,1303L,1523L,2293L,2843L,2953L,3613L,3833L,3943L,4273L,4493L,4603L,4933L,5153L,5483L,5813L,5923L,6143L,6473L,6803L,7243L,7573L,7793L,8123L,8233L,8563L,8783L,8893L,9883L,10103L,10433L,11093L,11423L,11863L,12413L,12743L,12853L,13183L,13513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142628Inst : IEnumerable<long>
{
public static readonly long[] Value=A142628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142628.Bytes);
public long this[int i]=>Value[i];

public static A142628Inst Instance=new A142628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142627
{
public static readonly long[] Value={ 37L,257L,367L,587L,1907L,2017L,2237L,2347L,2677L,2897L,3557L,4217L,4327L,4547L,4657L,4877L,4987L,5647L,5867L,6197L,6637L,6857L,6967L,7187L,7297L,7517L,8287L,8837L,9277L,9497L,10267L,10487L,10597L,11257L,11587L,11807L,12577L,12907L,13127L,13457L,13567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142627Inst : IEnumerable<long>
{
public static readonly long[] Value=A142627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142627.Bytes);
public long this[int i]=>Value[i];

public static A142627Inst Instance=new A142627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142626
{
public static readonly long[] Value={ 311L,421L,641L,751L,971L,1301L,1741L,2621L,2731L,3061L,3391L,4051L,4271L,4931L,5261L,5591L,5701L,6361L,6581L,6691L,6911L,7351L,7681L,7901L,8011L,8231L,9001L,9221L,9551L,9661L,10211L,10321L,10651L,11311L,11971L,12301L,13291L,13841L,14281L,14831L,15161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142626Inst : IEnumerable<long>
{
public static readonly long[] Value=A142626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142626.Bytes);
public long this[int i]=>Value[i];

public static A142626Inst Instance=new A142626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142625
{
public static readonly long[] Value={ 89L,199L,419L,859L,1409L,2069L,2179L,2399L,2729L,3169L,3389L,3499L,3719L,4049L,4159L,5039L,5479L,6029L,6359L,6469L,6689L,7019L,7129L,7349L,7459L,7789L,8009L,8669L,8779L,8999L,9109L,9439L,9769L,10099L,10429L,10979L,11969L,12409L,12739L,12959L,13399L,13619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142625Inst : IEnumerable<long>
{
public static readonly long[] Value=A142625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142625.Bytes);
public long this[int i]=>Value[i];

public static A142625Inst Instance=new A142625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142624
{
public static readonly long[] Value={ 197L,307L,857L,967L,1187L,1297L,1627L,1847L,2287L,2617L,2837L,3167L,3607L,4157L,4597L,4817L,5147L,5477L,5807L,6247L,6577L,6907L,7127L,7237L,7457L,8117L,8447L,8887L,9437L,9547L,9767L,10427L,10867L,11087L,11197L,11527L,12517L,13177L,13397L,14057L,14387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142624Inst : IEnumerable<long>
{
public static readonly long[] Value=A142624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142624.Bytes);
public long this[int i]=>Value[i];

public static A142624Inst Instance=new A142624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142623
{
public static readonly long[] Value={ 31L,251L,691L,911L,1021L,1571L,1901L,2011L,2341L,2671L,3001L,3221L,3331L,3881L,4211L,4651L,4871L,5531L,5641L,5861L,6301L,6521L,6961L,7621L,7841L,7951L,8171L,8501L,8831L,8941L,9161L,9491L,9601L,9931L,10151L,11251L,11471L,11801L,12241L,12791L,13121L,13451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142623Inst : IEnumerable<long>
{
public static readonly long[] Value=A142623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142623.Bytes);
public long this[int i]=>Value[i];

public static A142623Inst Instance=new A142623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142622
{
public static readonly long[] Value={ 29L,139L,359L,1019L,1129L,1459L,1789L,2339L,2999L,3109L,3329L,3659L,3769L,3989L,4099L,4649L,4759L,5309L,5419L,5639L,5749L,6079L,6299L,6959L,7069L,7949L,8059L,8389L,8609L,8719L,9049L,9929L,10039L,10259L,10369L,10589L,11579L,11689L,11909L,12239L,12569L,12899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142622Inst : IEnumerable<long>
{
public static readonly long[] Value=A142622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142622.Bytes);
public long this[int i]=>Value[i];

public static A142622Inst Instance=new A142622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142621
{
public static readonly long[] Value={ 83L,193L,523L,743L,853L,1733L,2063L,2393L,2503L,2833L,3163L,3823L,4153L,4373L,4483L,4703L,4813L,5693L,6133L,6353L,6793L,7013L,7673L,8443L,8663L,9103L,9323L,9433L,10093L,10313L,10753L,10973L,11083L,11633L,11743L,12073L,12953L,13063L,13613L,13723L,14713L,15263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142621Inst : IEnumerable<long>
{
public static readonly long[] Value=A142621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142621.Bytes);
public long this[int i]=>Value[i];

public static A142621Inst Instance=new A142621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142620
{
public static readonly long[] Value={ 137L,467L,577L,797L,907L,1237L,1567L,1787L,2447L,2557L,2777L,2887L,3217L,3547L,3767L,3877L,5087L,5197L,5417L,5527L,5857L,6737L,7177L,7507L,7727L,8167L,8387L,9157L,9377L,9817L,10037L,10477L,11027L,11467L,12347L,12457L,13007L,13337L,13997L,14107L,14327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142620Inst : IEnumerable<long>
{
public static readonly long[] Value=A142620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142620.Bytes);
public long this[int i]=>Value[i];

public static A142620Inst Instance=new A142620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142619
{
public static readonly long[] Value={ 191L,521L,631L,1181L,1291L,1511L,1621L,1951L,2281L,3271L,3491L,3821L,3931L,4261L,4481L,4591L,5471L,5581L,5801L,6131L,6571L,6791L,7121L,7451L,7561L,8111L,8221L,9431L,9871L,10091L,10531L,10861L,11411L,12071L,12401L,12511L,12841L,13171L,13721L,13831L,14051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142619Inst : IEnumerable<long>
{
public static readonly long[] Value=A142619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142619.Bytes);
public long this[int i]=>Value[i];

public static A142619Inst Instance=new A142619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142618
{
public static readonly long[] Value={ 79L,409L,739L,1069L,1289L,1399L,1619L,1949L,2389L,2609L,2719L,2939L,3049L,3709L,3929L,4259L,4919L,5689L,6569L,6679L,6899L,7229L,7559L,7669L,8219L,8329L,9209L,9319L,9539L,9649L,10529L,10639L,10859L,11299L,11519L,11959L,12289L,12619L,13499L,13829L,14159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142618Inst : IEnumerable<long>
{
public static readonly long[] Value=A142618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142618.Bytes);
public long this[int i]=>Value[i];

public static A142618Inst Instance=new A142618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142617
{
public static readonly long[] Value={ 23L,353L,463L,683L,1013L,1123L,1453L,1783L,2003L,2113L,2333L,2663L,3323L,3433L,4093L,4423L,4643L,4973L,5303L,5413L,5743L,6073L,6733L,7283L,7393L,7723L,8053L,8273L,8713L,8933L,9043L,9923L,10253L,11243L,11353L,11903L,12343L,12893L,13003L,13553L,13883L,14323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142617Inst : IEnumerable<long>
{
public static readonly long[] Value=A142617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142617.Bytes);
public long this[int i]=>Value[i];

public static A142617Inst Instance=new A142617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142616
{
public static readonly long[] Value={ 131L,241L,461L,571L,1231L,1451L,2111L,2221L,2441L,2551L,3541L,3761L,4091L,4201L,4421L,4751L,4861L,5081L,5521L,5741L,5851L,6841L,8161L,8821L,9041L,9151L,9371L,9811L,10141L,10691L,11131L,11351L,11681L,12011L,12451L,12671L,12781L,13001L,13331L,13441L,14321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142616Inst : IEnumerable<long>
{
public static readonly long[] Value=A142616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142616.Bytes);
public long this[int i]=>Value[i];

public static A142616Inst Instance=new A142616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142583
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,6L,41L,31L,6L,30L,931L,940L,301L,30L,210L,44347L,51971L,21227L,3571L,210L,2310L,5339027L,6762728L,3137268L,665308L,64681L,2310L,30030L,901841261L,1212061411L,618052532L,153213712L,19579601L,1231231L,30030L,510510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142583Inst : IEnumerable<long>
{
public static readonly long[] Value=A142583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142583.Bytes);
public long this[int i]=>Value[i];

public static A142583Inst Instance=new A142583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142582
{
public static readonly long[] Value={ 211L,317L,953L,1483L,1801L,1907L,2437L,2543L,2861L,3391L,3709L,4027L,4133L,4451L,4663L,5087L,6359L,6571L,7207L,7949L,8161L,9221L,9433L,9539L,9857L,10069L,11447L,12401L,12613L,13037L,13249L,13567L,14627L,15263L,15581L,16111L,16217L,16747L,17383L,17489L,17807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142582Inst : IEnumerable<long>
{
public static readonly long[] Value=A142582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142582.Bytes);
public long this[int i]=>Value[i];

public static A142582Inst Instance=new A142582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142581
{
public static readonly long[] Value={ 157L,263L,1217L,1429L,1747L,2383L,3019L,3761L,4079L,4397L,5351L,5563L,5669L,5881L,5987L,6199L,7577L,7789L,8849L,9697L,9803L,10333L,10651L,11287L,11393L,11923L,12241L,12347L,12983L,13513L,13619L,13831L,14149L,14891L,15527L,15739L,16057L,16481L,16693L,17011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142581Inst : IEnumerable<long>
{
public static readonly long[] Value=A142581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142581.Bytes);
public long this[int i]=>Value[i];

public static A142581Inst Instance=new A142581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142580
{
public static readonly long[] Value={ 103L,421L,739L,1163L,1481L,1693L,2011L,2647L,2753L,3389L,3919L,5297L,5827L,6569L,6781L,7417L,7523L,7841L,8053L,8689L,9007L,9431L,9643L,9749L,10067L,10597L,11551L,11657L,12611L,12823L,13883L,14519L,14731L,15473L,15791L,16427L,17911L,18229L,19183L,19289L,19501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142580Inst : IEnumerable<long>
{
public static readonly long[] Value=A142580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142580.Bytes);
public long this[int i]=>Value[i];

public static A142580Inst Instance=new A142580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142579
{
public static readonly long[] Value={ 367L,1109L,1321L,1427L,2063L,2381L,2593L,2699L,3229L,3547L,4289L,5879L,6091L,6197L,6833L,7151L,7681L,8317L,8423L,8741L,9059L,9377L,9907L,10331L,10861L,11497L,12239L,12451L,13723L,13829L,14783L,15101L,15313L,15737L,16267L,16691L,16903L,17327L,17539L,18493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142579Inst : IEnumerable<long>
{
public static readonly long[] Value=A142579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142579.Bytes);
public long this[int i]=>Value[i];

public static A142579Inst Instance=new A142579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142578
{
public static readonly long[] Value={ 101L,313L,419L,631L,1373L,2221L,2539L,2857L,2963L,3917L,4129L,4447L,4871L,5189L,5507L,6037L,6143L,6673L,6779L,6991L,7309L,8263L,8369L,8581L,9323L,11443L,11549L,11867L,12503L,12821L,13033L,13457L,13669L,14411L,15259L,15683L,16001L,16319L,17167L,17909L,18121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142578Inst : IEnumerable<long>
{
public static readonly long[] Value=A142578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142578.Bytes);
public long this[int i]=>Value[i];

public static A142578Inst Instance=new A142578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142577
{
public static readonly long[] Value={ 47L,577L,683L,1213L,1319L,1531L,1637L,2273L,2591L,2803L,2909L,3121L,3863L,4817L,5347L,6089L,6301L,6619L,7043L,7573L,8209L,8527L,8951L,9587L,10223L,10753L,10859L,11071L,11177L,11813L,12343L,12979L,13297L,13721L,13933L,14251L,14887L,15629L,16477L,16901L,17431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142577Inst : IEnumerable<long>
{
public static readonly long[] Value=A142577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142577.Bytes);
public long this[int i]=>Value[i];

public static A142577Inst Instance=new A142577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142576
{
public static readonly long[] Value={ 311L,523L,947L,1583L,1901L,2113L,2749L,3067L,3491L,4021L,4127L,4339L,4657L,5081L,5399L,5717L,6247L,6353L,6883L,7307L,9109L,9533L,9851L,10169L,10487L,11971L,12289L,12713L,13879L,14197L,14303L,14621L,14939L,15787L,16529L,16741L,17377L,17483L,18013L,18119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142576Inst : IEnumerable<long>
{
public static readonly long[] Value=A142576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142576.Bytes);
public long this[int i]=>Value[i];

public static A142576Inst Instance=new A142576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142575
{
public static readonly long[] Value={ 151L,257L,787L,1423L,1741L,1847L,2377L,2801L,3119L,3331L,3967L,4073L,4391L,4603L,5557L,5981L,6299L,6829L,7253L,8101L,8419L,8737L,9161L,9479L,10009L,10433L,11069L,12553L,12659L,13613L,13931L,14143L,14249L,14461L,14779L,15733L,16369L,17747L,17959L,18701L,18913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142575Inst : IEnumerable<long>
{
public static readonly long[] Value=A142575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142575.Bytes);
public long this[int i]=>Value[i];

public static A142575Inst Instance=new A142575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142574
{
public static readonly long[] Value={ 97L,521L,733L,839L,1051L,2111L,3701L,4019L,4231L,4337L,4549L,4973L,5503L,5821L,5927L,6563L,7411L,7517L,9001L,9319L,9743L,10061L,10273L,10909L,11863L,11969L,12923L,13241L,13877L,14407L,14831L,15149L,15361L,15467L,15679L,16103L,16421L,16633L,18223L,18329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142574Inst : IEnumerable<long>
{
public static readonly long[] Value=A142574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142574.Bytes);
public long this[int i]=>Value[i];

public static A142574Inst Instance=new A142574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142573
{
public static readonly long[] Value={ 43L,149L,467L,997L,1103L,1951L,2269L,2693L,3011L,3329L,3541L,4177L,4283L,4813L,4919L,5237L,5449L,6827L,7039L,7993L,8311L,8629L,9371L,9689L,9901L,10007L,11173L,11279L,11491L,11597L,12763L,13187L,13399L,15307L,15413L,15731L,17321L,17851L,17957L,18169L,18593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142573Inst : IEnumerable<long>
{
public static readonly long[] Value=A142573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142573.Bytes);
public long this[int i]=>Value[i];

public static A142573Inst Instance=new A142573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142572
{
public static readonly long[] Value={ 307L,1049L,1367L,1579L,2003L,2851L,2957L,3169L,3593L,3911L,4229L,4441L,4547L,4759L,5077L,5501L,7621L,7727L,8363L,8681L,8893L,8999L,10271L,10589L,11119L,11437L,12073L,12391L,12497L,13451L,14087L,14723L,15359L,15889L,16631L,16843L,17903L,18433L,18539L,19069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142572Inst : IEnumerable<long>
{
public static readonly long[] Value=A142572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142572.Bytes);
public long this[int i]=>Value[i];

public static A142572Inst Instance=new A142572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142571
{
public static readonly long[] Value={ 41L,359L,571L,677L,1949L,2161L,2267L,2797L,2903L,3221L,3433L,3539L,4493L,5023L,5659L,6719L,7673L,8521L,8627L,8839L,9157L,10111L,10429L,10853L,11171L,11383L,11489L,11701L,11807L,12973L,13291L,13397L,14033L,14563L,14669L,15199L,17107L,18061L,18379L,18803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142571Inst : IEnumerable<long>
{
public static readonly long[] Value=A142571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142571.Bytes);
public long this[int i]=>Value[i];

public static A142571Inst Instance=new A142571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142570
{
public static readonly long[] Value={ 199L,941L,1153L,1259L,1471L,1789L,2213L,2531L,3061L,3167L,3697L,3803L,4651L,4969L,5393L,5711L,5923L,6029L,6983L,7937L,8467L,8573L,9103L,9209L,9421L,9739L,10163L,10799L,11117L,11329L,12071L,12601L,12919L,13873L,14827L,15569L,15887L,16417L,17053L,17159L,17477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142570Inst : IEnumerable<long>
{
public static readonly long[] Value=A142570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142570.Bytes);
public long this[int i]=>Value[i];

public static A142570Inst Instance=new A142570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142569
{
public static readonly long[] Value={ 251L,463L,569L,887L,1523L,2053L,2371L,2477L,2689L,3643L,4597L,4703L,5021L,5233L,5657L,5869L,6823L,7247L,7459L,7883L,8731L,8837L,9049L,9473L,9791L,10321L,10427L,10639L,10957L,11593L,11699L,12547L,12653L,13183L,14243L,14561L,14879L,15091L,15727L,16363L,16787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142569Inst : IEnumerable<long>
{
public static readonly long[] Value=A142569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142569.Bytes);
public long this[int i]=>Value[i];

public static A142569Inst Instance=new A142569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142568
{
public static readonly long[] Value={ 197L,409L,727L,1151L,1787L,1999L,2423L,2741L,2953L,3271L,3907L,4013L,4649L,4861L,4967L,5179L,6133L,6451L,7193L,7723L,7829L,8147L,8677L,8783L,9419L,9631L,9949L,10267L,10691L,10903L,12281L,12917L,13553L,14083L,14401L,15461L,15991L,16097L,17581L,18217L,18959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142568Inst : IEnumerable<long>
{
public static readonly long[] Value=A142568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142568.Bytes);
public long this[int i]=>Value[i];

public static A142568Inst Instance=new A142568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142551
{
public static readonly long[] Value={ 127L,233L,1187L,1399L,1823L,2141L,2459L,2671L,2777L,3307L,3413L,3943L,4049L,4261L,5003L,5639L,5851L,6911L,7229L,7547L,7759L,8501L,8713L,8819L,9137L,9349L,10091L,10303L,10939L,11257L,11681L,12211L,12953L,13907L,14437L,14543L,15073L,15391L,15497L,16451L,16981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142551Inst : IEnumerable<long>
{
public static readonly long[] Value=A142551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142551.Bytes);
public long this[int i]=>Value[i];

public static A142551Inst Instance=new A142551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142550
{
public static readonly long[] Value={ 73L,179L,709L,1451L,1663L,2087L,2617L,3041L,3253L,3359L,3571L,3677L,3889L,5479L,5903L,6221L,6857L,7069L,8447L,9613L,9719L,9931L,10037L,10567L,11839L,12157L,12263L,12899L,13217L,14489L,15443L,15761L,15973L,16927L,17033L,17351L,17669L,17881L,17987L,18199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142550Inst : IEnumerable<long>
{
public static readonly long[] Value=A142550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142550.Bytes);
public long this[int i]=>Value[i];

public static A142550Inst Instance=new A142550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142549
{
public static readonly long[] Value={ 19L,337L,443L,761L,1291L,1609L,2351L,3517L,3623L,4153L,4259L,4789L,5107L,5531L,5743L,5849L,6379L,6803L,7121L,7333L,7757L,8287L,8923L,9029L,9241L,10301L,10513L,10831L,10937L,11149L,11467L,12421L,12527L,12739L,13163L,13693L,13799L,14011L,14753L,15601L,15919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142549Inst : IEnumerable<long>
{
public static readonly long[] Value=A142549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142549.Bytes);
public long this[int i]=>Value[i];

public static A142549Inst Instance=new A142549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142548
{
public static readonly long[] Value={ 71L,283L,389L,601L,919L,1237L,1873L,1979L,2297L,3251L,3463L,4099L,4523L,5477L,5689L,6007L,6113L,6961L,7703L,8233L,9187L,9293L,9929L,10141L,10247L,10459L,10883L,11519L,11731L,12049L,12473L,12791L,13003L,13109L,14593L,14699L,15017L,15971L,16183L,16607L,17137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142548Inst : IEnumerable<long>
{
public static readonly long[] Value=A142548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142548.Bytes);
public long this[int i]=>Value[i];

public static A142548Inst Instance=new A142548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142547
{
public static readonly long[] Value={ 17L,229L,547L,653L,971L,1289L,1607L,2137L,2243L,2879L,3727L,3833L,4363L,4787L,4999L,5741L,5953L,6271L,6907L,7013L,7331L,7649L,8179L,9133L,9239L,9769L,10193L,10723L,11677L,11783L,12101L,13267L,13691L,13903L,14009L,14221L,14327L,15493L,16447L,16553L,16871L,17189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142547Inst : IEnumerable<long>
{
public static readonly long[] Value=A142547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142547.Bytes);
public long this[int i]=>Value[i];

public static A142547Inst Instance=new A142547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142546
{
public static readonly long[] Value={ 281L,599L,811L,1129L,1447L,1553L,1871L,2083L,2719L,3037L,3461L,3673L,3779L,4733L,5051L,5581L,6217L,6323L,6959L,7489L,8231L,8443L,8761L,8867L,9397L,10139L,10457L,10987L,11093L,11411L,11941L,12577L,13001L,14591L,15121L,15227L,15439L,17029L,18089L,18301L,19891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142546Inst : IEnumerable<long>
{
public static readonly long[] Value=A142546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142546.Bytes);
public long this[int i]=>Value[i];

public static A142546Inst Instance=new A142546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142545
{
public static readonly long[] Value={ 227L,439L,757L,863L,1181L,1499L,2029L,2347L,3089L,3301L,3407L,4679L,5209L,5527L,6163L,6269L,6481L,7541L,7753L,8389L,8707L,9343L,9661L,9767L,11251L,11887L,12841L,13159L,13477L,13901L,14431L,14537L,15173L,15809L,16127L,16339L,16657L,16763L,17293L,17929L,18353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142545Inst : IEnumerable<long>
{
public static readonly long[] Value=A142545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142545.Bytes);
public long this[int i]=>Value[i];

public static A142545Inst Instance=new A142545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142544
{
public static readonly long[] Value={ 67L,173L,491L,809L,1021L,1657L,2081L,2293L,2399L,3671L,3989L,4201L,4519L,4943L,5261L,5791L,5897L,6427L,7487L,7699L,8017L,8123L,8971L,10243L,10667L,11197L,11621L,11833L,11939L,12893L,15013L,15331L,15649L,16073L,16603L,16921L,17027L,17239L,17981L,18617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142544Inst : IEnumerable<long>
{
public static readonly long[] Value=A142544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142544.Bytes);
public long this[int i]=>Value[i];

public static A142544Inst Instance=new A142544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142543
{
public static readonly long[] Value={ 13L,331L,967L,1709L,2027L,2239L,2557L,2663L,3299L,3511L,3617L,4253L,4783L,4889L,5101L,5419L,5737L,5843L,6373L,6691L,7433L,7963L,8069L,8387L,8599L,9341L,9871L,10613L,11779L,12097L,12203L,13687L,14323L,14747L,15277L,15383L,15913L,16231L,17291L,17609L,18457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142543Inst : IEnumerable<long>
{
public static readonly long[] Value=A142543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142543.Bytes);
public long this[int i]=>Value[i];

public static A142543Inst Instance=new A142543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142542
{
public static readonly long[] Value={ 277L,383L,701L,1019L,1231L,1549L,1867L,1973L,2503L,2609L,2927L,3457L,3881L,4093L,4517L,4729L,5153L,5471L,5683L,6637L,7591L,8863L,8969L,9181L,9817L,9923L,10453L,10559L,10771L,11831L,12043L,12149L,13103L,13421L,13633L,14057L,15329L,15541L,15647L,15859L,17449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142542Inst : IEnumerable<long>
{
public static readonly long[] Value=A142542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142542.Bytes);
public long this[int i]=>Value[i];

public static A142542Inst Instance=new A142542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142541
{
public static readonly long[] Value={ 11L,223L,541L,647L,859L,1283L,1601L,2131L,2237L,2767L,3191L,4357L,4463L,4993L,5099L,5417L,6053L,6689L,7219L,7537L,7643L,8597L,9127L,9551L,10399L,11353L,11777L,12413L,13049L,13367L,14321L,14533L,14639L,14851L,14957L,16229L,16547L,16759L,17077L,17183L,17713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142541Inst : IEnumerable<long>
{
public static readonly long[] Value=A142541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142541.Bytes);
public long this[int i]=>Value[i];

public static A142541Inst Instance=new A142541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142540
{
public static readonly long[] Value={ 487L,593L,911L,1123L,1229L,1759L,2713L,2819L,3137L,4091L,4409L,4621L,6211L,6317L,6529L,7589L,7907L,8543L,8861L,9391L,9497L,10133L,10663L,11087L,11299L,11617L,12041L,12253L,12889L,13313L,14479L,14797L,16069L,16493L,16811L,17341L,17659L,17977L,18401L,18719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142540Inst : IEnumerable<long>
{
public static readonly long[] Value=A142540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142540.Bytes);
public long this[int i]=>Value[i];

public static A142540Inst Instance=new A142540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142539
{
public static readonly long[] Value={ 433L,751L,857L,1069L,1493L,1811L,2129L,2341L,2447L,2659L,3083L,3613L,3719L,3931L,4567L,4673L,5309L,5521L,5839L,6263L,6581L,6793L,6899L,7853L,8171L,8807L,9337L,9973L,10079L,11351L,11987L,12517L,12941L,13259L,13577L,13789L,14107L,15061L,15803L,16333L,16651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142539Inst : IEnumerable<long>
{
public static readonly long[] Value=A142539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142539.Bytes);
public long this[int i]=>Value[i];

public static A142539Inst Instance=new A142539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142538
{
public static readonly long[] Value={ 61L,167L,379L,1439L,2287L,2393L,2711L,3347L,3559L,3877L,4513L,4831L,4937L,5573L,6421L,7057L,7481L,8011L,8117L,8329L,8647L,8753L,9283L,9601L,10343L,10979L,11827L,11933L,12251L,12569L,12781L,13099L,13417L,13523L,13841L,14159L,15643L,15749L,16067L,16703L,17021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142538Inst : IEnumerable<long>
{
public static readonly long[] Value=A142538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142538.Bytes);
public long this[int i]=>Value[i];

public static A142538Inst Instance=new A142538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142537
{
public static readonly long[] Value={ 7L,113L,431L,643L,1279L,1597L,2339L,2551L,2657L,3187L,3823L,3929L,5413L,5519L,6367L,6473L,6791L,7109L,7321L,7639L,8699L,9547L,10289L,10501L,10607L,11243L,12197L,12409L,13151L,13469L,13681L,13999L,14423L,14741L,15271L,15377L,15907L,16649L,17497L,17921L,18133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142537Inst : IEnumerable<long>
{
public static readonly long[] Value=A142537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142537.Bytes);
public long this[int i]=>Value[i];

public static A142537Inst Instance=new A142537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142536
{
public static readonly long[] Value={ 59L,271L,907L,1013L,1543L,1861L,2179L,3557L,3769L,4723L,5147L,5783L,6101L,6737L,6949L,7691L,8009L,8221L,8539L,8963L,9281L,9811L,11083L,11719L,12037L,12143L,13309L,13627L,14051L,14369L,15217L,15641L,15959L,17231L,17443L,17761L,18397L,18503L,19139L,19457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142536Inst : IEnumerable<long>
{
public static readonly long[] Value=A142536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142536.Bytes);
public long this[int i]=>Value[i];

public static A142536Inst Instance=new A142536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142503
{
public static readonly long[] Value={ 197L,401L,503L,809L,911L,1013L,1217L,1319L,1523L,1931L,2237L,2339L,2441L,2543L,3257L,3359L,3461L,3767L,4073L,4481L,4583L,4787L,4889L,5297L,5399L,5501L,5807L,6011L,6113L,6317L,6521L,6827L,7541L,7643L,7949L,8663L,8867L,8969L,9173L,9377L,9479L,9887L,10091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142503Inst : IEnumerable<long>
{
public static readonly long[] Value=A142503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142503.Bytes);
public long this[int i]=>Value[i];

public static A142503Inst Instance=new A142503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142502
{
public static readonly long[] Value={ 43L,349L,757L,859L,1063L,1471L,1777L,1879L,2083L,2287L,2389L,2593L,2797L,3001L,3307L,3511L,3613L,3919L,4021L,4327L,5347L,5449L,5653L,5857L,6163L,6367L,6469L,6571L,6673L,7489L,7591L,8101L,8713L,9631L,9733L,10039L,10141L,10243L,10651L,10753L,10957L,11059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142502Inst : IEnumerable<long>
{
public static readonly long[] Value=A142502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142502.Bytes);
public long this[int i]=>Value[i];

public static A142502Inst Instance=new A142502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142501
{
public static readonly long[] Value={ 41L,347L,449L,653L,857L,1061L,1163L,1367L,1571L,1877L,1979L,2081L,2591L,2693L,2897L,2999L,3203L,3407L,3917L,4019L,4733L,4937L,5039L,5651L,6263L,6569L,6977L,7079L,7283L,7487L,7589L,7691L,7793L,8609L,9221L,9323L,9629L,9833L,10037L,10139L,10343L,10853L,11057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142501Inst : IEnumerable<long>
{
public static readonly long[] Value=A142501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142501.Bytes);
public long this[int i]=>Value[i];

public static A142501Inst Instance=new A142501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142500
{
public static readonly long[] Value={ 193L,397L,499L,601L,907L,1009L,1213L,1621L,1723L,2029L,2131L,2437L,2539L,3049L,3253L,3457L,3559L,3967L,4273L,4783L,4987L,5701L,6007L,6211L,6619L,6823L,7027L,7129L,7333L,7537L,7639L,7741L,8353L,8761L,8863L,9067L,9679L,9781L,9883L,10597L,10903L,11311L,11617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142500Inst : IEnumerable<long>
{
public static readonly long[] Value=A142500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142500.Bytes);
public long this[int i]=>Value[i];

public static A142500Inst Instance=new A142500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142499
{
public static readonly long[] Value={ 89L,191L,293L,599L,701L,1109L,1619L,1721L,1823L,2027L,2129L,2333L,2741L,2843L,3251L,3557L,3659L,3761L,3863L,4271L,4373L,4679L,5087L,5189L,5393L,5801L,5903L,6311L,6719L,7127L,7229L,7331L,7433L,7841L,8147L,8861L,8963L,9371L,9473L,9677L,10289L,10391L,10799L,11003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142499Inst : IEnumerable<long>
{
public static readonly long[] Value=A142499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142499.Bytes);
public long this[int i]=>Value[i];

public static A142499Inst Instance=new A142499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142498
{
public static readonly long[] Value={ 37L,139L,241L,547L,751L,853L,1567L,1669L,1873L,2179L,2281L,2383L,2689L,2791L,3301L,3607L,3709L,4219L,4423L,4729L,4831L,4933L,5443L,5647L,5749L,5851L,5953L,6361L,6871L,7177L,7687L,7789L,7993L,8707L,9013L,9319L,9421L,9829L,9931L,11257L,11971L,12073L,12277L,12379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142498Inst : IEnumerable<long>
{
public static readonly long[] Value=A142498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142498.Bytes);
public long this[int i]=>Value[i];

public static A142498Inst Instance=new A142498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142497
{
public static readonly long[] Value={ 137L,239L,443L,647L,953L,1259L,1361L,1667L,1871L,1973L,2381L,2687L,2789L,3299L,3911L,4013L,4217L,4421L,4523L,4931L,5237L,5441L,5849L,6053L,6257L,6359L,6563L,6869L,6971L,7481L,7583L,8093L,8297L,8501L,8807L,9011L,9419L,9521L,9623L,9929L,10133L,10337L,10847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142497Inst : IEnumerable<long>
{
public static readonly long[] Value=A142497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142497.Bytes);
public long this[int i]=>Value[i];

public static A142497Inst Instance=new A142497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142496
{
public static readonly long[] Value={ 83L,389L,491L,593L,797L,1103L,1307L,1409L,1511L,1613L,2531L,2633L,2837L,2939L,3041L,3347L,3449L,4673L,4877L,5081L,5387L,5591L,5693L,5897L,6101L,6203L,6917L,7019L,7121L,7529L,7937L,8039L,8243L,8447L,8753L,9059L,9161L,9467L,10079L,10181L,10487L,10589L,10691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142496Inst : IEnumerable<long>
{
public static readonly long[] Value=A142496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142496.Bytes);
public long this[int i]=>Value[i];

public static A142496Inst Instance=new A142496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142495
{
public static readonly long[] Value={ 31L,337L,439L,541L,643L,1051L,1153L,1459L,1663L,1867L,2377L,2683L,2887L,3499L,3907L,4111L,4519L,4621L,4723L,5233L,5437L,5641L,5743L,6151L,6661L,6763L,6967L,7069L,7477L,7681L,8089L,8191L,8293L,8599L,8803L,9007L,9109L,9619L,9721L,10333L,10639L,11047L,11149L,11251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142495Inst : IEnumerable<long>
{
public static readonly long[] Value=A142495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142495.Bytes);
public long this[int i]=>Value[i];

public static A142495Inst Instance=new A142495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142494
{
public static readonly long[] Value={ 29L,131L,233L,641L,743L,947L,1049L,1151L,1559L,2069L,2273L,2477L,2579L,3089L,3191L,3701L,3803L,4007L,4211L,4517L,4721L,5231L,5333L,5639L,5741L,5843L,6047L,6353L,6659L,6761L,6863L,7577L,7883L,8087L,8291L,8597L,8699L,9209L,9311L,9413L,9719L,9923L,10331L,10433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142494Inst : IEnumerable<long>
{
public static readonly long[] Value=A142494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142494.Bytes);
public long this[int i]=>Value[i];

public static A142494Inst Instance=new A142494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142493
{
public static readonly long[] Value={ 79L,181L,283L,487L,691L,997L,1201L,1303L,1609L,2017L,2221L,2731L,2833L,3037L,3343L,3547L,3853L,4057L,4159L,4261L,4363L,4567L,5077L,5179L,5281L,5689L,5791L,6199L,6301L,6607L,6709L,7219L,7321L,7933L,8443L,8647L,9157L,9463L,9769L,9871L,9973L,10177L,10687L,10789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142493Inst : IEnumerable<long>
{
public static readonly long[] Value=A142493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142493.Bytes);
public long this[int i]=>Value[i];

public static A142493Inst Instance=new A142493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142492
{
public static readonly long[] Value={ 179L,281L,383L,587L,1097L,1301L,1607L,1709L,1811L,1913L,2423L,2729L,3137L,3851L,4157L,4259L,4463L,4871L,4973L,5279L,5381L,5483L,6197L,6299L,6911L,7013L,7523L,7727L,7829L,8237L,8543L,8747L,8849L,8951L,9257L,9461L,9767L,10889L,11093L,11399L,11807L,11909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142492Inst : IEnumerable<long>
{
public static readonly long[] Value=A142492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142492.Bytes);
public long this[int i]=>Value[i];

public static A142492Inst Instance=new A142492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142491
{
public static readonly long[] Value={ 127L,229L,331L,433L,739L,1249L,1453L,1657L,1759L,1861L,2269L,2371L,2473L,2677L,3187L,3391L,3697L,4003L,4513L,5023L,5227L,5431L,5737L,5839L,6043L,6247L,6451L,6553L,6961L,7369L,7573L,7879L,8287L,8389L,9001L,9103L,9511L,9613L,9817L,10429L,10531L,10837L,10939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142491Inst : IEnumerable<long>
{
public static readonly long[] Value=A142491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142491.Bytes);
public long this[int i]=>Value[i];

public static A142491Inst Instance=new A142491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142490
{
public static readonly long[] Value={ 23L,227L,431L,839L,941L,1451L,1553L,2063L,2267L,2777L,2879L,3083L,3389L,3491L,3593L,3797L,4001L,4409L,4817L,4919L,5021L,5531L,5939L,6143L,6449L,6551L,6653L,6857L,6959L,7673L,7877L,8081L,8387L,8693L,8999L,9203L,10223L,10427L,10529L,10631L,10733L,10937L,11243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142490Inst : IEnumerable<long>
{
public static readonly long[] Value=A142490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142490.Bytes);
public long this[int i]=>Value[i];

public static A142490Inst Instance=new A142490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142489
{
public static readonly long[] Value={ 73L,277L,379L,787L,991L,1093L,1297L,1399L,2011L,2113L,2521L,3541L,3643L,3847L,4051L,4153L,4357L,4561L,4663L,4969L,5479L,5581L,5683L,6091L,6397L,6703L,6907L,7213L,7417L,7621L,7723L,7927L,8233L,8539L,8641L,9049L,9151L,9661L,9967L,10069L,10273L,10477L,10987L,11497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142489Inst : IEnumerable<long>
{
public static readonly long[] Value=A142489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142489.Bytes);
public long this[int i]=>Value[i];

public static A142489Inst Instance=new A142489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142488
{
public static readonly long[] Value={ 71L,173L,479L,683L,887L,1091L,1193L,1499L,1601L,1907L,2111L,2213L,2417L,2621L,2927L,3539L,3947L,4049L,4253L,4457L,4967L,5171L,5273L,5477L,5783L,5987L,6089L,6599L,6701L,6803L,7109L,7211L,7517L,7823L,8231L,8537L,8741L,10067L,10169L,10271L,10781L,10883L,11087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142488Inst : IEnumerable<long>
{
public static readonly long[] Value=A142488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142488.Bytes);
public long this[int i]=>Value[i];

public static A142488Inst Instance=new A142488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142311
{
public static readonly long[] Value={ 43L,131L,263L,307L,439L,571L,659L,967L,1187L,1231L,1319L,1451L,1583L,1627L,1759L,1847L,1979L,2111L,2243L,2287L,2551L,2683L,2903L,3079L,3167L,3299L,3343L,3607L,3739L,4003L,4091L,4663L,4751L,5059L,5147L,5279L,5323L,5807L,5851L,5939L,6203L,6247L,6379L,6599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142311Inst : IEnumerable<long>
{
public static readonly long[] Value=A142311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142311.Bytes);
public long this[int i]=>Value[i];

public static A142311Inst Instance=new A142311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142310
{
public static readonly long[] Value={ 41L,173L,349L,569L,613L,701L,877L,1009L,1097L,1229L,1361L,1493L,1669L,1801L,1889L,1933L,2153L,2417L,2549L,2593L,2857L,3121L,3209L,3253L,3517L,4001L,4133L,4177L,4397L,4441L,4793L,4969L,5101L,5189L,5233L,5717L,5849L,5981L,6113L,6421L,6553L,6949L,7213L,7433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142310Inst : IEnumerable<long>
{
public static readonly long[] Value=A142310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142310.Bytes);
public long this[int i]=>Value[i];

public static A142310Inst Instance=new A142310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142309
{
public static readonly long[] Value={ 83L,127L,347L,479L,523L,743L,787L,919L,1051L,1447L,1579L,1667L,1931L,2063L,2239L,2371L,2459L,2503L,2591L,2767L,3119L,3163L,3251L,3559L,3691L,3779L,3823L,3911L,4219L,4483L,4703L,4967L,5011L,5099L,5231L,5407L,6067L,6199L,6287L,6551L,6947L,6991L,7079L,7211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142309Inst : IEnumerable<long>
{
public static readonly long[] Value=A142309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142309.Bytes);
public long this[int i]=>Value[i];

public static A142309Inst Instance=new A142309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142308
{
public static readonly long[] Value={ 37L,257L,389L,433L,521L,653L,829L,1049L,1093L,1181L,1489L,1621L,1709L,1753L,1973L,2017L,2237L,2281L,2633L,2677L,2897L,3469L,3557L,3733L,3821L,4129L,4217L,4261L,4349L,4481L,4657L,4789L,4877L,5009L,5273L,5449L,5581L,5669L,5801L,6197L,6329L,6373L,6637L,6857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142308Inst : IEnumerable<long>
{
public static readonly long[] Value=A142308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142308.Bytes);
public long this[int i]=>Value[i];

public static A142308Inst Instance=new A142308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142307
{
public static readonly long[] Value={ 79L,167L,211L,431L,563L,607L,739L,827L,1091L,1223L,1399L,1487L,1531L,1619L,1663L,2411L,2543L,2719L,2851L,2939L,3203L,3467L,3511L,3643L,3863L,3907L,4127L,4259L,4391L,4523L,4567L,4787L,4831L,4919L,5051L,5227L,5623L,5711L,5843L,6151L,6547L,6679L,6899L,7207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142307Inst : IEnumerable<long>
{
public static readonly long[] Value=A142307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142307.Bytes);
public long this[int i]=>Value[i];

public static A142307Inst Instance=new A142307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142306
{
public static readonly long[] Value={ 31L,163L,251L,383L,647L,691L,823L,911L,1087L,1307L,1439L,1483L,1571L,1747L,1879L,2011L,2099L,2143L,2539L,2671L,2803L,3023L,3067L,3331L,3463L,3727L,3947L,4079L,4211L,4519L,4651L,4783L,4871L,5003L,5179L,5399L,5443L,5531L,5839L,5927L,6323L,6367L,6719L,6763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142306Inst : IEnumerable<long>
{
public static readonly long[] Value=A142306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142306.Bytes);
public long this[int i]=>Value[i];

public static A142306Inst Instance=new A142306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142305
{
public static readonly long[] Value={ 29L,73L,293L,337L,557L,601L,733L,821L,953L,997L,1129L,1217L,1481L,1613L,1657L,1789L,1877L,2053L,2141L,2273L,2713L,2801L,3109L,3329L,3373L,3461L,3593L,3637L,3769L,3989L,4253L,4297L,4517L,4561L,4649L,4957L,5309L,5441L,5573L,5749L,5881L,6101L,6277L,6673L,6761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142305Inst : IEnumerable<long>
{
public static readonly long[] Value=A142305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142305.Bytes);
public long this[int i]=>Value[i];

public static A142305Inst Instance=new A142305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142304
{
public static readonly long[] Value={ 71L,379L,467L,599L,643L,863L,907L,1039L,1171L,1259L,1303L,1523L,1567L,1699L,1787L,1831L,2447L,2579L,2711L,2843L,2887L,3019L,3371L,3547L,3767L,3943L,4339L,4603L,4691L,4999L,5087L,5351L,5483L,5527L,5659L,5791L,5879L,5923L,6011L,6143L,6451L,6803L,7243L,7331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142304Inst : IEnumerable<long>
{
public static readonly long[] Value=A142304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142304.Bytes);
public long this[int i]=>Value[i];

public static A142304Inst Instance=new A142304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142303
{
public static readonly long[] Value={ 113L,157L,421L,509L,641L,773L,1213L,1301L,1433L,1609L,1697L,1741L,1873L,2137L,2269L,2357L,2621L,2753L,2797L,3061L,3413L,3457L,3677L,3853L,4073L,4337L,4513L,4733L,4909L,5261L,5393L,5437L,5569L,5657L,5701L,6053L,6229L,6317L,6361L,6449L,6581L,6977L,7109L,7417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142303Inst : IEnumerable<long>
{
public static readonly long[] Value=A142303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142303.Bytes);
public long this[int i]=>Value[i];

public static A142303Inst Instance=new A142303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142302
{
public static readonly long[] Value={ 23L,67L,199L,331L,419L,463L,683L,727L,859L,947L,991L,1123L,1607L,1783L,1871L,2003L,2179L,2267L,2311L,2399L,2531L,2663L,2707L,2927L,2971L,3191L,3323L,3499L,3631L,3719L,3851L,4027L,4159L,4423L,4643L,4951L,5039L,5171L,5303L,5347L,5479L,5743L,6007L,6271L,6359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142302Inst : IEnumerable<long>
{
public static readonly long[] Value=A142302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142302.Bytes);
public long this[int i]=>Value[i];

public static A142302Inst Instance=new A142302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142301
{
public static readonly long[] Value={ 109L,197L,241L,373L,461L,593L,769L,857L,1033L,1297L,1429L,1693L,1913L,2089L,2221L,2309L,2441L,2617L,2749L,2837L,2969L,3541L,3673L,3761L,4157L,4201L,4289L,4421L,4597L,4729L,4817L,4861L,4993L,5081L,5477L,5521L,5653L,5741L,6269L,6577L,6709L,6841L,7193L,7237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142301Inst : IEnumerable<long>
{
public static readonly long[] Value=A142301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142301.Bytes);
public long this[int i]=>Value[i];

public static A142301Inst Instance=new A142301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142300
{
public static readonly long[] Value={ 19L,107L,151L,239L,283L,503L,547L,811L,1031L,1163L,1427L,1471L,1559L,1823L,1867L,1999L,2087L,2131L,2351L,2659L,2791L,2879L,3011L,3187L,3319L,3407L,3539L,3583L,3671L,3803L,3847L,4111L,4243L,4463L,4507L,4639L,4903L,5167L,5387L,5431L,5519L,5563L,5651L,5783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142300Inst : IEnumerable<long>
{
public static readonly long[] Value=A142300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142300.Bytes);
public long this[int i]=>Value[i];

public static A142300Inst Instance=new A142300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142299
{
public static readonly long[] Value={ 17L,61L,149L,193L,281L,457L,677L,809L,853L,941L,1117L,1249L,1381L,1601L,1733L,1777L,1997L,2129L,2393L,2437L,2657L,2789L,2833L,3229L,3361L,3449L,3581L,3889L,4021L,4153L,4241L,4373L,4549L,4637L,4813L,5077L,5209L,5297L,5693L,5737L,5869L,6089L,6133L,6221L,6353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142299Inst : IEnumerable<long>
{
public static readonly long[] Value=A142299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142299.Bytes);
public long this[int i]=>Value[i];

public static A142299Inst Instance=new A142299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142298
{
public static readonly long[] Value={ 59L,103L,191L,367L,499L,587L,631L,719L,983L,1291L,1423L,1511L,1907L,1951L,2039L,2083L,2347L,2699L,2963L,3271L,3359L,3491L,3623L,3931L,4019L,4283L,4327L,4547L,4591L,4679L,4723L,4943L,4987L,5119L,5471L,5647L,5779L,5867L,6043L,6131L,6263L,6571L,6659L,6703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142298Inst : IEnumerable<long>
{
public static readonly long[] Value=A142298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142298.Bytes);
public long this[int i]=>Value[i];

public static A142298Inst Instance=new A142298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142297
{
public static readonly long[] Value={ 13L,101L,233L,277L,409L,541L,673L,761L,937L,1069L,1201L,1289L,1553L,1597L,1861L,1949L,1993L,2081L,2213L,2389L,2477L,2521L,2609L,2741L,2917L,3049L,3137L,3181L,3313L,3533L,3709L,3797L,3929L,4457L,4721L,5381L,5557L,5689L,5821L,5953L,6173L,6217L,6481L,6569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142297Inst : IEnumerable<long>
{
public static readonly long[] Value=A142297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142297.Bytes);
public long this[int i]=>Value[i];

public static A142297Inst Instance=new A142297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142296
{
public static readonly long[] Value={ 53L,97L,229L,317L,449L,757L,977L,1021L,1109L,1153L,1373L,1549L,1637L,1901L,2297L,2341L,2473L,2693L,2957L,3001L,3089L,3221L,3529L,3617L,3793L,3881L,4013L,4057L,4409L,4673L,4937L,5113L,5333L,5641L,5861L,6037L,6257L,6301L,6389L,6521L,6653L,6829L,6917L,6961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142296Inst : IEnumerable<long>
{
public static readonly long[] Value=A142296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142296.Bytes);
public long this[int i]=>Value[i];

public static A142296Inst Instance=new A142296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142263
{
public static readonly long[] Value={ 229L,401L,487L,659L,1433L,1777L,1949L,2207L,2293L,2551L,3067L,3583L,4013L,4099L,4271L,4357L,4787L,5303L,5647L,6163L,6421L,6679L,7109L,7883L,9001L,9173L,9431L,9689L,10463L,10979L,11839L,12011L,12097L,12269L,12527L,12613L,13043L,13903L,14419L,14591L,15107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142263Inst : IEnumerable<long>
{
public static readonly long[] Value=A142263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142263.Bytes);
public long this[int i]=>Value[i];

public static A142263Inst Instance=new A142263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142262
{
public static readonly long[] Value={ 13L,271L,443L,701L,787L,1217L,1303L,1733L,2593L,2851L,3023L,3109L,3539L,3797L,4657L,5087L,5431L,5689L,5861L,7151L,7237L,7753L,8011L,8269L,8527L,8699L,9043L,9473L,9817L,10247L,10333L,11279L,12569L,13171L,13687L,13859L,14461L,14633L,14891L,15149L,15493L,15923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142262Inst : IEnumerable<long>
{
public static readonly long[] Value=A142262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142262.Bytes);
public long this[int i]=>Value[i];

public static A142262Inst Instance=new A142262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142261
{
public static readonly long[] Value={ 227L,313L,571L,743L,829L,1087L,1259L,1861L,2377L,2549L,3323L,3581L,4441L,4871L,4957L,5387L,5903L,6247L,6763L,7193L,7451L,7537L,8053L,8311L,8741L,8999L,9257L,9343L,9601L,9859L,10289L,10891L,11149L,11321L,11579L,11923L,12611L,12697L,13127L,13729L,13901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142261Inst : IEnumerable<long>
{
public static readonly long[] Value=A142261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142261.Bytes);
public long this[int i]=>Value[i];

public static A142261Inst Instance=new A142261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142260
{
public static readonly long[] Value={ 11L,97L,269L,613L,1129L,1301L,1559L,2161L,2333L,2591L,2677L,3623L,3709L,3881L,3967L,4139L,4397L,4483L,4999L,5171L,6203L,6547L,6719L,6977L,7321L,8009L,8353L,8783L,9041L,9127L,9643L,9901L,10159L,10331L,10589L,10847L,11621L,12653L,12739L,12911L,13513L,14029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142260Inst : IEnumerable<long>
{
public static readonly long[] Value=A142260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142260.Bytes);
public long this[int i]=>Value[i];

public static A142260Inst Instance=new A142260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142259
{
public static readonly long[] Value={ 53L,139L,311L,397L,569L,827L,1171L,1429L,1601L,2203L,2633L,2719L,3407L,3923L,4783L,5471L,5557L,5987L,6073L,6761L,7019L,7621L,7793L,7879L,9341L,9857L,10459L,10631L,10889L,11491L,12007L,12437L,12781L,12953L,13297L,13469L,14071L,14243L,14759L,15017L,15361L,15619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142259Inst : IEnumerable<long>
{
public static readonly long[] Value=A142259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142259.Bytes);
public long this[int i]=>Value[i];

public static A142259Inst Instance=new A142259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142258
{
public static readonly long[] Value={ 181L,353L,439L,1213L,1471L,1901L,1987L,2417L,2503L,3019L,3191L,3449L,3793L,4051L,4481L,4567L,5857L,6029L,6287L,6373L,6803L,7577L,8093L,8179L,8609L,8867L,10243L,10501L,11447L,12049L,12479L,12823L,13339L,13597L,14543L,14629L,14887L,15661L,15919L,16091L,16349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142258Inst : IEnumerable<long>
{
public static readonly long[] Value=A142258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142258.Bytes);
public long this[int i]=>Value[i];

public static A142258Inst Instance=new A142258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142257
{
public static readonly long[] Value={ 137L,223L,653L,739L,911L,997L,1427L,2029L,2287L,2459L,2803L,3061L,3319L,3491L,4007L,4093L,4523L,5039L,5297L,5641L,5813L,6329L,6673L,7103L,7877L,7963L,8221L,8737L,9511L,9769L,9941L,10457L,10973L,11059L,11317L,11489L,11833L,12263L,13037L,13381L,13553L,14327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142257Inst : IEnumerable<long>
{
public static readonly long[] Value=A142257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142257.Bytes);
public long this[int i]=>Value[i];

public static A142257Inst Instance=new A142257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142256
{
public static readonly long[] Value={ 7L,179L,523L,953L,1039L,1297L,2243L,3361L,3533L,3877L,4049L,4651L,4909L,5081L,5167L,5683L,6113L,6199L,7489L,7919L,8263L,8521L,8693L,8779L,8951L,9209L,9467L,9811L,10069L,10499L,11273L,11617L,11789L,12391L,12821L,12907L,13337L,13681L,14197L,14369L,14627L,14713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142256Inst : IEnumerable<long>
{
public static readonly long[] Value=A142256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142256.Bytes);
public long this[int i]=>Value[i];

public static A142256Inst Instance=new A142256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142255
{
public static readonly long[] Value={ 307L,479L,823L,1511L,1597L,2027L,2113L,2371L,2543L,2801L,2887L,3833L,3919L,4091L,4177L,4349L,4951L,5209L,5381L,5639L,5897L,7187L,7703L,7789L,8219L,8563L,8821L,9337L,9767L,10111L,10369L,10627L,10799L,11057L,11831L,12347L,12433L,13121L,13723L,14153L,14411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142255Inst : IEnumerable<long>
{
public static readonly long[] Value=A142255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142255.Bytes);
public long this[int i]=>Value[i];

public static A142255Inst Instance=new A142255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142254
{
public static readonly long[] Value={ 5L,263L,349L,521L,607L,1123L,1381L,1553L,1811L,2069L,2671L,2843L,3187L,3359L,3617L,4133L,4219L,4391L,4649L,4993L,5939L,6197L,6971L,7057L,7229L,7487L,7573L,8089L,8863L,9293L,9551L,10067L,11443L,11701L,11959L,12647L,13163L,13249L,13421L,13679L,14281L,14797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142254Inst : IEnumerable<long>
{
public static readonly long[] Value=A142254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142254.Bytes);
public long this[int i]=>Value[i];

public static A142254Inst Instance=new A142254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142253
{
public static readonly long[] Value={ 47L,563L,821L,907L,1423L,2111L,2713L,2971L,3229L,3659L,3917L,4003L,4261L,4519L,4691L,5981L,6067L,6841L,7013L,7529L,7873L,8389L,8647L,8819L,9421L,9679L,9851L,10453L,10711L,10883L,11399L,11657L,11743L,12517L,12689L,13033L,13291L,13463L,13721L,13807L,14323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142253Inst : IEnumerable<long>
{
public static readonly long[] Value=A142253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142253.Bytes);
public long this[int i]=>Value[i];

public static A142253Inst Instance=new A142253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142252
{
public static readonly long[] Value={ 3L,89L,347L,433L,691L,863L,1637L,1723L,2153L,2239L,2411L,2927L,3271L,3529L,3701L,4217L,4561L,4733L,5077L,5507L,5851L,6367L,6883L,7829L,8087L,8431L,8689L,8861L,9377L,9463L,9721L,10151L,10667L,10753L,11527L,11699L,12043L,12301L,12473L,13591L,13763L,14107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142252Inst : IEnumerable<long>
{
public static readonly long[] Value=A142252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142252.Bytes);
public long this[int i]=>Value[i];

public static A142252Inst Instance=new A142252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142251
{
public static readonly long[] Value={ 2L,131L,389L,647L,733L,991L,1163L,1249L,2281L,2539L,2711L,2797L,2969L,3313L,3571L,4001L,4259L,4517L,4603L,4861L,5119L,5807L,6151L,6323L,6581L,7699L,8387L,8731L,9161L,9419L,9677L,10193L,10709L,11311L,11483L,11827L,12343L,12601L,13633L,14149L,14321L,14407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142251Inst : IEnumerable<long>
{
public static readonly long[] Value=A142251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142251.Bytes);
public long this[int i]=>Value[i];

public static A142251Inst Instance=new A142251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142250
{
public static readonly long[] Value={ 173L,431L,947L,1033L,1291L,1549L,1721L,1979L,2237L,2753L,3011L,3527L,3613L,4129L,4817L,4903L,5333L,5419L,5591L,5849L,6451L,6709L,6967L,7741L,8171L,8429L,9203L,9461L,9547L,9719L,10321L,10837L,11353L,11783L,12041L,13159L,13331L,13417L,13933L,14449L,14621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142250Inst : IEnumerable<long>
{
public static readonly long[] Value=A142250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142250.Bytes);
public long this[int i]=>Value[i];

public static A142250Inst Instance=new A142250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142249
{
public static readonly long[] Value={ -1L,-1L,1L,-1L,2L,-1L,3L,3L,-1L,4L,19L,4L,-1L,5L,80L,65L,5L,-1L,6L,286L,566L,181L,6L,-1L,7L,945L,3710L,2905L,455L,7L,-1L,8L,2997L,20756L,31781L,12636L,1079L,8L,-1L,9L,9294L,105299L,278304L,218559L,49754L,2469L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142249Inst : IEnumerable<long>
{
public static readonly long[] Value=A142249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142249.Bytes);
public long this[int i]=>Value[i];

public static A142249Inst Instance=new A142249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142248
{
public static readonly long[] Value={ 1L,3L,7L,11L,17L,29L,47L,75L,123L,199L,321L,521L,843L,1363L,2207L,3571L,5777L,9349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142248Inst : IEnumerable<long>
{
public static readonly long[] Value=A142248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142248.Bytes);
public long this[int i]=>Value[i];

public static A142248Inst Instance=new A142248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142199
{
public static readonly long[] Value={ 2L,43L,617L,863L,1109L,1601L,1847L,2011L,2339L,2503L,2749L,3323L,3733L,4799L,5209L,5701L,5783L,6029L,6521L,7013L,7177L,7669L,8161L,8243L,9227L,9391L,9473L,9719L,9883L,10211L,10457L,10867L,10949L,11113L,11933L,12097L,12343L,12589L,12671L,12917L,13163L,13327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142199Inst : IEnumerable<long>
{
public static readonly long[] Value=A142199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142199.Bytes);
public long this[int i]=>Value[i];

public static A142199Inst Instance=new A142199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142198
{
public static readonly long[] Value={ 79L,199L,239L,359L,439L,479L,599L,719L,839L,919L,1039L,1279L,1319L,1399L,1439L,1559L,1759L,1879L,1999L,2039L,2239L,2399L,2719L,2879L,2999L,3079L,3119L,3319L,3359L,3559L,3719L,3919L,4079L,4159L,4519L,4639L,4679L,4759L,4799L,4919L,4999L,5039L,5119L,5279L,5399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142198Inst : IEnumerable<long>
{
public static readonly long[] Value=A142198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142198.Bytes);
public long this[int i]=>Value[i];

public static A142198Inst Instance=new A142198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142197
{
public static readonly long[] Value={ 37L,157L,197L,277L,317L,397L,557L,677L,757L,797L,877L,997L,1117L,1237L,1277L,1597L,1637L,1877L,1997L,2237L,2357L,2437L,2477L,2557L,2677L,2797L,2837L,2917L,2957L,3037L,3517L,3557L,3637L,3677L,3797L,3877L,3917L,4157L,4357L,4397L,4517L,4597L,4637L,4877L,4957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142197Inst : IEnumerable<long>
{
public static readonly long[] Value=A142197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142197.Bytes);
public long this[int i]=>Value[i];

public static A142197Inst Instance=new A142197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142196
{
public static readonly long[] Value={ 73L,113L,193L,233L,313L,353L,433L,593L,673L,953L,1033L,1153L,1193L,1433L,1553L,1753L,1873L,1913L,1993L,2113L,2153L,2273L,2393L,2473L,2593L,2633L,2713L,2753L,2833L,2953L,3313L,3433L,3593L,3673L,3793L,3833L,4073L,4153L,4273L,4513L,4673L,4793L,4993L,5113L,5153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142196Inst : IEnumerable<long>
{
public static readonly long[] Value=A142196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142196.Bytes);
public long this[int i]=>Value[i];

public static A142196Inst Instance=new A142196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142195
{
public static readonly long[] Value={ 31L,71L,151L,191L,271L,311L,431L,631L,751L,911L,991L,1031L,1151L,1231L,1471L,1511L,1831L,1871L,1951L,2111L,2311L,2351L,2551L,2591L,2671L,2711L,2791L,3191L,3271L,3391L,3511L,3631L,3671L,3911L,4111L,4231L,4271L,4391L,4591L,4751L,4831L,4871L,4951L,5231L,5351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142195Inst : IEnumerable<long>
{
public static readonly long[] Value=A142195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142195.Bytes);
public long this[int i]=>Value[i];

public static A142195Inst Instance=new A142195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142194
{
public static readonly long[] Value={ 29L,109L,149L,229L,269L,349L,389L,509L,709L,829L,1069L,1109L,1229L,1429L,1549L,1669L,1709L,1789L,1949L,2029L,2069L,2269L,2309L,2389L,2549L,2749L,2789L,2909L,3109L,3229L,3389L,3469L,3709L,3989L,4229L,4349L,4549L,4789L,4909L,5189L,5309L,5669L,5749L,5869L,6029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142194Inst : IEnumerable<long>
{
public static readonly long[] Value=A142194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142194.Bytes);
public long this[int i]=>Value[i];

public static A142194Inst Instance=new A142194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142193
{
public static readonly long[] Value={ 67L,107L,227L,307L,347L,467L,547L,587L,787L,827L,907L,947L,1187L,1307L,1427L,1627L,1667L,1747L,1787L,1867L,1907L,1987L,2027L,2267L,2347L,2467L,2707L,3067L,3187L,3307L,3347L,3467L,3547L,3907L,3947L,4027L,4507L,4547L,4787L,4987L,5107L,5147L,5227L,5347L,5387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142193Inst : IEnumerable<long>
{
public static readonly long[] Value=A142193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142193.Bytes);
public long this[int i]=>Value[i];

public static A142193Inst Instance=new A142193Inst();

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