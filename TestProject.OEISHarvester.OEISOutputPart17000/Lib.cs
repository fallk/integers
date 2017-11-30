using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A078048
{
public static readonly long[] Value={ 1L,-2L,0L,6L,-10L,-2L,34L,-50L,-22L,190L,-246L,-178L,1050L,-1186L,-1270L,5742L,-5574L,-8450L,31082L,-25330L,-53734L,166558L,-109750L,-330834L,883450L,-441282L,-1987286L,4636750L,-1544742L,-11703330L,24066314L,-3749138L,-67790150L,123421054L,4660970L,-387083378L,624603546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078048Inst : IEnumerable<long>
{
public static readonly long[] Value=A078048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078048.Bytes);
public long this[int i]=>Value[i];

public static A078048Inst Instance=new A078048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078047
{
public static readonly long[] Value={ 1L,-2L,1L,-1L,4L,-5L,3L,-6L,13L,-13L,12L,-25L,39L,-38L,49L,-89L,116L,-125L,187L,-294L,357L,-437L,668L,-945L,1151L,-1542L,2281L,-3041L,3844L,-5365L,7603L,-9926L,13053L,-18333L,25132L,-32905L,44439L,-61798L,83169L,-110249L,150676L,-206765L,276587L,-371174L,508117L,-690117L,924348L,-1250465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078047Inst : IEnumerable<long>
{
public static readonly long[] Value=A078047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078047.Bytes);
public long this[int i]=>Value[i];

public static A078047Inst Instance=new A078047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078046
{
public static readonly long[] Value={ 1L,-2L,1L,2L,-5L,4L,3L,-12L,13L,2L,-27L,38L,-9L,-56L,103L,-56L,-103L,262L,-215L,-150L,627L,-692L,-85L,1404L,-2011L,522L,2893L,-5426L,3055L,5264L,-13745L,11536L,7473L,-32754L,36817L,3410L,-72981L,106388L,-29997L,-149372L,285757L,-166382L,-268747L,720886L,-618521L,-371112L,1710519L,-1957928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078046Inst : IEnumerable<long>
{
public static readonly long[] Value=A078046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078046.Bytes);
public long this[int i]=>Value[i];

public static A078046Inst Instance=new A078046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078045
{
public static readonly long[] Value={ 1L,-2L,1L,3L,-8L,7L,7L,-30L,37L,7L,-104L,171L,-53L,-326L,721L,-501L,-872L,2815L,-2945L,-1614L,10189L,-14465L,1048L,33795L,-63773L,32074L,99289L,-258909L,223768L,233719L,-975305L,1189122L,253621L,-3393353L,5517976L,-1617381L,-10687301L,23340634L,-15888095L,-28827141L,91396504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078045Inst : IEnumerable<long>
{
public static readonly long[] Value=A078045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078045.Bytes);
public long this[int i]=>Value[i];

public static A078045Inst Instance=new A078045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078044
{
public static readonly long[] Value={ 1L,-2L,2L,-4L,8L,-12L,20L,-36L,60L,-100L,172L,-292L,492L,-836L,1420L,-2404L,4076L,-6916L,11724L,-19876L,33708L,-57156L,96908L,-164324L,278636L,-472452L,801100L,-1358372L,2303276L,-3905476L,6622220L,-11228772L,19039724L,-32284164L,54741708L,-92821156L,157389484L,-266872900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078044Inst : IEnumerable<long>
{
public static readonly long[] Value=A078044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078044.Bytes);
public long this[int i]=>Value[i];

public static A078044Inst Instance=new A078044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078043
{
public static readonly long[] Value={ 1L,-2L,3L,-7L,14L,-27L,55L,-110L,219L,-439L,878L,-1755L,3511L,-7022L,14043L,-28087L,56174L,-112347L,224695L,-449390L,898779L,-1797559L,3595118L,-7190235L,14380471L,-28760942L,57521883L,-115043767L,230087534L,-460175067L,920350135L,-1840700270L,3681400539L,-7362801079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078043Inst : IEnumerable<long>
{
public static readonly long[] Value=A078043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078043.Bytes);
public long this[int i]=>Value[i];

public static A078043Inst Instance=new A078043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078042
{
public static readonly long[] Value={ 1L,-2L,3L,-6L,11L,-20L,37L,-68L,125L,-230L,423L,-778L,1431L,-2632L,4841L,-8904L,16377L,-30122L,55403L,-101902L,187427L,-344732L,634061L,-1166220L,2145013L,-3945294L,7256527L,-13346834L,24548655L,-45152016L,83047505L,-152748176L,280947697L,-516743378L,950439251L,-1748130326L,3215312955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078042Inst : IEnumerable<long>
{
public static readonly long[] Value=A078042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078042.Bytes);
public long this[int i]=>Value[i];

public static A078042Inst Instance=new A078042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078041
{
public static readonly long[] Value={ 1L,-2L,3L,-3L,2L,1L,-5L,10L,-13L,13L,-6L,-7L,27L,-46L,59L,-51L,18L,49L,-133L,218L,-253L,205L,-22L,-279L,667L,-990L,1099L,-755L,-126L,1569L,-3205L,4522L,-4589L,2701L,1754L,-8231L,15387L,-20110L,19035L,-8371L,-12814L,42513L,-72069L,88954L,-75997L,20813L,81098L,-212279L,335003L,-385086L,295531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078041Inst : IEnumerable<long>
{
public static readonly long[] Value=A078041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078041.Bytes);
public long this[int i]=>Value[i];

public static A078041Inst Instance=new A078041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078040
{
public static readonly long[] Value={ 1L,-2L,4L,-10L,22L,-50L,114L,-258L,586L,-1330L,3018L,-6850L,15546L,-35282L,80074L,-181730L,412442L,-936050L,2124394L,-4821378L,10942266L,-24833810L,56361098L,-127913250L,290303066L,-658851762L,1495284394L,-3393594050L,7701866362L,-17479623250L,39670544074L,-90033523298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078040Inst : IEnumerable<long>
{
public static readonly long[] Value=A078040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078040.Bytes);
public long this[int i]=>Value[i];

public static A078040Inst Instance=new A078040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078039
{
public static readonly long[] Value={ 1L,-2L,4L,-9L,19L,-41L,88L,-189L,406L,-872L,1873L,-4023L,8641L,-18560L,39865L,-85626L,183916L,-395033L,848491L,-1822473L,3914488L,-8407925L,18059374L,-38789712L,83316385L,-178955183L,384377665L,-825604416L,1773314929L,-3808901426L,8181135700L,-17572253481L,37743426307L,-81069068969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078039Inst : IEnumerable<long>
{
public static readonly long[] Value=A078039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078039.Bytes);
public long this[int i]=>Value[i];

public static A078039Inst Instance=new A078039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078038
{
public static readonly long[] Value={ 1L,-2L,4L,-7L,13L,-23L,42L,-75L,136L,-244L,441L,-793L,1431L,-2576L,4645L,-8366L,15080L,-27167L,48961L,-88215L,158970L,-286439L,516164L,-930072L,1675961L,-3019941L,5441791L,-9805712L,17669353L,-31838986L,57371980L,-103380599L,186285573L,-335674791L,604865338L,-1089929347L,1963985232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078038Inst : IEnumerable<long>
{
public static readonly long[] Value=A078038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078038.Bytes);
public long this[int i]=>Value[i];

public static A078038Inst Instance=new A078038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078037
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,6L,4L,-12L,-20L,16L,64L,8L,-160L,-144L,304L,608L,-320L,-1824L,-576L,4288L,4800L,-7424L,-18176L,5248L,51200L,25856L,-112896L,-154112L,174080L,534016L,-39936L,-1416192L,-988160L,2912256L,4808704L,-3848192L,-15441920L,-1921024L,38580224L,34725888L,-73318400L,-146612224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078037Inst : IEnumerable<long>
{
public static readonly long[] Value=A078037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078037.Bytes);
public long this[int i]=>Value[i];

public static A078037Inst Instance=new A078037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078036
{
public static readonly long[] Value={ 1L,-1L,-2L,1L,5L,0L,-11L,-5L,22L,21L,-39L,-64L,57L,167L,-50L,-391L,-67L,832L,525L,-1597L,-1882L,2669L,5361L,-3456L,-13391L,1551L,30238L,10289L,-62027L,-50816L,113765L,163659L,-176714L,-441083L,189769L,1058880L,61545L,-2307529L,-1181970L,4553513L,4671469L,-7925056L,-13896451L,11178643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078036Inst : IEnumerable<long>
{
public static readonly long[] Value=A078036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078036.Bytes);
public long this[int i]=>Value[i];

public static A078036Inst Instance=new A078036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077971
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,1L,2L,-3L,7L,-6L,7L,1L,-6L,21L,-25L,34L,-17L,1L,50L,-83L,135L,-118L,87L,65L,-214L,453L,-537L,562L,-193L,-319L,1250L,-1955L,2567L,-2022L,679L,2433L,-5798L,9589L,-10521L,8514L,143L,-12671L,29842L,-42227L,46727L,-29270L,-8457L,72641L,-139638L,195365L,-189721L,105810L,95199L,-368831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077971Inst : IEnumerable<long>
{
public static readonly long[] Value=A077971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077971.Bytes);
public long this[int i]=>Value[i];

public static A077971Inst Instance=new A077971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077970
{
public static readonly long[] Value={ 1L,-1L,3L,-7L,15L,-35L,79L,-179L,407L,-923L,2095L,-4755L,10791L,-24491L,55583L,-126147L,286295L,-649755L,1474639L,-3346739L,7595527L,-17238283L,39122815L,-88790435L,201512631L,-457339131L,1037945263L,-2355648787L,5346217575L,-12133405675L,27537138399L,-62496384899L,141837473047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077970Inst : IEnumerable<long>
{
public static readonly long[] Value=A077970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077970.Bytes);
public long this[int i]=>Value[i];

public static A077970Inst Instance=new A077970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077969
{
public static readonly long[] Value={ 24L,30L,34L,40L,44L,46L,52L,56L,58L,98L,122L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077969Inst : IEnumerable<long>
{
public static readonly long[] Value=A077969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077969.Bytes);
public long this[int i]=>Value[i];

public static A077969Inst Instance=new A077969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077968
{
public static readonly long[] Value={ 1L,0L,-2L,-2L,4L,8L,-4L,-24L,-8L,56L,64L,-96L,-240L,64L,672L,352L,-1472L,-2048L,2240L,7040L,-384L,-18560L,-13312L,37888L,63744L,-49152L,-203264L,-29184L,504832L,464896L,-951296L,-1939456L,972800L,5781504L,1933312L,-13508608L,-15429632L,23150592L,57876480L,-15441920L,-162054144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077968Inst : IEnumerable<long>
{
public static readonly long[] Value=A077968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077968.Bytes);
public long this[int i]=>Value[i];

public static A077968Inst Instance=new A077968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077967
{
public static readonly long[] Value={ 1L,0L,-2L,-1L,4L,4L,-7L,-12L,10L,31L,-8L,-72L,-15L,152L,102L,-289L,-356L,476L,1001L,-596L,-2478L,191L,5552L,2096L,-11295L,-9744L,20494L,30783L,-31244L,-82060L,31705L,195364L,18650L,-422433L,-232664L,826216L,887761L,-1419768L,-2601738L,1951775L,6623244L,-1301812L,-15198263L,-4019620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077967Inst : IEnumerable<long>
{
public static readonly long[] Value=A077967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077967.Bytes);
public long this[int i]=>Value[i];

public static A077967Inst Instance=new A077967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077966
{
public static readonly long[] Value={ 1L,0L,-2L,0L,4L,0L,-8L,0L,16L,0L,-32L,0L,64L,0L,-128L,0L,256L,0L,-512L,0L,1024L,0L,-2048L,0L,4096L,0L,-8192L,0L,16384L,0L,-32768L,0L,65536L,0L,-131072L,0L,262144L,0L,-524288L,0L,1048576L,0L,-2097152L,0L,4194304L,0L,-8388608L,0L,16777216L,0L,-33554432L,0L,67108864L,0L,-134217728L,0L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077966Inst : IEnumerable<long>
{
public static readonly long[] Value=A077966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077966.Bytes);
public long this[int i]=>Value[i];

public static A077966Inst Instance=new A077966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077965
{
public static readonly long[] Value={ 1L,0L,-2L,1L,4L,-4L,-7L,12L,10L,-31L,-8L,72L,-15L,-152L,102L,289L,-356L,-476L,1001L,596L,-2478L,-191L,5552L,-2096L,-11295L,9744L,20494L,-30783L,-31244L,82060L,31705L,-195364L,18650L,422433L,-232664L,-826216L,887761L,1419768L,-2601738L,-1951775L,6623244L,1301812L,-15198263L,4019620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077965Inst : IEnumerable<long>
{
public static readonly long[] Value=A077965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077965.Bytes);
public long this[int i]=>Value[i];

public static A077965Inst Instance=new A077965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077964
{
public static readonly long[] Value={ 1L,0L,-2L,2L,4L,-8L,-4L,24L,-8L,-56L,64L,96L,-240L,-64L,672L,-352L,-1472L,2048L,2240L,-7040L,-384L,18560L,-13312L,-37888L,63744L,49152L,-203264L,29184L,504832L,-464896L,-951296L,1939456L,972800L,-5781504L,1933312L,13508608L,-15429632L,-23150592L,57876480L,15441920L,-162054144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077964Inst : IEnumerable<long>
{
public static readonly long[] Value=A077964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077964.Bytes);
public long this[int i]=>Value[i];

public static A077964Inst Instance=new A077964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077963
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,1L,4L,3L,-6L,-11L,0L,23L,22L,-23L,-68L,-21L,114L,157L,-72L,-385L,-242L,529L,1012L,-45L,-2070L,-1979L,2160L,6119L,1798L,-10439L,-14036L,6843L,34914L,21229L,-48600L,-91057L,6142L,188257L,175972L,-200541L,-552486L,-151403L,953568L,1256375L,-650762L,-3163511L,-1861988L,4465035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077963Inst : IEnumerable<long>
{
public static readonly long[] Value=A077963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077963.Bytes);
public long this[int i]=>Value[i];

public static A077963Inst Instance=new A077963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077962
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,1L,2L,0L,-3L,-2L,3L,5L,-1L,-8L,-4L,9L,12L,-5L,-21L,-7L,26L,28L,-19L,-54L,-9L,73L,63L,-64L,-136L,1L,200L,135L,-201L,-335L,66L,536L,269L,-602L,-805L,333L,1407L,472L,-1740L,-1879L,1268L,3619L,611L,-4887L,-4230L,4276L,9117L,-46L,-13393L,-9071L,13439L,22464L,-4368L,-35903L,-18096L,40271L,53999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077962Inst : IEnumerable<long>
{
public static readonly long[] Value=A077962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077962.Bytes);
public long this[int i]=>Value[i];

public static A077962Inst Instance=new A077962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077961
{
public static readonly long[] Value={ 1L,0L,-1L,1L,1L,-2L,0L,3L,-2L,-3L,5L,1L,-8L,4L,9L,-12L,-5L,21L,-7L,-26L,28L,19L,-54L,9L,73L,-63L,-64L,136L,1L,-200L,135L,201L,-335L,-66L,536L,-269L,-602L,805L,333L,-1407L,472L,1740L,-1879L,-1268L,3619L,-611L,-4887L,4230L,4276L,-9117L,-46L,13393L,-9071L,-13439L,22464L,4368L,-35903L,18096L,40271L,-53999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077961Inst : IEnumerable<long>
{
public static readonly long[] Value=A077961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077961.Bytes);
public long this[int i]=>Value[i];

public static A077961Inst Instance=new A077961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077960
{
public static readonly long[] Value={ 18L,122L,118L,117L,226L,130L,136L,1117L,187L,57L,28L,114L,128L,1111111L,52628L,111748L,114663L,212174L,110111L,35131L,81414L,122615L,33341L,4584L,111243L,25475L,33171L,21339L,22351L,41127L,21621L,2920L,111321L,2224811L,223249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077960Inst : IEnumerable<long>
{
public static readonly long[] Value=A077960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077960.Bytes);
public long this[int i]=>Value[i];

public static A077960Inst Instance=new A077960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077959
{
public static readonly long[] Value={ 1L,0L,0L,-2L,0L,0L,4L,0L,0L,-8L,0L,0L,16L,0L,0L,-32L,0L,0L,64L,0L,0L,-128L,0L,0L,256L,0L,0L,-512L,0L,0L,1024L,0L,0L,-2048L,0L,0L,4096L,0L,0L,-8192L,0L,0L,16384L,0L,0L,-32768L,0L,0L,65536L,0L,0L,-131072L,0L,0L,262144L,0L,0L,-524288L,0L,0L,1048576L,0L,0L,-2097152L,0L,0L,4194304L,0L,0L,-8388608L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077959Inst : IEnumerable<long>
{
public static readonly long[] Value=A077959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077959.Bytes);
public long this[int i]=>Value[i];

public static A077959Inst Instance=new A077959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077958
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,4L,0L,0L,8L,0L,0L,16L,0L,0L,32L,0L,0L,64L,0L,0L,128L,0L,0L,256L,0L,0L,512L,0L,0L,1024L,0L,0L,2048L,0L,0L,4096L,0L,0L,8192L,0L,0L,16384L,0L,0L,32768L,0L,0L,65536L,0L,0L,131072L,0L,0L,262144L,0L,0L,524288L,0L,0L,1048576L,0L,0L,2097152L,0L,0L,4194304L,0L,0L,8388608L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077958Inst : IEnumerable<long>
{
public static readonly long[] Value=A077958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077958.Bytes);
public long this[int i]=>Value[i];

public static A077958Inst Instance=new A077958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077957
{
public static readonly long[] Value={ 1L,0L,2L,0L,4L,0L,8L,0L,16L,0L,32L,0L,64L,0L,128L,0L,256L,0L,512L,0L,1024L,0L,2048L,0L,4096L,0L,8192L,0L,16384L,0L,32768L,0L,65536L,0L,131072L,0L,262144L,0L,524288L,0L,1048576L,0L,2097152L,0L,4194304L,0L,8388608L,0L,16777216L,0L,33554432L,0L,67108864L,0L,134217728L,0L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077957Inst : IEnumerable<long>
{
public static readonly long[] Value=A077957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077957.Bytes);
public long this[int i]=>Value[i];

public static A077957Inst Instance=new A077957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077956
{
public static readonly long[] Value={ 1L,1L,-1L,-5L,-5L,7L,27L,23L,-45L,-145L,-101L,279L,771L,415L,-1685L,-4057L,-1517L,9967L,21115L,4215L,-57949L,-108609L,-1141L,331975L,551475L,-110193L,-1877093L,-2759657L,1214915L,10488415L,13577899L,-9828761L,-57961389L,-65459665L,70120635L,316962743L,307640803L,-466525953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077956Inst : IEnumerable<long>
{
public static readonly long[] Value=A077956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077956.Bytes);
public long this[int i]=>Value[i];

public static A077956Inst Instance=new A077956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077955
{
public static readonly long[] Value={ 1L,1L,-1L,-4L,-3L,6L,16L,7L,-31L,-61L,-6L,147L,220L,-68L,-655L,-739L,639L,2772L,2233L,-3950L,-11188L,-5521L,20805L,43035L,6946L,-99929L,-156856L,36056L,449697L,534441L,-401009L,-1919588L,-1652011L,2588174L,7811784L,4287447L,-13924295L,-30310973L,-6749830L,67796411L,111607044L,-17235948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077955Inst : IEnumerable<long>
{
public static readonly long[] Value=A077955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077955.Bytes);
public long this[int i]=>Value[i];

public static A077955Inst Instance=new A077955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077954
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,1L,4L,0L,-7L,-3L,11L,10L,-15L,-24L,16L,49L,-7L,-89L,-26L,145L,108L,-208L,-279L,245L,595L,-174L,-1119L,-176L,1888L,1121L,-2831L,-3185L,3598L,7137L,-3244L,-13920L,-295L,24301L,10971L,-37926L,-35567L,51256L,84464L,-53615L,-171287L,20407L,309366L,97265L,-501060L,-386224L,713161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077954Inst : IEnumerable<long>
{
public static readonly long[] Value=A077954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077954.Bytes);
public long this[int i]=>Value[i];

public static A077954Inst Instance=new A077954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077953
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,3L,3L,-5L,-5L,11L,11L,-21L,-21L,43L,43L,-85L,-85L,171L,171L,-341L,-341L,683L,683L,-1365L,-1365L,2731L,2731L,-5461L,-5461L,10923L,10923L,-21845L,-21845L,43691L,43691L,-87381L,-87381L,174763L,174763L,-349525L,-349525L,699051L,699051L,-1398101L,-1398101L,2796203L,2796203L,-5592405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077953Inst : IEnumerable<long>
{
public static readonly long[] Value=A077953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077953.Bytes);
public long this[int i]=>Value[i];

public static A077953Inst Instance=new A077953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077952
{
public static readonly long[] Value={ 1L,1L,0L,-3L,-5L,-2L,9L,21L,16L,-23L,-81L,-90L,37L,289L,432L,69L,-941L,-1874L,-1071L,2685L,7504L,6961L,-5913L,-27882L,-35891L,3817L,95472L,163437L,60331L,-294050L,-681255L,-507867L,761488L,2631865L,2886111L,-1268730L,-9418571L,-13922063L,-1966032L,30793173L,60603331L,33742222L,-88447455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077952Inst : IEnumerable<long>
{
public static readonly long[] Value=A077952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077952.Bytes);
public long this[int i]=>Value[i];

public static A077952Inst Instance=new A077952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077951
{
public static readonly long[] Value={ 1L,1L,0L,1L,3L,2L,1L,5L,8L,5L,7L,18L,21L,17L,32L,57L,59L,66L,121L,173L,184L,253L,415L,530L,621L,921L,1360L,1681L,2163L,3202L,4401L,5525L,7528L,10805L,14327L,18578L,25861L,35937L,47232L,63017L,87659L,119106L,157481L,213693L,294424L,395693L,528655L,721810L,984541L,1320041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077951Inst : IEnumerable<long>
{
public static readonly long[] Value=A077951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077951.Bytes);
public long this[int i]=>Value[i];

public static A077951Inst Instance=new A077951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077950
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-3L,-5L,-3L,3L,13L,19L,13L,-13L,-51L,-77L,-51L,51L,205L,307L,205L,-205L,-819L,-1229L,-819L,819L,3277L,4915L,3277L,-3277L,-13107L,-19661L,-13107L,13107L,52429L,78643L,52429L,-52429L,-209715L,-314573L,-209715L,209715L,838861L,1258291L,838861L,-838861L,-3355443L,-5033165L,-3355443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077950Inst : IEnumerable<long>
{
public static readonly long[] Value=A077950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077950.Bytes);
public long this[int i]=>Value[i];

public static A077950Inst Instance=new A077950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077949
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,7L,13L,23L,37L,63L,109L,183L,309L,527L,893L,1511L,2565L,4351L,7373L,12503L,21205L,35951L,60957L,103367L,175269L,297183L,503917L,854455L,1448821L,2456655L,4165565L,7063207L,11976517L,20307647L,34434061L,58387095L,99002389L,167870511L,284644701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077949Inst : IEnumerable<long>
{
public static readonly long[] Value=A077949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077949.Bytes);
public long this[int i]=>Value[i];

public static A077949Inst Instance=new A077949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077948
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,-2L,-3L,-7L,-6L,-7L,1L,6L,21L,25L,34L,17L,1L,-50L,-83L,-135L,-118L,-87L,65L,214L,453L,537L,562L,193L,-319L,-1250L,-1955L,-2567L,-2022L,-679L,2433L,5798L,9589L,10521L,8514L,-143L,-12671L,-29842L,-42227L,-46727L,-29270L,8457L,72641L,139638L,195365L,189721L,105810L,-95199L,-368831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077948Inst : IEnumerable<long>
{
public static readonly long[] Value=A077948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077948.Bytes);
public long this[int i]=>Value[i];

public static A077948Inst Instance=new A077948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077947
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,18L,37L,73L,146L,293L,585L,1170L,2341L,4681L,9362L,18725L,37449L,74898L,149797L,299593L,599186L,1198373L,2396745L,4793490L,9586981L,19173961L,38347922L,76695845L,153391689L,306783378L,613566757L,1227133513L,2454267026L,4908534053L,9817068105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077947Inst : IEnumerable<long>
{
public static readonly long[] Value=A077947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077947.Bytes);
public long this[int i]=>Value[i];

public static A077947Inst Instance=new A077947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077946
{
public static readonly long[] Value={ 1L,1L,3L,7L,15L,35L,79L,179L,407L,923L,2095L,4755L,10791L,24491L,55583L,126147L,286295L,649755L,1474639L,3346739L,7595527L,17238283L,39122815L,88790435L,201512631L,457339131L,1037945263L,2355648787L,5346217575L,12133405675L,27537138399L,62496384899L,141837473047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077946Inst : IEnumerable<long>
{
public static readonly long[] Value=A077946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077946.Bytes);
public long this[int i]=>Value[i];

public static A077946Inst Instance=new A077946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077945
{
public static readonly long[] Value={ 1L,2L,2L,-2L,-12L,-24L,-20L,32L,152L,280L,192L,-480L,-1904L,-3232L,-1696L,6880L,23616L,36864L,12736L,-95488L,-290176L,-414848L,-58368L,1293312L,3533056L,4596224L,-460288L,-17179136L,-42630144L,-49981440L,19655680L,224534528L,509720576L,531060736L,-406388736L,-2894340096L,-6038024192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077945Inst : IEnumerable<long>
{
public static readonly long[] Value=A077945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077945.Bytes);
public long this[int i]=>Value[i];

public static A077945Inst Instance=new A077945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077944
{
public static readonly long[] Value={ 1L,2L,2L,-1L,-8L,-16L,-15L,10L,66L,127L,112L,-96L,-543L,-1006L,-830L,895L,4456L,7952L,6097L,-8166L,-36478L,-62721L,-44320L,73280L,297921L,493602L,318082L,-648961L,-2427688L,-3875536L,-2246735L,5685290L,19739586L,30355327L,15546192L,-49357856L,-160163423L,-237157326L,-104629950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077944Inst : IEnumerable<long>
{
public static readonly long[] Value=A077944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077944.Bytes);
public long this[int i]=>Value[i];

public static A077944Inst Instance=new A077944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077943
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,8L,12L,16L,24L,40L,64L,96L,144L,224L,352L,544L,832L,1280L,1984L,3072L,4736L,7296L,11264L,17408L,26880L,41472L,64000L,98816L,152576L,235520L,363520L,561152L,866304L,1337344L,2064384L,3186688L,4919296L,7593984L,11722752L,18096128L,27934720L,43122688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077943Inst : IEnumerable<long>
{
public static readonly long[] Value=A077943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077943.Bytes);
public long this[int i]=>Value[i];

public static A077943Inst Instance=new A077943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077942
{
public static readonly long[] Value={ 1L,2L,3L,2L,-3L,-14L,-29L,-38L,-19L,58L,211L,402L,477L,130L,-1021L,-3126L,-5491L,-5814L,115L,17026L,45565L,73874L,68131L,-28742L,-273363L,-654246L,-977645L,-754318L,777501L,4264610L,9260355L,12701098L,7612621L,-15996566L,-65007949L,-129244574L,-161488067L,-63715662L,292545891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077942Inst : IEnumerable<long>
{
public static readonly long[] Value=A077942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077942.Bytes);
public long this[int i]=>Value[i];

public static A077942Inst Instance=new A077942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077941
{
public static readonly long[] Value={ 1L,2L,3L,3L,1L,-4L,-12L,-21L,-26L,-19L,9L,63L,136L,200L,201L,66L,-269L,-805L,-1407L,-1740L,-1268L,611L,4230L,9117L,13393L,13439L,4368L,-18096L,-53999L,-94270L,-116445L,-84621L,41473L,284012L,611172L,896859L,898534L,289037L,-1217319L,-3622209L,-6316136L,-7792744L,-5647143L,2814594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077941Inst : IEnumerable<long>
{
public static readonly long[] Value=A077941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077941.Bytes);
public long this[int i]=>Value[i];

public static A077941Inst Instance=new A077941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077940
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,8L,4L,-8L,-32L,-72L,-128L,-192L,-240L,-224L,-64L,352L,1152L,2432L,4160L,6016L,7168L,6016L,0L,-14336L,-40704L,-81408L,-134144L,-186880L,-210944L,-153600L,66560L,555008L,1417216L,2701312L,4292608L,5750784L,6098944L,3612672L,-4276224L,-20750336L,-48726016L,-88899584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077940Inst : IEnumerable<long>
{
public static readonly long[] Value=A077940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077940.Bytes);
public long this[int i]=>Value[i];

public static A077940Inst Instance=new A077940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077939
{
public static readonly long[] Value={ 1L,2L,5L,13L,33L,84L,214L,545L,1388L,3535L,9003L,22929L,58396L,148724L,378773L,964666L,2456829L,6257097L,15935689L,40585304L,103363394L,263247781L,670444260L,1707499695L,4348691431L,11075326817L,28206844760L,71837707768L,182957587113L,465959726754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077939Inst : IEnumerable<long>
{
public static readonly long[] Value=A077939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077939.Bytes);
public long this[int i]=>Value[i];

public static A077939Inst Instance=new A077939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077938
{
public static readonly long[] Value={ 1L,2L,5L,14L,37L,98L,261L,694L,1845L,4906L,13045L,34686L,92229L,245234L,652069L,1733830L,4610197L,12258362L,32594581L,86667918L,230447141L,612751362L,1629285701L,4332217046L,11519222517L,30629233482L,81442123573L,216551925662L,575804441861L,1531045056530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077938Inst : IEnumerable<long>
{
public static readonly long[] Value=A077938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077938.Bytes);
public long this[int i]=>Value[i];

public static A077938Inst Instance=new A077938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077937
{
public static readonly long[] Value={ 1L,2L,6L,14L,36L,88L,220L,544L,1352L,3352L,8320L,20640L,51216L,127072L,315296L,782304L,1941056L,4816128L,11949760L,29649664L,73566592L,182532992L,452899840L,1123732480L,2788198656L,6918062592L,17165057536L,42589842944L,105673675776L,262196922368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077937Inst : IEnumerable<long>
{
public static readonly long[] Value=A077937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077937.Bytes);
public long this[int i]=>Value[i];

public static A077937Inst Instance=new A077937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077936
{
public static readonly long[] Value={ 1L,2L,6L,17L,48L,136L,385L,1090L,3086L,8737L,24736L,70032L,198273L,561346L,1589270L,4499505L,12738896L,36066072L,102109441L,289089922L,818464798L,2317218881L,6560457280L,18573817120L,52585767681L,148879626882L,421504606246L,1193354233937L,3378597307248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077936Inst : IEnumerable<long>
{
public static readonly long[] Value=A077936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077936.Bytes);
public long this[int i]=>Value[i];

public static A077936Inst Instance=new A077936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077935
{
public static readonly long[] Value={ 1L,2L,6L,18L,52L,152L,444L,1296L,3784L,11048L,32256L,94176L,274960L,802784L,2343840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077935Inst : IEnumerable<long>
{
public static readonly long[] Value=A077935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077935.Bytes);
public long this[int i]=>Value[i];

public static A077935Inst Instance=new A077935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077934
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,5L,3L,3L,13L,19L,13L,13L,51L,77L,51L,51L,205L,307L,205L,205L,819L,1229L,819L,819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077934Inst : IEnumerable<long>
{
public static readonly long[] Value=A077934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077934.Bytes);
public long this[int i]=>Value[i];

public static A077934Inst Instance=new A077934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077933
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-6L,10L,-5L,-15L,51L,-76L,36L,132L,-411L,595L,-235L,-1130L,3326L,-4626L,1471L,9637L,-26841L,35880L,-8440L,-81720L,216201L,-277401L,40681L,689642L,-1738046L,2137490L,-109245L,-5794535L,13945051L,-16410276L,-864084L,48493772L,-111669651L,125487675L,20857725L,-404360450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077933Inst : IEnumerable<long>
{
public static readonly long[] Value=A077933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077933.Bytes);
public long this[int i]=>Value[i];

public static A077933Inst Instance=new A077933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077932
{
public static readonly long[] Value={ 1L,-1L,1L,3L,-9L,15L,-5L,-37L,115L,-165L,27L,507L,-1397L,1835L,139L,-6741L,16875L,-19989L,-7253L,88235L,-201941L,212907L,154539L,-1138773L,2394283L,-2201941L,-2662229L,14516907L,-28113237L,21868203L,41523883L,-183010645L,326709931L,-204350805L,-610739541L,2283600555L,-3754423637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077932Inst : IEnumerable<long>
{
public static readonly long[] Value=A077932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077932.Bytes);
public long this[int i]=>Value[i];

public static A077932Inst Instance=new A077932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077931
{
public static readonly long[] Value={ 1L,-1L,2L,-4L,9L,-17L,34L,-68L,137L,-273L,546L,-1092L,2185L,-4369L,8738L,-17476L,34953L,-69905L,139810L,-279620L,559241L,-1118481L,2236962L,-4473924L,8947849L,-17895697L,35791394L,-71582788L,143165577L,-286331153L,572662306L,-1145324612L,2290649225L,-4581298449L,9162596898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077931Inst : IEnumerable<long>
{
public static readonly long[] Value=A077931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077931.Bytes);
public long this[int i]=>Value[i];

public static A077931Inst Instance=new A077931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077930
{
public static readonly long[] Value={ 1L,-1L,2L,-3L,6L,-10L,18L,-31L,55L,-96L,169L,-296L,520L,-912L,1601L,-2809L,4930L,-8651L,15182L,-26642L,46754L,-82047L,143983L,-252672L,443409L,-778128L,1365520L,-2396320L,4205249L,-7379697L,12950466L,-22726483L,39882198L,-69988378L,122821042L,-215535903L,378239143L,-663763424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077930Inst : IEnumerable<long>
{
public static readonly long[] Value=A077930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077930.Bytes);
public long this[int i]=>Value[i];

public static A077930Inst Instance=new A077930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077929
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,0L,4L,-8L,13L,-13L,6L,15L,-48L,88L,-112L,89L,23L,-246L,559L,-848L,892L,-376L,-987L,3243L,-5874L,7519L,-5920L,-1552L,16544L,-37455L,56815L,-59630L,24991L,66464L,-217548L,393624L,-503235L,395299L,106262L,-1111057L,2511152L,-3804984L,3987760L,-1659383L,-4473977L,14595098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077929Inst : IEnumerable<long>
{
public static readonly long[] Value=A077929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077929.Bytes);
public long this[int i]=>Value[i];

public static A077929Inst Instance=new A077929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077928
{
public static readonly long[] Value={ 1L,-1L,2L,0L,-3L,11L,-18L,20L,1L,-57L,154L,-248L,229L,99L,-922L,2204L,-3287L,2527L,2642L,-14384L,31181L,-42693L,25438L,54180L,-219183L,435063L,-542582L,211736L,989237L,-3275373L,5984982L,-6716116L,896505L,16893071L,-48114878L,81129696L,-80358371L,-16642709L,275903182L,-695880396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077928Inst : IEnumerable<long>
{
public static readonly long[] Value=A077928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077928.Bytes);
public long this[int i]=>Value[i];

public static A077928Inst Instance=new A077928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077927
{
public static readonly long[] Value={ 1L,-1L,3L,-7L,17L,-39L,93L,-219L,517L,-1219L,2877L,-6787L,16013L,-37779L,89133L,-210291L,496141L,-1170547L,2761677L,-6515635L,15372365L,-36268083L,85567437L,-201879603L,476295373L,-1123725619L,2651210445L,-6255011635L,14757474509L,-34817369907L,82144763085L,-193804475187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077927Inst : IEnumerable<long>
{
public static readonly long[] Value=A077927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077927.Bytes);
public long this[int i]=>Value[i];

public static A077927Inst Instance=new A077927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077926
{
public static readonly long[] Value={ 1L,-1L,3L,-6L,14L,-30L,67L,-147L,325L,-716L,1580L,-3484L,7685L,-16949L,37383L,-82450L,181850L,-401082L,884615L,-1951079L,4303241L,-9491096L,20933272L,-46169784L,101830665L,-224594601L,495358987L,-1092548638L,2409691878L,-5314742742L,11722034123L,-25853760123L,57022262989L,-125766560100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077926Inst : IEnumerable<long>
{
public static readonly long[] Value=A077926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077926.Bytes);
public long this[int i]=>Value[i];

public static A077926Inst Instance=new A077926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077925
{
public static readonly long[] Value={ 1L,-1L,3L,-5L,11L,-21L,43L,-85L,171L,-341L,683L,-1365L,2731L,-5461L,10923L,-21845L,43691L,-87381L,174763L,-349525L,699051L,-1398101L,2796203L,-5592405L,11184811L,-22369621L,44739243L,-89478485L,178956971L,-357913941L,715827883L,-1431655765L,2863311531L,-5726623061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077925Inst : IEnumerable<long>
{
public static readonly long[] Value=A077925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077925.Bytes);
public long this[int i]=>Value[i];

public static A077925Inst Instance=new A077925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077924
{
public static readonly long[] Value={ 1L,-1L,3L,-3L,5L,-3L,1L,9L,-23L,49L,-79L,113L,-127L,97L,33L,-319L,833L,-1599L,2561L,-3455L,3713L,-2303L,-2303L,12033L,-28671L,52737L,-81407L,105473L,-105471L,48129L,114689L,-440319L,976897L,-1724415L,2568193L,-3182591L,2916353L,-696319L,-4972543L,15777793L,-32948223L,55951361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077924Inst : IEnumerable<long>
{
public static readonly long[] Value=A077924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077924.Bytes);
public long this[int i]=>Value[i];

public static A077924Inst Instance=new A077924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077907
{
public static readonly long[] Value={ 1L,0L,0L,3L,-2L,0L,9L,-12L,4L,27L,-54L,36L,73L,-216L,216L,147L,-794L,1080L,9L,-2676L,4828L,-2133L,-8046L,19836L,-16055L,-19872L,75600L,-87837L,-27506L,266544L,-414711L,93156L,854644L,-1777221L,1108890L,2377620L,-7040951L,6881112L,4915080L,-25878093L,34725238L,983016L,-87464439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077907Inst : IEnumerable<long>
{
public static readonly long[] Value=A077907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077907.Bytes);
public long this[int i]=>Value[i];

public static A077907Inst Instance=new A077907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077906
{
public static readonly long[] Value={ 1L,0L,1L,-2L,3L,-4L,9L,-14L,23L,-40L,69L,-114L,195L,-332L,561L,-950L,1615L,-2736L,4637L,-7866L,13339L,-22612L,38345L,-65022L,110247L,-186936L,316981L,-537474L,911347L,-1545308L,2620257L,-4442950L,7533567L,-12774080L,21659981L,-36727114L,62275275L,-105595236L,179049465L,-303600014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077906Inst : IEnumerable<long>
{
public static readonly long[] Value=A077906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077906.Bytes);
public long this[int i]=>Value[i];

public static A077906Inst Instance=new A077906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077905
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,1L,2L,-1L,3L,0L,0L,4L,-3L,4L,1L,-3L,8L,-6L,4L,5L,-10L,15L,-9L,0L,16L,-24L,25L,-8L,-15L,41L,-48L,34L,8L,-55L,90L,-81L,27L,64L,-144L,172L,-107L,-36L,209L,-315L,280L,-70L,-244L,525L,-594L,351L,175L,-768L,1120L,-944L,177L,944L,-1887L,2065L,-1120L,-766L,2832L,-3951L,3186L,-353L,-3597L,6784L,-7136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077905Inst : IEnumerable<long>
{
public static readonly long[] Value=A077905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077905.Bytes);
public long this[int i]=>Value[i];

public static A077905Inst Instance=new A077905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077904
{
public static readonly long[] Value={ 1L,0L,1L,2L,-1L,4L,1L,-2L,11L,-8L,5L,18L,-33L,44L,-7L,-58L,147L,-160L,45L,250L,-569L,660L,-159L,-978L,2299L,-2616L,661L,3938L,-9169L,10492L,-2615L,-15722L,36707L,-41936L,10493L,62922L,-146793L,167780L,-41935L,-251650L,587211L,-671080L,167781L,1006642L,-2348801L,2684364L,-671079L,-4026522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077904Inst : IEnumerable<long>
{
public static readonly long[] Value=A077904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077904.Bytes);
public long this[int i]=>Value[i];

public static A077904Inst Instance=new A077904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077903
{
public static readonly long[] Value={ 1L,0L,2L,-3L,6L,-12L,25L,-48L,98L,-195L,390L,-780L,1561L,-3120L,6242L,-12483L,24966L,-49932L,99865L,-199728L,399458L,-798915L,1597830L,-3195660L,6391321L,-12782640L,25565282L,-51130563L,102261126L,-204522252L,409044505L,-818089008L,1636178018L,-3272356035L,6544712070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077903Inst : IEnumerable<long>
{
public static readonly long[] Value=A077903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077903.Bytes);
public long this[int i]=>Value[i];

public static A077903Inst Instance=new A077903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077902
{
public static readonly long[] Value={ 1L,0L,2L,-2L,5L,-8L,16L,-28L,53L,-96L,178L,-326L,601L,-1104L,2032L,-3736L,6873L,-12640L,23250L,-42762L,78653L,-144664L,266080L,-489396L,900141L,-1655616L,3045154L,-5600910L,10301681L,-18947744L,34850336L,-64099760L,117897841L,-216847936L,398845538L,-733591314L,1349284789L,-2481721640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077902Inst : IEnumerable<long>
{
public static readonly long[] Value=A077902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077902.Bytes);
public long this[int i]=>Value[i];

public static A077902Inst Instance=new A077902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077901
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,4L,1L,8L,2L,9L,10L,4L,25L,0L,34L,17L,18L,68L,-15L,120L,2L,89L,154L,-60L,393L,-144L,418L,225L,-94L,1156L,-799L,1768L,-254L,425L,2858L,-2940L,6649L,-3872L,4642L,4785L,-7886L,21956L,-20271L,26456L,-2814L,-11271L,61370L,-78268L,117097L,-72624L,33186L,128385L,-240446L,435204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077901Inst : IEnumerable<long>
{
public static readonly long[] Value=A077901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077901.Bytes);
public long this[int i]=>Value[i];

public static A077901Inst Instance=new A077901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077900
{
public static readonly long[] Value={ 1L,0L,3L,-4L,11L,-24L,55L,-124L,283L,-640L,1455L,-3300L,7491L,-17000L,38583L,-87564L,198731L,-451024L,1023615L,-2323124L,5272403L,-11965880L,27156935L,-61633500L,139879131L,-317460000L,720485263L,-1635163524L,3711054051L,-8422351624L,19114786775L,-43381598124L,98455874923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077900Inst : IEnumerable<long>
{
public static readonly long[] Value=A077900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077900.Bytes);
public long this[int i]=>Value[i];

public static A077900Inst Instance=new A077900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077899
{
public static readonly long[] Value={ 1L,0L,3L,-3L,10L,-18L,42L,-87L,190L,-405L,873L,-1872L,4024L,-8640L,18561L,-39864L,85627L,-183915L,395034L,-848490L,1822474L,-3914487L,8407926L,-18059373L,38789713L,-83316384L,178955184L,-384377664L,825604417L,-1773314928L,3808901427L,-8181135699L,17572253482L,-37743426306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077899Inst : IEnumerable<long>
{
public static readonly long[] Value=A077899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077899.Bytes);
public long this[int i]=>Value[i];

public static A077899Inst Instance=new A077899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077898
{
public static readonly long[] Value={ 1L,0L,3L,-2L,9L,-12L,31L,-54L,117L,-224L,459L,-906L,1825L,-3636L,7287L,-14558L,29133L,-58248L,116515L,-233010L,466041L,-932060L,1864143L,-3728262L,7456549L,-14913072L,29826171L,-59652314L,119304657L,-238609284L,477218599L,-954437166L,1908874365L,-3817748696L,7635497427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077898Inst : IEnumerable<long>
{
public static readonly long[] Value=A077898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077898.Bytes);
public long this[int i]=>Value[i];

public static A077898Inst Instance=new A077898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077897
{
public static readonly long[] Value={ 1L,0L,3L,-1L,8L,-6L,22L,-25L,64L,-91L,195L,-312L,612L,-1040L,1953L,-3420L,6287L,-11173L,20328L,-36386L,65870L,-118313L,213668L,-384423L,693447L,-1248624L,2251096L,-4054896L,7308465L,-13167160L,23729195L,-42755049L,77046280L,-138827182L,250164694L,-450772777L,812274984L,-1463655843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077897Inst : IEnumerable<long>
{
public static readonly long[] Value=A077897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077897.Bytes);
public long this[int i]=>Value[i];

public static A077897Inst Instance=new A077897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077896
{
public static readonly long[] Value={ 1L,0L,3L,0L,7L,0L,15L,0L,31L,0L,63L,0L,127L,0L,255L,0L,511L,0L,1023L,0L,2047L,0L,4095L,0L,8191L,0L,16383L,0L,32767L,0L,65535L,0L,131071L,0L,262143L,0L,524287L,0L,1048575L,0L,2097151L,0L,4194303L,0L,8388607L,0L,16777215L,0L,33554431L,0L,67108863L,0L,134217727L,0L,268435455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077896Inst : IEnumerable<long>
{
public static readonly long[] Value=A077896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077896.Bytes);
public long this[int i]=>Value[i];

public static A077896Inst Instance=new A077896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077895
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,1L,9L,5L,-19L,-27L,29L,93L,-3L,-243L,-179L,493L,845L,-627L,-2675L,-435L,6605L,6221L,-12339L,-25651L,12237L,75981L,26829L,-176435L,-205619L,299213L,764109L,-187187L,-2126643L,-1153843L,4627661L,6560973L,-6947635L,-22377267L,773325L,58649805L,43207885L,-118846259L,-203715379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077895Inst : IEnumerable<long>
{
public static readonly long[] Value=A077895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077895.Bytes);
public long this[int i]=>Value[i];

public static A077895Inst Instance=new A077895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077894
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,2L,6L,-1L,-13L,-3L,28L,20L,-52L,-67L,85L,187L,-102L,-458L,18L,1019L,423L,-2055L,-1864L,3688L,5784L,-5511L,-15255L,5239L,36022L,4778L,-77282L,-45577L,149787L,168437L,-253996L,-486660L,339556L,1227317L,-192451L,-2794189L,-842414L,5780830L,4479018L,-10719245L,-14738865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077894Inst : IEnumerable<long>
{
public static readonly long[] Value=A077894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077894.Bytes);
public long this[int i]=>Value[i];

public static A077894Inst Instance=new A077894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077893
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,5L,5L,11L,11L,21L,21L,43L,43L,85L,85L,171L,171L,341L,341L,683L,683L,1365L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077893Inst : IEnumerable<long>
{
public static readonly long[] Value=A077893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077893.Bytes);
public long this[int i]=>Value[i];

public static A077893Inst Instance=new A077893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077892
{
public static readonly long[] Value={ 1L,1L,-1L,0L,4L,0L,-7L,5L,15L,-16L,-24L,48L,33L,-119L,-17L,272L,-84L,-560L,441L,1037L,-1441L,-1632L,3920L,1824L,-9471L,273L,20767L,-10016L,-41260L,40800L,72505L,-122859L,-104209L,318224L,85560L,-740656L,147105L,1566873L,-1034865L,-2986640L,3636604L,4938416L,-10259847L,-6240227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077892Inst : IEnumerable<long>
{
public static readonly long[] Value=A077892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077892.Bytes);
public long this[int i]=>Value[i];

public static A077892Inst Instance=new A077892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077891
{
public static readonly long[] Value={ 1L,1L,-1L,1L,5L,-3L,-7L,17L,9L,-47L,17L,113L,-127L,-191L,481L,129L,-1343L,705L,2945L,-4095L,-4479L,14081L,769L,-37119L,26625L,75777L,-127487L,-98303L,406529L,-58367L,-1009663L,929793L,1902593L,-3878911L,-1945599L,11563009L,-3866623L,-27017215L,30859265L,46301185L,-115752959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077891Inst : IEnumerable<long>
{
public static readonly long[] Value=A077891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077891.Bytes);
public long this[int i]=>Value[i];

public static A077891Inst Instance=new A077891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077890
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-1L,3L,6L,0L,-11L,-11L,12L,34L,11L,-57L,-78L,36L,193L,121L,-264L,-506L,23L,1035L,990L,-1080L,-3059L,-899L,5220L,7018L,-3421L,-17457L,-10614L,24300L,45529L,-3071L,-94128L,-87986L,100271L,276243L,75702L,-476784L,-628187L,325381L,1581756L,930994L,-2232517L,-4094505L,370530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077890Inst : IEnumerable<long>
{
public static readonly long[] Value=A077890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077890.Bytes);
public long this[int i]=>Value[i];

public static A077890Inst Instance=new A077890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077889
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,2L,2L,-1L,-3L,0L,5L,4L,-4L,-8L,1L,13L,8L,-13L,-20L,6L,34L,15L,-39L,-48L,25L,88L,24L,-112L,-111L,89L,224L,23L,-312L,-246L,290L,559L,-43L,-848L,-515L,892L,1364L,-376L,-2255L,-987L,2632L,3243L,-1644L,-5874L,-1598L,7519L,7473L,-5920L,-14991L,-1552L,20912L,16544L,-19359L,-37455L,2816L,56815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077889Inst : IEnumerable<long>
{
public static readonly long[] Value=A077889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077889.Bytes);
public long this[int i]=>Value[i];

public static A077889Inst Instance=new A077889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077888
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,0L,3L,1L,-2L,3L,4L,-4L,0L,9L,-3L,-8L,13L,6L,-20L,8L,27L,-27L,-18L,55L,-8L,-72L,64L,65L,-135L,0L,201L,-134L,-200L,336L,67L,-535L,270L,603L,-804L,-332L,1408L,-471L,-1739L,1880L,1269L,-3618L,612L,4888L,-4229L,-4275L,9118L,47L,-13392L,9072L,13440L,-22463L,-4367L,35904L,-18095L,-40270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077888Inst : IEnumerable<long>
{
public static readonly long[] Value=A077888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077888.Bytes);
public long this[int i]=>Value[i];

public static A077888Inst Instance=new A077888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077887
{
public static readonly long[] Value={ 1L,1L,0L,2L,3L,-1L,2L,8L,-3L,-3L,20L,-2L,-25L,43L,22L,-92L,65L,137L,-248L,-6L,523L,-489L,-534L,1536L,-443L,-2603L,3516L,1718L,-8721L,5315L,12158L,-22756L,-1527L,47073L,-43984L,-50126L,138131L,-37841L,-238382L,314104L,162701L,-790867L,465508L,1116270L,-2047241L,-185253L,4279782L,-3909228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077887Inst : IEnumerable<long>
{
public static readonly long[] Value=A077887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077887.Bytes);
public long this[int i]=>Value[i];

public static A077887Inst Instance=new A077887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077886
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-1L,-1L,3L,3L,3L,-5L,-5L,-5L,11L,11L,11L,-21L,-21L,-21L,43L,43L,43L,-85L,-85L,-85L,171L,171L,171L,-341L,-341L,-341L,683L,683L,683L,-1365L,-1365L,-1365L,2731L,2731L,2731L,-5461L,-5461L,-5461L,10923L,10923L,10923L,-21845L,-21845L,-21845L,43691L,43691L,43691L,-87381L,-87381L,-87381L,174763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077886Inst : IEnumerable<long>
{
public static readonly long[] Value=A077886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077886.Bytes);
public long this[int i]=>Value[i];

public static A077886Inst Instance=new A077886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077885
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,7L,7L,7L,15L,15L,15L,31L,31L,31L,63L,63L,63L,127L,127L,127L,255L,255L,255L,511L,511L,511L,1023L,1023L,1023L,2047L,2047L,2047L,4095L,4095L,4095L,8191L,8191L,8191L,16383L,16383L,16383L,32767L,32767L,32767L,65535L,65535L,65535L,131071L,131071L,131071L,262143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077885Inst : IEnumerable<long>
{
public static readonly long[] Value=A077885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077885.Bytes);
public long this[int i]=>Value[i];

public static A077885Inst Instance=new A077885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077884
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,-3L,2L,-4L,9L,-7L,18L,-24L,33L,-59L,82L,-124L,201L,-287L,450L,-688L,1025L,-1587L,2402L,-3636L,5577L,-8439L,12850L,-19592L,29729L,-45291L,68914L,-104748L,159497L,-242575L,368994L,-561568L,854145L,-1299555L,1977282L,-3007844L,4576393L,-6962407L,10592082L,-16115192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077884Inst : IEnumerable<long>
{
public static readonly long[] Value=A077884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077884.Bytes);
public long this[int i]=>Value[i];

public static A077884Inst Instance=new A077884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077883
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,0L,2L,-1L,3L,-2L,5L,-4L,8L,-8L,13L,-15L,22L,-27L,38L,-48L,66L,-85L,115L,-150L,201L,-264L,352L,-464L,617L,-815L,1082L,-1431L,1898L,-2512L,3330L,-4409L,5843L,-7738L,10253L,-13580L,17992L,-23832L,31573L,-41823L,55406L,-73395L,97230L,-128800L,170626L,-226029L,299427L,-396654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077883Inst : IEnumerable<long>
{
public static readonly long[] Value=A077883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077883.Bytes);
public long this[int i]=>Value[i];

public static A077883Inst Instance=new A077883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077882
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,5L,9L,14L,20L,33L,49L,74L,116L,173L,265L,406L,612L,937L,1425L,2162L,3300L,5013L,7625L,11614L,17652L,26865L,40881L,62170L,94612L,143933L,218953L,333158L,506820L,771065L,1173137L,1784706L,2715268L,4130981L,6284681L,9561518L,14546644L,22130881L,33669681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077882Inst : IEnumerable<long>
{
public static readonly long[] Value=A077882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077882.Bytes);
public long this[int i]=>Value[i];

public static A077882Inst Instance=new A077882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077881
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,-3L,9L,-15L,25L,-47L,81L,-143L,257L,-447L,801L,-1407L,2497L,-4415L,7809L,-13823L,24449L,-43263L,76545L,-135423L,239617L,-423935L,750081L,-1327103L,2348033L,-4154367L,7350273L,-13004799L,23009281L,-40710143L,72028161L,-127438847L,225476609L,-398934015L,705830913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077881Inst : IEnumerable<long>
{
public static readonly long[] Value=A077881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077881.Bytes);
public long this[int i]=>Value[i];

public static A077881Inst Instance=new A077881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077880
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,2L,11L,-1L,21L,-12L,44L,-44L,101L,-131L,247L,-362L,626L,-970L,1615L,-2565L,4201L,-6744L,10968L,-17688L,28681L,-46343L,75051L,-121366L,196446L,-317782L,514259L,-832009L,1346301L,-2178276L,3524612L,-5702852L,9227501L,-14930315L,24157855L,-39088130L,63246026L,-102334114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077880Inst : IEnumerable<long>
{
public static readonly long[] Value=A077880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077880.Bytes);
public long this[int i]=>Value[i];

public static A077880Inst Instance=new A077880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077879
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,17L,29L,53L,93L,165L,293L,517L,917L,1621L,2869L,5077L,8981L,15893L,28117L,49749L,88021L,155733L,275541L,487509L,862549L,1526101L,2700117L,4777301L,8452437L,14954837L,26459477L,46814549L,82828629L,146548053L,259286357L,458753365L,811668821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077879Inst : IEnumerable<long>
{
public static readonly long[] Value=A077879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077879.Bytes);
public long this[int i]=>Value[i];

public static A077879Inst Instance=new A077879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077878
{
public static readonly long[] Value={ 1L,2L,1L,-4L,-9L,-2L,25L,48L,3L,-142L,-243L,36L,807L,1222L,-463L,-4520L,-6037L,3930L,25045L,29260L,-28689L,-137298L,-138439L,193536L,745011L,634818L,-1242275L,-4001932L,-2787017L,7701398L,21279297L,11450536L,-46510853L,-111970518L,-41849883L,275112860L,582753663L,116227710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077878Inst : IEnumerable<long>
{
public static readonly long[] Value=A077878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077878.Bytes);
public long this[int i]=>Value[i];

public static A077878Inst Instance=new A077878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077877
{
public static readonly long[] Value={ 1L,2L,1L,-3L,-6L,0L,16L,23L,-8L,-69L,-75L,72L,292L,224L,-431L,-1170L,-531L,2241L,4474L,524L,-10664L,-16185L,4620L,47655L,54601L,-45328L,-202184L,-166128L,283569L,818010L,417001L,-1502587L,-3154598L,-566424L,7245360L,11532807L,-2391488L,-32702461L,-39452291L,28344120L,139951164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077877Inst : IEnumerable<long>
{
public static readonly long[] Value=A077877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077877.Bytes);
public long this[int i]=>Value[i];

public static A077877Inst Instance=new A077877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077876
{
public static readonly long[] Value={ 1L,2L,1L,-2L,-3L,2L,9L,6L,-11L,-22L,1L,46L,45L,-46L,-135L,-42L,229L,314L,-143L,-770L,-483L,1058L,2025L,-90L,-4139L,-3958L,4321L,12238L,3597L,-20878L,-28071L,13686L,69829L,42458L,-97199L,-182114L,12285L,376514L,351945L,-401082L,-1104971L,-302806L,1907137L,2512750L,-1301523L,-6327022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077876Inst : IEnumerable<long>
{
public static readonly long[] Value=A077876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077876.Bytes);
public long this[int i]=>Value[i];

public static A077876Inst Instance=new A077876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077875
{
public static readonly long[] Value={ 1L,2L,1L,-1L,0L,4L,4L,-3L,-6L,5L,15L,0L,-24L,-8L,41L,34L,-55L,-81L,64L,172L,-36L,-315L,-70L,525L,351L,-768L,-944L,944L,2065L,-766L,-3951L,-353L,6784L,3540L,-10380L,-10675L,13626L,24597L,-13329L,-48896L,2360L,86824L,33209L,-138078L,-117671L,191695L,288960L,-212100L,-598324L,114837L,1099386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077875Inst : IEnumerable<long>
{
public static readonly long[] Value=A077875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077875.Bytes);
public long this[int i]=>Value[i];

public static A077875Inst Instance=new A077875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077874
{
public static readonly long[] Value={ 1L,2L,1L,0L,3L,6L,1L,-4L,7L,18L,-3L,-24L,19L,62L,-23L,-108L,63L,234L,-107L,-448L,235L,918L,-447L,-1812L,919L,3650L,-1811L,-7272L,3651L,14574L,-7271L,-29116L,14575L,58266L,-29115L,-116496L,58267L,233030L,-116495L,-466020L,233031L,932082L,-466019L,-1864120L,932083L,3728286L,-1864119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077874Inst : IEnumerable<long>
{
public static readonly long[] Value=A077874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077874.Bytes);
public long this[int i]=>Value[i];

public static A077874Inst Instance=new A077874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077873
{
public static readonly long[] Value={ 1L,2L,2L,-1L,-6L,-8L,1L,22L,38L,15L,-66L,-156L,-119L,170L,602L,671L,-270L,-2144L,-3215L,-530L,6974L,13935L,8022L,-19860L,-55751L,-51934L,43538L,206975L,267306L,-26744L,-707999L,-1215866L,-454378L,2177487L,5063598L,3794868L,-5623703L,-19545766L,-21511798L,9281375L,69884706L,103626928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077873Inst : IEnumerable<long>
{
public static readonly long[] Value=A077873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077873.Bytes);
public long this[int i]=>Value[i];

public static A077873Inst Instance=new A077873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077872
{
public static readonly long[] Value={ 1L,2L,2L,0L,-3L,-4L,0L,8L,13L,6L,-14L,-32L,-23L,24L,80L,80L,-23L,-182L,-238L,-32L,389L,660L,304L,-744L,-1707L,-1266L,1186L,4160L,4241L,-1104L,-9504L,-12640L,-2031L,20114L,34786L,16704L,-38195L,-89684L,-68192L,59688L,217565L,226070L,-51182L,-494816L,-669703L,-123704L,1040816L,1834224L,917113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077872Inst : IEnumerable<long>
{
public static readonly long[] Value=A077872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077872.Bytes);
public long this[int i]=>Value[i];

public static A077872Inst Instance=new A077872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077871
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,8L,9L,14L,22L,27L,34L,52L,73L,90L,122L,179L,238L,304L,425L,598L,782L,1035L,1450L,1980L,2601L,3522L,4882L,6563L,8726L,11928L,16329L,21854L,29382L,40187L,54514L,73092L,98953L,134890L,182122L,245139L,332798L,451904L,609385L,823078L,1117502L,1513195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077871Inst : IEnumerable<long>
{
public static readonly long[] Value=A077871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077871.Bytes);
public long this[int i]=>Value[i];

public static A077871Inst Instance=new A077871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077870
{
public static readonly long[] Value={ 1L,2L,3L,2L,-1L,-6L,-9L,-6L,7L,26L,39L,26L,-25L,-102L,-153L,-102L,103L,410L,615L,410L,-409L,-1638L,-2457L,-1638L,1639L,6554L,9831L,6554L,-6553L,-26214L,-39321L,-26214L,26215L,104858L,157287L,104858L,-104857L,-419430L,-629145L,-419430L,419431L,1677722L,2516583L,1677722L,-1677721L,-6710886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077870Inst : IEnumerable<long>
{
public static readonly long[] Value=A077870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077870.Bytes);
public long this[int i]=>Value[i];

public static A077870Inst Instance=new A077870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077869
{
public static readonly long[] Value={ 1L,2L,3L,3L,2L,0L,-2L,-3L,-2L,1L,5L,8L,8L,4L,-3L,-10L,-13L,-9L,2L,16L,26L,25L,10L,-15L,-39L,-48L,-32L,8L,57L,90L,83L,27L,-62L,-144L,-170L,-107L,38L,209L,317L,280L,72L,-244L,-523L,-594L,-349L,175L,770L,1120L,946L,177L,-942L,-1887L,-2063L,-1120L,768L,2832L,3953L,3186L,355L,-3597L,-6782L,-7136L,-3538L,3245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077869Inst : IEnumerable<long>
{
public static readonly long[] Value=A077869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077869.Bytes);
public long this[int i]=>Value[i];

public static A077869Inst Instance=new A077869Inst();

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