using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A020057
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,11L,58L,364L,2653L,21951L,203550L,2091015L,23571444L,289285911L,3839613003L,54801749236L,836972170164L,13619819859947L,235251433944553L,4298685292986837L,82847389283019056L,1679542528192113596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020057Inst : IEnumerable<long>
{
public static readonly long[] Value=A020057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020057.Bytes);
public long this[int i]=>Value[i];

public static A020057Inst Instance=new A020057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020056
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,17L,92L,587L,4323L,36162L,338610L,3509239L,39877720L,493033634L,6588722212L,94638009963L,1453983971264L,23792464984330L,413123710182463L,7586453586987048L,146901328548021942L,2991445235886992290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020056Inst : IEnumerable<long>
{
public static readonly long[] Value=A020056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020056.Bytes);
public long this[int i]=>Value[i];

public static A020056Inst Instance=new A020056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020055
{
public static readonly long[] Value={ 1L,0L,0L,1L,5L,24L,136L,879L,6554L,55412L,523897L,5477110L,62737806L,781370863L,10512989797L,151960488890L,2348480282846L,38643175563195L,674499064375771L,12447573642571060L,242161887228200639L,4953311329667740358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020055Inst : IEnumerable<long>
{
public static readonly long[] Value=A020055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020055.Bytes);
public long this[int i]=>Value[i];

public static A020055Inst Instance=new A020055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020054
{
public static readonly long[] Value={ 1L,0L,0L,2L,7L,34L,191L,1255L,9470L,80933L,772544L,8146833L,94058896L,1180011610L,15983793633L,232491543752L,3614186725611L,59798362187391L,1049189445651506L,19457695173900667L,380309496580785766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020054Inst : IEnumerable<long>
{
public static readonly long[] Value=A020054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020054.Bytes);
public long this[int i]=>Value[i];

public static A020054Inst Instance=new A020054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020053
{
public static readonly long[] Value={ 1L,0L,1L,2L,9L,46L,260L,1731L,13220L,114177L,1100259L,11702761L,136177584L,1720789475L,23465311032L,343446825119L,5370259447316L,89341588987179L,1575660751228445L,29364586727439203L,576613703011533457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020053Inst : IEnumerable<long>
{
public static readonly long[] Value=A020053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020053.Bytes);
public long this[int i]=>Value[i];

public static A020053Inst Instance=new A020053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020052
{
public static readonly long[] Value={ 1L,0L,1L,3L,12L,60L,345L,2325L,17972L,156848L,1525707L,16366684L,191936576L,2442829156L,33533382055L,493855262996L,7766996408941L,129920667204109L,2303139100436492L,43131514062719762L,850867141055471683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020052Inst : IEnumerable<long>
{
public static readonly long[] Value=A020052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020052.Bytes);
public long this[int i]=>Value[i];

public static A020052Inst Instance=new A020052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020051
{
public static readonly long[] Value={ 1L,0L,1L,4L,16L,77L,448L,3059L,23919L,210929L,2070940L,22403814L,264772349L,3393900115L,46897528866L,694936109571L,10992625733214L,184875978240420L,3294153794102034L,61989985034465559L,1228528794319408360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020051Inst : IEnumerable<long>
{
public static readonly long[] Value=A020051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020051.Bytes);
public long this[int i]=>Value[i];

public static A020051Inst Instance=new A020051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020050
{
public static readonly long[] Value={ 1L,0L,1L,5L,19L,96L,572L,3955L,31285L,278720L,2761871L,30129503L,358814994L,4631975383L,64426566694L,960541539816L,15281342678896L,258393612570434L,4627594697852333L,87503608832116847L,1742117303112144502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020050Inst : IEnumerable<long>
{
public static readonly long[] Value=A020050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020050.Bytes);
public long this[int i]=>Value[i];

public static A020050Inst Instance=new A020050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020049
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,2L,12L,73L,518L,4192L,38083L,384010L,4256112L,51428023L,672849973L,9475970454L,142929221023L,2298778304796L,39270796040272L,710146895061597L,13551969914092152L,272168729108017392L,5738224038694033364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020049Inst : IEnumerable<long>
{
public static readonly long[] Value=A020049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020049.Bytes);
public long this[int i]=>Value[i];

public static A020049Inst Instance=new A020049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020048
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,21L,116L,748L,5549L,46704L,439802L,4581280L,52302949L,649428293L,8713162939L,125614765716L,1936560971459L,31791875948134L,553708506096681L,10197464987280554L,198000778503030764L,4042515894436878101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020048Inst : IEnumerable<long>
{
public static readonly long[] Value=A020048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020048.Bytes);
public long this[int i]=>Value[i];

public static A020048Inst Instance=new A020048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020047
{
public static readonly long[] Value={ 1L,0L,0L,2L,8L,39L,218L,1440L,10922L,93754L,898484L,9508956L,110145408L,1385996396L,18826451052L,274552411175L,4278441740820L,70950825535270L,1247552015661833L,23183674957715736L,454013634588599833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020047Inst : IEnumerable<long>
{
public static readonly long[] Value=A020047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020047.Bytes);
public long this[int i]=>Value[i];

public static A020047Inst Instance=new A020047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020046
{
public static readonly long[] Value={ 1L,0L,1L,5L,20L,98L,583L,4038L,31970L,285069L,2826941L,30860773L,367757553L,4750201727L,66106974037L,986095696055L,15695356495547L,265513114049683L,4757109960056836L,89988663411075164L,1792274212937247027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020046Inst : IEnumerable<long>
{
public static readonly long[] Value=A020046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020046.Bytes);
public long this[int i]=>Value[i];

public static A020046Inst Instance=new A020046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020045
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,30L,162L,1056L,7918L,67304L,639384L,6713531L,77205601L,965070017L,13028445232L,188912455860L,2928143065834L,48314360586264L,845501310259627L,15641774239803107L,305014597676160594L,6252799252361292173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020045Inst : IEnumerable<long>
{
public static readonly long[] Value=A020045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020045.Bytes);
public long this[int i]=>Value[i];

public static A020045Inst Instance=new A020045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020044
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,15L,80L,506L,3710L,30920L,288591L,2982109L,33797241L,416832633L,5557768440L,79661347641L,1221473997164L,19950741953682L,345812860530488L,6339902443058941L,122571447232472866L,2492286093726948268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020044Inst : IEnumerable<long>
{
public static readonly long[] Value=A020044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020044.Bytes);
public long this[int i]=>Value[i];

public static A020044Inst Instance=new A020044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020043
{
public static readonly long[] Value={ 1L,1L,1L,3L,11L,51L,287L,1915L,14684L,127262L,1230202L,13122150L,153091745L,1939162101L,26501882045L,388694270000L,6089543563341L,101492392722343L,1793032271428052L,33469935733323642L,658242069422031619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020043Inst : IEnumerable<long>
{
public static readonly long[] Value=A020043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020043.Bytes);
public long this[int i]=>Value[i];

public static A020043Inst Instance=new A020043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020042
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,10L,51L,319L,2310L,19061L,176310L,1807181L,20330789L,249052162L,3299941145L,47024161317L,717118460090L,11653174976468L,201017268344078L,3668565147279424L,70619879085128903L,1430052551473860293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020042Inst : IEnumerable<long>
{
public static readonly long[] Value=A020042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020042.Bytes);
public long this[int i]=>Value[i];

public static A020042Inst Instance=new A020042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020041
{
public static readonly long[] Value={ 1L,1L,1L,4L,14L,64L,370L,2495L,19339L,169215L,1649844L,17735823L,208395916L,2657047924L,36534408953L,538882532061L,8487399879954L,142163947989232L,2523410076808877L,47313938940166438L,934450294068287158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020041Inst : IEnumerable<long>
{
public static readonly long[] Value=A020041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020041.Bytes);
public long this[int i]=>Value[i];

public static A020041Inst Instance=new A020041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020040
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,7L,37L,229L,1647L,13507L,124269L,1267543L,14196477L,173197024L,2286200718L,32464050199L,493453563029L,7993947721071L,137495900802424L,2502425394604114L,48046567576398986L,970540665043259525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020040Inst : IEnumerable<long>
{
public static readonly long[] Value=A020040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020040.Bytes);
public long this[int i]=>Value[i];

public static A020040Inst Instance=new A020040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020039
{
public static readonly long[] Value={ 1L,0L,1L,1L,5L,20L,109L,695L,5142L,43193L,406016L,4222569L,48137291L,596902408L,7998492273L,115178288736L,1773745646540L,29089428603255L,506156057696641L,9313271461618196L,180677466355392996L,3685820313650017111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020039Inst : IEnumerable<long>
{
public static readonly long[] Value=A020039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020039.Bytes);
public long this[int i]=>Value[i];

public static A020039Inst Instance=new A020039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020038
{
public static readonly long[] Value={ 1L,1L,1L,2L,9L,41L,231L,1528L,11610L,99850L,958562L,10160756L,117864768L,1485096081L,20197306708L,294880677942L,4600138575888L,76362300359740L,1343976486331426L,24997962645764522L,489960067856984638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020038Inst : IEnumerable<long>
{
public static readonly long[] Value=A020038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020038.Bytes);
public long this[int i]=>Value[i];

public static A020038Inst Instance=new A020038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020037
{
public static readonly long[] Value={ 1L,1L,1L,4L,15L,74L,427L,2901L,22624L,199095L,1951127L,21072175L,248651668L,3182741351L,43921830648L,650043093588L,10270680878694L,172547438762056L,3071344409964594L,57741274907334370L,1143277243165220534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020037Inst : IEnumerable<long>
{
public static readonly long[] Value=A020037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020037.Bytes);
public long this[int i]=>Value[i];

public static A020037Inst Instance=new A020037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020036
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,6L,29L,177L,1269L,10366L,95020L,966032L,10787363L,131246245L,1728075563L,24481070470L,371296235455L,6002622473192L,103045019123133L,1871984514070245L,35879703186346359L,723574014257984910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020036Inst : IEnumerable<long>
{
public static readonly long[] Value=A020036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020036.Bytes);
public long this[int i]=>Value[i];

public static A020036Inst Instance=new A020036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020035
{
public static readonly long[] Value={ 1L,1L,2L,4L,17L,80L,468L,3197L,25042L,221209L,2175217L,23564850L,278850730L,3578584369L,49503750432L,734305631413L,11626505830701L,195712848150141L,3490212458677514L,65732334638426516L,1303691303662125906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020035Inst : IEnumerable<long>
{
public static readonly long[] Value=A020035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020035.Bytes);
public long this[int i]=>Value[i];

public static A020035Inst Instance=new A020035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020034
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,5L,23L,144L,1028L,8370L,76527L,776207L,8649165L,105025576L,1380336142L,19521896861L,295617295326L,4772107767405L,81807561726950L,1484222905617529L,28412267050392705L,572304236300767347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020034Inst : IEnumerable<long>
{
public static readonly long[] Value=A020034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020034.Bytes);
public long this[int i]=>Value[i];

public static A020034Inst Instance=new A020034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020033
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,12L,62L,393L,2862L,23714L,220205L,2264965L,25561752L,314044379L,4172303889L,59604341272L,911094930877L,14837831731420L,256482519928831L,4689966078698629L,90449345803473559L,1834829586299035049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020033Inst : IEnumerable<long>
{
public static readonly long[] Value=A020033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020033.Bytes);
public long this[int i]=>Value[i];

public static A020033Inst Instance=new A020033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020032
{
public static readonly long[] Value={ 1L,0L,1L,1L,5L,23L,123L,788L,5853L,49330L,465113L,4850460L,55433829L,688963306L,9251792972L,133490155744L,2059562402903L,33835668047686L,589707357402530L,10867464157846630L,211139303638163097L,4313274345751046120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020032Inst : IEnumerable<long>
{
public static readonly long[] Value=A020032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020032.Bytes);
public long this[int i]=>Value[i];

public static A020032Inst Instance=new A020032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020031
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,38L,210L,1380L,10450L,89574L,857352L,9063435L,104876887L,1318452295L,17893281148L,260730668151L,4059948975491L,67279154450986L,1182190856781603L,21954973054515490L,429690186924088871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020031Inst : IEnumerable<long>
{
public static readonly long[] Value=A020031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020031.Bytes);
public long this[int i]=>Value[i];

public static A020031Inst Instance=new A020031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020030
{
public static readonly long[] Value={ 1L,1L,1L,3L,12L,58L,333L,2233L,17225L,150104L,1458150L,15623032L,183012659L,2326875239L,31911431853L,469553925838L,7378704548888L,123329776031415L,2184698889699346L,40885079221516335L,806020133224179176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020030Inst : IEnumerable<long>
{
public static readonly long[] Value=A020030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020030.Bytes);
public long this[int i]=>Value[i];

public static A020030Inst Instance=new A020030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020029
{
public static readonly long[] Value={ 1L,1L,2L,5L,18L,85L,499L,3422L,26889L,238158L,2347553L,25487720L,302211543L,3885576978L,53842995268L,799953072548L,12684970150411L,213832353964067L,3818434892215474L,72004772253206073L,1429809049027949160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020029Inst : IEnumerable<long>
{
public static readonly long[] Value=A020029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020029.Bytes);
public long this[int i]=>Value[i];

public static A020029Inst Instance=new A020029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020028
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,4L,20L,121L,862L,7000L,63876L,646743L,7195013L,87239530L,1145018832L,16173391002L,244622538903L,3944538439806L,67550220781672L,1224347751667801L,23415650750646696L,471239971356764754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020028Inst : IEnumerable<long>
{
public static readonly long[] Value=A020028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020028.Bytes);
public long this[int i]=>Value[i];

public static A020028Inst Instance=new A020028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020027
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,18L,97L,620L,4570L,38270L,358778L,3722325L,42341447L,523975411L,7008171125L,100742459918L,1548915321246L,25363488385399L,440690610696307L,8097689971544645L,156892743198677493L,3196689642673053919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020027Inst : IEnumerable<long>
{
public static readonly long[] Value=A020027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020027.Bytes);
public long this[int i]=>Value[i];

public static A020027Inst Instance=new A020027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020026
{
public static readonly long[] Value={ 1L,1L,1L,3L,10L,45L,251L,1666L,12701L,109544L,1054364L,11202617L,130230419L,1644159040L,22401666926L,327624378798L,5119130918712L,85105551523595L,1499985345603354L,27937227061862467L,548268081089050918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020026Inst : IEnumerable<long>
{
public static readonly long[] Value=A020026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020026.Bytes);
public long this[int i]=>Value[i];

public static A020026Inst Instance=new A020026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020025
{
public static readonly long[] Value={ 1L,1L,2L,5L,18L,89L,523L,3599L,28342L,251532L,2483877L,27012163L,320769441L,4129906549L,57302453361L,852373993744L,13531437150692L,228343001917932L,4081631159283027L,77040788131467135L,1531185664112909315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020025Inst : IEnumerable<long>
{
public static readonly long[] Value=A020025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020025.Bytes);
public long this[int i]=>Value[i];

public static A020025Inst Instance=new A020025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020024
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,3L,17L,104L,740L,6006L,54717L,553254L,6147264L,74450194L,976124761L,13774204959L,208143541601L,3353423725801L,57380805974819L,1039230152655058L,19860842917407766L,399423618672311730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020024Inst : IEnumerable<long>
{
public static readonly long[] Value=A020024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020024.Bytes);
public long this[int i]=>Value[i];

public static A020024Inst Instance=new A020024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020023
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,8L,43L,267L,1927L,15845L,146123L,1493701L,16762640L,204876709L,2708925368L,38526938568L,586465620430L,9513775620310L,163848357905336L,2985681188497227L,57391427290002261L,1160582196308934615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020023Inst : IEnumerable<long>
{
public static readonly long[] Value=A020023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020023.Bytes);
public long this[int i]=>Value[i];

public static A020023Inst Instance=new A020023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020022
{
public static readonly long[] Value={ 1L,0L,1L,2L,5L,24L,131L,843L,6275L,52988L,500442L,5226842L,59818300L,744405515L,10008118595L,144561713037L,2232675345794L,36715105686391L,640474621418148L,11813198572823623L,229701083360459334L,4696111037591613052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020022Inst : IEnumerable<long>
{
public static readonly long[] Value=A020022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020022.Bytes);
public long this[int i]=>Value[i];

public static A020022Inst Instance=new A020022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020021
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,36L,199L,1303L,9844L,84217L,804738L,8494461L,98158214L,1232430908L,16706285647L,243169268857L,3782633071104L,62623591954943L,1099391947653438L,20399828362013787L,398929976857158503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020021Inst : IEnumerable<long>
{
public static readonly long[] Value=A020021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020021.Bytes);
public long this[int i]=>Value[i];

public static A020021Inst Instance=new A020021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020020
{
public static readonly long[] Value={ 1L,1L,1L,4L,15L,69L,401L,2715L,21115L,185345L,1812263L,19532171L,230045569L,2939471158L,40499380397L,598490843643L,9442855533027L,158430131720783L,2816535675036147L,52888281009012092L,1046012668844905826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020020Inst : IEnumerable<long>
{
public static readonly long[] Value=A020020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020020.Bytes);
public long this[int i]=>Value[i];

public static A020020Inst Instance=new A020020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020019
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,92L,543L,3741L,29513L,262341L,2594262L,28248627L,335844793L,4328666215L,60120364101L,895125421053L,14222548356739L,240203038913808L,4296965473902563L,81164903395937306L,1614279745319197539L,BigInteger.Parse("33720510235556570814") };
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
public class A020019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020019.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A020019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020019Inst Instance=new A020019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020018
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,3L,15L,91L,649L,5253L,47802L,482796L,5359036L,64844333L,849460756L,11977396665L,180858689642L,2911824903230L,49792205845229L,901238925798638L,17213663482753993L,345994636003355265L,7300486819670796088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020018Inst : IEnumerable<long>
{
public static readonly long[] Value=A020018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020018.Bytes);
public long this[int i]=>Value[i];

public static A020018Inst Instance=new A020018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020017
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,13L,67L,425L,3103L,25751L,239483L,2466678L,27873456L,342843514L,4559818741L,65205407995L,997642742322L,16261576699844L,281325276907304L,5148252567403659L,99361274550890613L,2017033873383079454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020017Inst : IEnumerable<long>
{
public static readonly long[] Value=A020017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020017.Bytes);
public long this[int i]=>Value[i];

public static A020017Inst Instance=new A020017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020016
{
public static readonly long[] Value={ 1L,1L,1L,3L,12L,56L,318L,2134L,16430L,142945L,1386570L,14836295L,173584650L,2204525052L,30201993206L,443969300123L,6970318011936L,116404310799339L,2060356301148292L,38528662831473069L,759014657780019468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020016Inst : IEnumerable<long>
{
public static readonly long[] Value=A020016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020016.Bytes);
public long this[int i]=>Value[i];

public static A020016Inst Instance=new A020016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020015
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,95L,559L,3858L,30478L,271252L,2685395L,29270806L,348322597L,4493361500L,62457724854L,930620100318L,14796859595058L,250066927156482L,4476197996101023L,84600142126309335L,1683542828313555775L,BigInteger.Parse("35186045111753315688") };
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
public class A020015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A020015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020015Inst Instance=new A020015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020014
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,3L,13L,81L,577L,4665L,42405L,427909L,4745900L,57382240L,751185683L,10584889175L,159735600270L,2570291022522L,43928610203109L,794708493674422L,15171707606511701L,304813398276280545L,6428791672736098775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020014Inst : IEnumerable<long>
{
public static readonly long[] Value=A020014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020014.Bytes);
public long this[int i]=>Value[i];

public static A020014Inst Instance=new A020014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020013
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,6L,32L,200L,1435L,11742L,107810L,1097700L,12274283L,149523080L,1970986053L,27952165839L,424364699555L,6866992410974L,117987415061287L,2145225728387030L,41149329880878478L,830468293959547465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020013Inst : IEnumerable<long>
{
public static readonly long[] Value=A020013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020013.Bytes);
public long this[int i]=>Value[i];

public static A020013Inst Instance=new A020013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020012
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,11L,58L,365L,2653L,21951L,203550L,2091015L,23571445L,289285911L,3839613004L,54801749237L,836972170164L,13619819859948L,235251433944553L,4298685292986838L,82847389283019056L,1679542528192113596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020012Inst : IEnumerable<long>
{
public static readonly long[] Value=A020012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020012.Bytes);
public long this[int i]=>Value[i];

public static A020012Inst Instance=new A020012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020011
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,17L,92L,587L,4324L,36162L,338611L,3509239L,39877720L,493033635L,6588722213L,94638009964L,1453983971265L,23792464984330L,413123710182463L,7586453586987049L,146901328548021943L,2991445235886992290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020011Inst : IEnumerable<long>
{
public static readonly long[] Value=A020011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020011.Bytes);
public long this[int i]=>Value[i];

public static A020011Inst Instance=new A020011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020010
{
public static readonly long[] Value={ 1L,0L,1L,2L,6L,25L,136L,879L,6554L,55412L,523897L,5477110L,62737807L,781370863L,10512989797L,151960488890L,2348480282846L,38643175563195L,674499064375772L,12447573642571061L,242161887228200640L,4953311329667740359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020010Inst : IEnumerable<long>
{
public static readonly long[] Value=A020010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020010.Bytes);
public long this[int i]=>Value[i];

public static A020010Inst Instance=new A020010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020009
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,35L,192L,1255L,9471L,80933L,772545L,8146834L,94058896L,1180011610L,15983793633L,232491543753L,3614186725612L,59798362187392L,1049189445651507L,19457695173900667L,380309496580785766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020009Inst : IEnumerable<long>
{
public static readonly long[] Value=A020009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020009.Bytes);
public long this[int i]=>Value[i];

public static A020009Inst Instance=new A020009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020008
{
public static readonly long[] Value={ 1L,1L,1L,3L,10L,46L,261L,1731L,13221L,114178L,1100260L,11702761L,136177584L,1720789476L,23465311033L,343446825119L,5370259447317L,89341588987180L,1575660751228445L,29364586727439204L,576613703011533457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020008Inst : IEnumerable<long>
{
public static readonly long[] Value=A020008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020008.Bytes);
public long this[int i]=>Value[i];

public static A020008Inst Instance=new A020008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020007
{
public static readonly long[] Value={ 1L,1L,1L,3L,13L,60L,346L,2326L,17972L,156848L,1525708L,16366685L,191936577L,2442829156L,33533382055L,493855262996L,7766996408941L,129920667204110L,2303139100436492L,43131514062719763L,850867141055471684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020007Inst : IEnumerable<long>
{
public static readonly long[] Value=A020007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020007.Bytes);
public long this[int i]=>Value[i];

public static A020007Inst Instance=new A020007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020006
{
public static readonly long[] Value={ 1L,1L,1L,4L,16L,77L,449L,3060L,23920L,210929L,2070941L,22403814L,264772349L,3393900115L,46897528867L,694936109571L,10992625733214L,184875978240420L,3294153794102035L,61989985034465559L,1228528794319408361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020006Inst : IEnumerable<long>
{
public static readonly long[] Value=A020006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020006.Bytes);
public long this[int i]=>Value[i];

public static A020006Inst Instance=new A020006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020005
{
public static readonly long[] Value={ 1L,1L,2L,5L,20L,97L,573L,3956L,31285L,278721L,2761871L,30129503L,358814994L,4631975383L,64426566695L,960541539816L,15281342678897L,258393612570435L,4627594697852333L,87503608832116847L,1742117303112144502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020005Inst : IEnumerable<long>
{
public static readonly long[] Value=A020005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020005.Bytes);
public long this[int i]=>Value[i];

public static A020005Inst Instance=new A020005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020004
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,2L,12L,73L,519L,4193L,38084L,384010L,4256112L,51428023L,672849973L,9475970455L,142929221024L,2298778304796L,39270796040273L,710146895061598L,13551969914092152L,272168729108017393L,5738224038694033364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020004Inst : IEnumerable<long>
{
public static readonly long[] Value=A020004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020004.Bytes);
public long this[int i]=>Value[i];

public static A020004Inst Instance=new A020004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020003
{
public static readonly long[] Value={ 1L,0L,1L,1L,5L,22L,117L,748L,5549L,46705L,439803L,4581280L,52302950L,649428294L,8713162940L,125614765716L,1936560971460L,31791875948135L,553708506096682L,10197464987280554L,198000778503030764L,4042515894436878102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020003Inst : IEnumerable<long>
{
public static readonly long[] Value=A020003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020003.Bytes);
public long this[int i]=>Value[i];

public static A020003Inst Instance=new A020003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020002
{
public static readonly long[] Value={ 1L,1L,1L,2L,9L,39L,219L,1440L,10923L,93755L,898484L,9508956L,110145409L,1385996396L,18826451052L,274552411176L,4278441740820L,70950825535270L,1247552015661833L,23183674957715736L,454013634588599834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020002Inst : IEnumerable<long>
{
public static readonly long[] Value=A020002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020002.Bytes);
public long this[int i]=>Value[i];

public static A020002Inst Instance=new A020002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020001
{
public static readonly long[] Value={ 1L,1L,2L,5L,20L,99L,584L,4038L,31970L,285070L,2826941L,30860774L,367757553L,4750201727L,66106974037L,986095696055L,15695356495548L,265513114049684L,4757109960056837L,89988663411075165L,1792274212937247027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020001Inst : IEnumerable<long>
{
public static readonly long[] Value=A020001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020001.Bytes);
public long this[int i]=>Value[i];

public static A020001Inst Instance=new A020001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020000
{
public static readonly long[] Value={ 1L,23L,362L,4870L,60411L,715533L,8243572L,93366380L,1046230421L,11644889443L,129058033182L,1426436938290L,15738640474831L,173461105001753L,1910430676985192L,21031277618176600L,231459987587209641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020000Inst : IEnumerable<long>
{
public static readonly long[] Value=A020000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020000.Bytes);
public long this[int i]=>Value[i];

public static A020000Inst Instance=new A020000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019999
{
public static readonly BigInteger[] Value={ 4L,36L,384L,4800L,69120L,1128960L,20643840L,418037760L,9289728000L,224811417600L,5885971660800L,165788201779200L,4999151930572800L,160687026339840000L,5484783832399872000L,BigInteger.Parse("198137815945445376000") };
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
public class A019999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019999Inst Instance=new A019999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019998
{
public static readonly long[] Value={ 2L,4L,7L,14L,87L,110L,178L,1551L,2311L,2820L,2862L,5158L,9267L,15867L,25023L,34363L,68486L,2570490L,4313372L,21511363L,22412883L,54933234L,66947210L,341535842L,995434171L,1491645143L,4258696422L,26212684635L,28500533228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019998Inst : IEnumerable<long>
{
public static readonly long[] Value=A019998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019998.Bytes);
public long this[int i]=>Value[i];

public static A019998Inst Instance=new A019998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019997
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,10L,17L,25L,88L,102L,108L,148L,194L,205L,548L,640L,746L,2135L,3658L,5689L,12200L,16992L,17460L,38961L,44699L,85493L,138435L,256776L,810597L,932623L,2457564L,2674604L,2890162L,3618191L,3950533L,4103765L,4233447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019997Inst : IEnumerable<long>
{
public static readonly long[] Value=A019997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019997.Bytes);
public long this[int i]=>Value[i];

public static A019997Inst Instance=new A019997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019980
{
public static readonly long[] Value={ 7L,1L,1L,5L,3L,6L,9L,7L,2L,2L,3L,8L,4L,2L,0L,8L,7L,4L,8L,2L,3L,0L,5L,6L,6L,1L,4L,3L,6L,3L,1L,5L,8L,4L,0L,6L,2L,5L,3L,4L,1L,6L,8L,8L,8L,3L,3L,5L,7L,5L,1L,2L,2L,8L,1L,9L,8L,4L,1L,2L,0L,2L,5L,2L,6L,9L,1L,6L,2L,3L,8L,7L,6L,3L,6L,0L,8L,8L,8L,2L,5L,1L,4L,7L,1L,1L,9L,1L,5L,1L,3L,1L,2L,3L,4L,9L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019980Inst : IEnumerable<long>
{
public static readonly long[] Value=A019980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019980.Bytes);
public long this[int i]=>Value[i];

public static A019980Inst Instance=new A019980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019979
{
public static readonly long[] Value={ 6L,3L,1L,3L,7L,5L,1L,5L,1L,4L,6L,7L,5L,0L,4L,3L,0L,9L,8L,9L,7L,9L,4L,6L,4L,2L,4L,4L,7L,6L,8L,1L,8L,6L,0L,5L,9L,4L,4L,7L,3L,2L,0L,5L,0L,3L,1L,4L,9L,3L,1L,8L,1L,5L,1L,3L,1L,0L,0L,5L,3L,4L,9L,5L,7L,8L,5L,3L,8L,4L,2L,1L,4L,1L,3L,2L,8L,9L,5L,8L,1L,7L,8L,6L,9L,0L,0L,8L,1L,3L,0L,0L,4L,5L,8L,8L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019979Inst : IEnumerable<long>
{
public static readonly long[] Value=A019979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019979.Bytes);
public long this[int i]=>Value[i];

public static A019979Inst Instance=new A019979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019978
{
public static readonly long[] Value={ 5L,6L,7L,1L,2L,8L,1L,8L,1L,9L,6L,1L,7L,7L,0L,9L,5L,3L,0L,9L,9L,4L,4L,1L,8L,4L,3L,9L,8L,6L,3L,9L,6L,4L,4L,2L,1L,6L,2L,5L,3L,7L,8L,2L,6L,0L,6L,8L,9L,7L,5L,0L,3L,0L,3L,2L,1L,5L,9L,0L,9L,9L,8L,8L,8L,7L,5L,2L,4L,3L,4L,1L,6L,6L,8L,0L,9L,4L,4L,9L,9L,4L,1L,7L,9L,8L,5L,9L,8L,2L,6L,9L,8L,1L,7L,2L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019978Inst : IEnumerable<long>
{
public static readonly long[] Value=A019978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019978.Bytes);
public long this[int i]=>Value[i];

public static A019978Inst Instance=new A019978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019977
{
public static readonly long[] Value={ 5L,1L,4L,4L,5L,5L,4L,0L,1L,5L,9L,7L,0L,3L,1L,0L,1L,3L,4L,7L,2L,3L,2L,2L,0L,7L,1L,7L,1L,2L,9L,1L,7L,3L,5L,9L,8L,0L,0L,8L,2L,9L,3L,4L,4L,2L,9L,7L,3L,5L,9L,6L,9L,7L,2L,2L,7L,0L,8L,4L,5L,9L,5L,4L,2L,9L,2L,4L,4L,9L,9L,6L,3L,2L,3L,0L,5L,7L,8L,0L,5L,2L,2L,9L,3L,5L,3L,8L,4L,9L,2L,9L,4L,7L,1L,3L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019977Inst : IEnumerable<long>
{
public static readonly long[] Value=A019977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019977.Bytes);
public long this[int i]=>Value[i];

public static A019977Inst Instance=new A019977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019976
{
public static readonly long[] Value={ 4L,7L,0L,4L,6L,3L,0L,1L,0L,9L,4L,7L,8L,4L,5L,4L,2L,3L,3L,5L,8L,6L,2L,3L,4L,5L,3L,7L,4L,0L,2L,9L,0L,0L,2L,7L,5L,6L,9L,9L,2L,6L,0L,7L,4L,7L,8L,0L,2L,4L,8L,6L,1L,7L,2L,2L,1L,6L,3L,0L,1L,6L,6L,1L,6L,4L,3L,0L,1L,4L,3L,9L,4L,5L,9L,3L,2L,7L,6L,5L,3L,8L,7L,3L,7L,8L,0L,2L,4L,0L,3L,7L,4L,9L,5L,8L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019976Inst : IEnumerable<long>
{
public static readonly long[] Value=A019976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019976.Bytes);
public long this[int i]=>Value[i];

public static A019976Inst Instance=new A019976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019975
{
public static readonly long[] Value={ 4L,3L,3L,1L,4L,7L,5L,8L,7L,4L,2L,8L,4L,1L,5L,5L,5L,4L,5L,5L,4L,6L,1L,6L,7L,7L,5L,4L,5L,5L,7L,4L,4L,1L,3L,5L,8L,3L,6L,8L,1L,6L,3L,8L,3L,0L,3L,4L,0L,8L,3L,6L,3L,5L,0L,1L,8L,9L,2L,3L,6L,3L,2L,7L,3L,7L,4L,8L,9L,7L,8L,4L,3L,7L,9L,8L,4L,6L,6L,2L,8L,9L,0L,6L,1L,3L,7L,8L,3L,3L,9L,7L,0L,6L,7L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019975Inst : IEnumerable<long>
{
public static readonly long[] Value=A019975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019975.Bytes);
public long this[int i]=>Value[i];

public static A019975Inst Instance=new A019975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019974
{
public static readonly long[] Value={ 4L,0L,1L,0L,7L,8L,0L,9L,3L,3L,5L,3L,5L,8L,4L,4L,7L,1L,6L,3L,4L,5L,7L,1L,5L,1L,2L,9L,4L,6L,3L,4L,1L,8L,0L,7L,8L,5L,2L,0L,1L,2L,1L,2L,3L,8L,0L,0L,9L,8L,3L,4L,9L,5L,0L,2L,7L,2L,9L,8L,9L,0L,8L,2L,2L,1L,7L,3L,8L,2L,5L,8L,4L,5L,9L,1L,3L,5L,3L,8L,9L,8L,1L,4L,9L,5L,3L,7L,6L,9L,6L,9L,6L,2L,4L,0L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019974Inst : IEnumerable<long>
{
public static readonly long[] Value=A019974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019974.Bytes);
public long this[int i]=>Value[i];

public static A019974Inst Instance=new A019974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019973
{
public static readonly long[] Value={ 3L,7L,3L,2L,0L,5L,0L,8L,0L,7L,5L,6L,8L,8L,7L,7L,2L,9L,3L,5L,2L,7L,4L,4L,6L,3L,4L,1L,5L,0L,5L,8L,7L,2L,3L,6L,6L,9L,4L,2L,8L,0L,5L,2L,5L,3L,8L,1L,0L,3L,8L,0L,6L,2L,8L,0L,5L,5L,8L,0L,6L,9L,7L,9L,4L,5L,1L,9L,3L,3L,0L,1L,6L,9L,0L,8L,8L,0L,0L,0L,3L,7L,0L,8L,1L,1L,4L,6L,1L,8L,6L,7L,5L,7L,2L,4L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019973Inst : IEnumerable<long>
{
public static readonly long[] Value=A019973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019973.Bytes);
public long this[int i]=>Value[i];

public static A019973Inst Instance=new A019973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019972
{
public static readonly long[] Value={ 3L,4L,8L,7L,4L,1L,4L,4L,4L,3L,8L,4L,0L,9L,0L,8L,6L,5L,0L,6L,9L,6L,2L,2L,4L,2L,2L,5L,0L,9L,9L,3L,8L,4L,9L,6L,3L,4L,3L,0L,4L,9L,0L,8L,0L,4L,0L,9L,1L,3L,6L,9L,9L,5L,3L,5L,4L,4L,3L,7L,9L,9L,4L,5L,4L,8L,9L,7L,8L,5L,3L,2L,1L,8L,5L,7L,5L,5L,4L,4L,5L,1L,8L,0L,2L,4L,1L,1L,7L,7L,3L,0L,4L,2L,8L,5L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019972Inst : IEnumerable<long>
{
public static readonly long[] Value=A019972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019972.Bytes);
public long this[int i]=>Value[i];

public static A019972Inst Instance=new A019972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019971
{
public static readonly long[] Value={ 3L,2L,7L,0L,8L,5L,2L,6L,1L,8L,4L,8L,4L,1L,4L,0L,8L,6L,5L,3L,0L,8L,8L,5L,6L,2L,5L,7L,3L,0L,5L,4L,1L,0L,7L,7L,7L,1L,0L,5L,9L,4L,2L,6L,8L,4L,3L,1L,8L,8L,1L,0L,7L,0L,3L,6L,4L,0L,0L,8L,8L,0L,3L,4L,8L,2L,3L,6L,6L,1L,1L,6L,1L,0L,0L,9L,2L,6L,7L,9L,9L,4L,3L,4L,1L,5L,8L,5L,5L,4L,2L,5L,1L,2L,0L,4L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019971Inst : IEnumerable<long>
{
public static readonly long[] Value=A019971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019971.Bytes);
public long this[int i]=>Value[i];

public static A019971Inst Instance=new A019971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019970
{
public static readonly long[] Value={ 3L,0L,7L,7L,6L,8L,3L,5L,3L,7L,1L,7L,5L,2L,5L,3L,4L,0L,2L,5L,7L,0L,2L,9L,0L,5L,7L,6L,0L,3L,6L,9L,0L,9L,8L,2L,4L,0L,0L,6L,7L,0L,2L,1L,4L,3L,5L,3L,7L,7L,9L,2L,4L,2L,7L,0L,3L,9L,1L,5L,6L,2L,5L,0L,3L,7L,4L,8L,6L,3L,2L,8L,8L,4L,9L,5L,0L,9L,0L,9L,1L,8L,4L,5L,4L,5L,9L,3L,7L,2L,1L,6L,6L,7L,1L,0L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019970Inst : IEnumerable<long>
{
public static readonly long[] Value=A019970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019970.Bytes);
public long this[int i]=>Value[i];

public static A019970Inst Instance=new A019970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019969
{
public static readonly long[] Value={ 2L,9L,0L,4L,2L,1L,0L,8L,7L,7L,6L,7L,5L,8L,2L,2L,8L,0L,2L,5L,7L,9L,3L,2L,5L,5L,3L,4L,5L,2L,7L,0L,9L,1L,2L,5L,4L,0L,3L,1L,2L,6L,1L,9L,2L,1L,8L,4L,6L,2L,2L,1L,6L,6L,8L,3L,6L,3L,0L,2L,4L,7L,1L,1L,3L,9L,3L,7L,3L,9L,8L,9L,5L,2L,7L,7L,3L,0L,3L,3L,9L,8L,5L,0L,1L,1L,1L,4L,3L,0L,9L,6L,7L,6L,8L,8L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019969Inst : IEnumerable<long>
{
public static readonly long[] Value=A019969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019969.Bytes);
public long this[int i]=>Value[i];

public static A019969Inst Instance=new A019969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019968
{
public static readonly long[] Value={ 2L,7L,4L,7L,4L,7L,7L,4L,1L,9L,4L,5L,4L,6L,2L,2L,2L,7L,8L,7L,6L,1L,6L,6L,4L,0L,2L,6L,4L,9L,7L,6L,7L,2L,7L,1L,7L,7L,5L,1L,8L,7L,2L,5L,9L,9L,1L,7L,0L,8L,2L,5L,8L,2L,1L,5L,0L,5L,2L,7L,3L,0L,0L,2L,5L,1L,9L,8L,9L,8L,2L,5L,3L,8L,8L,1L,5L,9L,3L,1L,8L,4L,3L,4L,0L,6L,0L,4L,2L,4L,5L,9L,5L,0L,7L,0L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019968Inst : IEnumerable<long>
{
public static readonly long[] Value=A019968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019968.Bytes);
public long this[int i]=>Value[i];

public static A019968Inst Instance=new A019968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019967
{
public static readonly long[] Value={ 2L,6L,0L,5L,0L,8L,9L,0L,6L,4L,6L,9L,3L,8L,0L,1L,5L,3L,6L,2L,5L,8L,4L,1L,2L,3L,3L,6L,4L,3L,3L,5L,4L,1L,1L,8L,6L,0L,9L,3L,2L,8L,7L,2L,6L,7L,9L,4L,3L,1L,9L,5L,0L,2L,3L,7L,5L,2L,0L,1L,0L,9L,6L,8L,0L,0L,2L,4L,1L,4L,2L,6L,5L,5L,8L,1L,3L,9L,1L,6L,6L,6L,1L,4L,4L,8L,1L,8L,6L,7L,5L,8L,4L,0L,6L,0L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019967Inst : IEnumerable<long>
{
public static readonly long[] Value=A019967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019967.Bytes);
public long this[int i]=>Value[i];

public static A019967Inst Instance=new A019967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019966
{
public static readonly long[] Value={ 2L,4L,7L,5L,0L,8L,6L,8L,5L,3L,4L,1L,6L,2L,9L,5L,8L,2L,5L,2L,4L,0L,0L,1L,3L,2L,4L,6L,0L,7L,6L,1L,7L,4L,3L,2L,1L,4L,1L,2L,2L,5L,6L,6L,4L,5L,3L,7L,9L,4L,6L,6L,5L,5L,5L,4L,7L,3L,7L,4L,1L,2L,9L,5L,4L,2L,9L,9L,5L,4L,4L,5L,5L,1L,3L,7L,9L,2L,2L,0L,3L,9L,9L,5L,1L,9L,2L,3L,2L,0L,1L,9L,8L,5L,2L,0L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019966Inst : IEnumerable<long>
{
public static readonly long[] Value=A019966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019966.Bytes);
public long this[int i]=>Value[i];

public static A019966Inst Instance=new A019966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019965
{
public static readonly long[] Value={ 2L,3L,5L,5L,8L,5L,2L,3L,6L,5L,8L,2L,3L,7L,5L,2L,8L,3L,3L,9L,3L,9L,5L,8L,6L,6L,6L,2L,3L,4L,3L,8L,8L,3L,1L,8L,7L,4L,4L,1L,8L,3L,8L,3L,3L,2L,4L,1L,1L,2L,7L,9L,0L,3L,8L,8L,9L,3L,0L,0L,0L,0L,9L,7L,2L,3L,1L,9L,5L,8L,2L,2L,1L,6L,3L,7L,0L,9L,3L,7L,6L,0L,3L,8L,8L,8L,1L,5L,1L,7L,6L,5L,5L,4L,0L,1L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019965Inst : IEnumerable<long>
{
public static readonly long[] Value=A019965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019965.Bytes);
public long this[int i]=>Value[i];

public static A019965Inst Instance=new A019965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019964
{
public static readonly long[] Value={ 2L,2L,4L,6L,0L,3L,6L,7L,7L,3L,9L,0L,4L,2L,1L,6L,0L,5L,4L,1L,6L,3L,3L,2L,1L,4L,3L,8L,4L,1L,6L,4L,0L,9L,1L,5L,9L,1L,4L,0L,3L,6L,3L,1L,0L,1L,0L,2L,6L,8L,9L,7L,0L,8L,1L,4L,1L,0L,4L,2L,8L,3L,5L,4L,8L,4L,5L,3L,3L,1L,9L,8L,5L,8L,3L,8L,7L,9L,3L,4L,1L,3L,2L,3L,6L,0L,7L,8L,6L,9L,4L,7L,7L,6L,1L,9L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019964Inst : IEnumerable<long>
{
public static readonly long[] Value=A019964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019964.Bytes);
public long this[int i]=>Value[i];

public static A019964Inst Instance=new A019964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019963
{
public static readonly long[] Value={ 2L,1L,4L,4L,5L,0L,6L,9L,2L,0L,5L,0L,9L,5L,5L,8L,6L,1L,6L,3L,5L,6L,2L,6L,0L,7L,9L,1L,0L,4L,5L,9L,2L,2L,1L,8L,0L,6L,8L,5L,9L,3L,1L,5L,7L,4L,2L,7L,6L,0L,6L,8L,9L,8L,4L,2L,9L,9L,1L,3L,6L,5L,2L,6L,7L,0L,4L,2L,5L,5L,0L,3L,9L,4L,9L,8L,9L,7L,5L,5L,8L,0L,0L,7L,4L,7L,4L,0L,2L,7L,1L,4L,8L,3L,5L,3L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019963Inst : IEnumerable<long>
{
public static readonly long[] Value=A019963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019963.Bytes);
public long this[int i]=>Value[i];

public static A019963Inst Instance=new A019963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019962
{
public static readonly long[] Value={ 2L,0L,5L,0L,3L,0L,3L,8L,4L,1L,5L,7L,9L,2L,9L,6L,2L,1L,6L,8L,9L,9L,0L,1L,1L,0L,7L,0L,5L,4L,1L,4L,9L,4L,1L,4L,6L,7L,6L,7L,5L,1L,9L,6L,2L,2L,7L,4L,3L,2L,4L,2L,4L,2L,3L,4L,7L,2L,6L,6L,6L,0L,9L,6L,7L,8L,5L,4L,8L,1L,1L,4L,4L,7L,7L,0L,6L,5L,7L,7L,4L,2L,9L,4L,9L,7L,7L,0L,8L,8L,6L,9L,4L,2L,9L,1L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019962Inst : IEnumerable<long>
{
public static readonly long[] Value=A019962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019962.Bytes);
public long this[int i]=>Value[i];

public static A019962Inst Instance=new A019962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019961
{
public static readonly long[] Value={ 1L,9L,6L,2L,6L,1L,0L,5L,0L,5L,5L,0L,5L,1L,5L,0L,5L,8L,2L,3L,0L,4L,6L,4L,0L,4L,2L,6L,2L,1L,1L,8L,9L,4L,9L,8L,5L,0L,5L,6L,7L,1L,0L,7L,5L,2L,5L,7L,6L,7L,3L,4L,1L,8L,7L,0L,2L,0L,9L,6L,3L,5L,7L,2L,7L,5L,6L,2L,7L,0L,3L,1L,7L,4L,8L,3L,4L,8L,7L,9L,8L,7L,8L,3L,4L,9L,9L,1L,9L,3L,0L,5L,9L,4L,9L,2L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019961Inst : IEnumerable<long>
{
public static readonly long[] Value=A019961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019961.Bytes);
public long this[int i]=>Value[i];

public static A019961Inst Instance=new A019961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019960
{
public static readonly long[] Value={ 1L,8L,8L,0L,7L,2L,6L,4L,6L,5L,3L,4L,6L,3L,3L,2L,0L,1L,2L,3L,6L,0L,8L,3L,7L,5L,9L,5L,8L,2L,9L,2L,7L,7L,9L,5L,5L,3L,7L,5L,6L,3L,7L,4L,9L,7L,7L,7L,5L,2L,0L,4L,5L,4L,6L,5L,4L,2L,5L,1L,4L,8L,5L,1L,0L,8L,4L,8L,3L,8L,9L,2L,6L,4L,1L,0L,8L,2L,2L,3L,7L,7L,8L,8L,6L,5L,7L,7L,1L,4L,3L,9L,5L,3L,2L,9L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019960Inst : IEnumerable<long>
{
public static readonly long[] Value=A019960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019960.Bytes);
public long this[int i]=>Value[i];

public static A019960Inst Instance=new A019960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019959
{
public static readonly long[] Value={ 1L,8L,0L,4L,0L,4L,7L,7L,5L,5L,2L,7L,1L,4L,2L,3L,9L,3L,7L,3L,8L,1L,7L,8L,4L,7L,4L,8L,2L,3L,7L,0L,0L,7L,7L,2L,4L,3L,1L,5L,6L,5L,7L,0L,5L,5L,6L,9L,8L,5L,2L,1L,7L,6L,9L,4L,5L,6L,6L,7L,7L,8L,6L,4L,5L,8L,1L,4L,4L,5L,2L,9L,9L,9L,9L,3L,2L,2L,4L,9L,4L,0L,1L,6L,4L,1L,3L,4L,0L,9L,2L,7L,7L,8L,5L,8L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019959Inst : IEnumerable<long>
{
public static readonly long[] Value=A019959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019959.Bytes);
public long this[int i]=>Value[i];

public static A019959Inst Instance=new A019959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019958
{
public static readonly long[] Value={ 1L,22L,329L,4178L,48621L,537222L,5744929L,60136378L,620564021L,6341995022L,64384199529L,650640568578L,6554239839421L,65878458172822L,661143103694129L,6627971208280778L,66395645870074821L,664768758151070622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019958Inst : IEnumerable<long>
{
public static readonly long[] Value=A019958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019958.Bytes);
public long this[int i]=>Value[i];

public static A019958Inst Instance=new A019958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019957
{
public static readonly long[] Value={ 1L,6L,6L,4L,2L,7L,9L,4L,8L,2L,3L,5L,0L,5L,1L,7L,9L,1L,1L,0L,3L,0L,4L,9L,6L,1L,7L,0L,0L,3L,4L,7L,8L,2L,4L,2L,3L,7L,6L,9L,4L,8L,3L,8L,6L,1L,1L,0L,8L,5L,5L,4L,8L,9L,2L,9L,4L,1L,0L,5L,4L,5L,4L,5L,6L,2L,4L,4L,4L,1L,6L,7L,2L,1L,6L,8L,4L,7L,3L,0L,6L,6L,4L,2L,9L,1L,4L,0L,4L,0L,2L,2L,8L,1L,6L,7L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019957Inst : IEnumerable<long>
{
public static readonly long[] Value=A019957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019957.Bytes);
public long this[int i]=>Value[i];

public static A019957Inst Instance=new A019957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019956
{
public static readonly long[] Value={ 1L,6L,0L,0L,3L,3L,4L,5L,2L,9L,0L,4L,1L,0L,5L,0L,3L,5L,5L,3L,2L,6L,7L,3L,3L,0L,8L,1L,1L,8L,3L,3L,5L,7L,5L,2L,5L,5L,0L,4L,0L,7L,1L,8L,4L,6L,9L,2L,2L,7L,5L,9L,1L,4L,8L,4L,1L,1L,5L,0L,0L,2L,2L,9L,7L,2L,3L,8L,4L,5L,7L,2L,8L,1L,6L,6L,0L,3L,8L,1L,2L,6L,2L,0L,8L,2L,7L,9L,1L,4L,9L,6L,2L,4L,0L,4L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019956Inst : IEnumerable<long>
{
public static readonly long[] Value=A019956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019956.Bytes);
public long this[int i]=>Value[i];

public static A019956Inst Instance=new A019956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019955
{
public static readonly long[] Value={ 1L,5L,3L,9L,8L,6L,4L,9L,6L,3L,8L,1L,4L,5L,8L,2L,9L,0L,4L,8L,2L,6L,7L,9L,6L,9L,7L,2L,6L,0L,2L,7L,8L,0L,1L,2L,5L,7L,0L,8L,3L,8L,7L,0L,3L,2L,1L,6L,5L,4L,8L,1L,6L,7L,9L,7L,9L,9L,1L,8L,5L,5L,0L,3L,0L,0L,2L,3L,3L,3L,5L,6L,6L,9L,4L,9L,0L,8L,4L,1L,2L,5L,4L,0L,8L,1L,5L,7L,6L,6L,3L,6L,7L,8L,2L,9L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019955Inst : IEnumerable<long>
{
public static readonly long[] Value=A019955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019955.Bytes);
public long this[int i]=>Value[i];

public static A019955Inst Instance=new A019955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019954
{
public static readonly long[] Value={ 1L,4L,8L,2L,5L,6L,0L,9L,6L,8L,5L,1L,2L,7L,4L,0L,2L,5L,4L,7L,8L,7L,1L,5L,7L,1L,4L,9L,1L,5L,4L,4L,3L,0L,0L,3L,0L,4L,7L,9L,8L,4L,6L,2L,3L,1L,4L,6L,5L,8L,4L,7L,0L,0L,4L,9L,8L,4L,7L,0L,3L,7L,3L,8L,8L,0L,6L,7L,8L,6L,8L,7L,6L,6L,1L,3L,9L,6L,5L,2L,7L,8L,7L,5L,7L,3L,8L,0L,1L,9L,1L,1L,3L,8L,2L,0L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019954Inst : IEnumerable<long>
{
public static readonly long[] Value=A019954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019954.Bytes);
public long this[int i]=>Value[i];

public static A019954Inst Instance=new A019954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019953
{
public static readonly long[] Value={ 1L,4L,2L,8L,1L,4L,8L,0L,0L,6L,7L,4L,2L,1L,1L,4L,5L,0L,2L,1L,6L,0L,6L,1L,8L,4L,8L,4L,9L,9L,8L,5L,0L,0L,7L,3L,9L,6L,3L,3L,8L,0L,1L,6L,1L,2L,0L,7L,5L,3L,1L,9L,0L,9L,7L,6L,1L,1L,7L,9L,4L,1L,2L,7L,2L,8L,1L,6L,9L,5L,5L,1L,7L,5L,2L,7L,9L,8L,8L,5L,3L,2L,9L,3L,7L,3L,0L,2L,5L,6L,4L,1L,2L,5L,3L,4L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019953Inst : IEnumerable<long>
{
public static readonly long[] Value=A019953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019953.Bytes);
public long this[int i]=>Value[i];

public static A019953Inst Instance=new A019953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019952
{
public static readonly long[] Value={ 1L,3L,7L,6L,3L,8L,1L,9L,2L,0L,4L,7L,1L,1L,7L,3L,5L,3L,8L,2L,0L,7L,2L,0L,9L,5L,8L,1L,9L,1L,0L,8L,8L,7L,6L,7L,9L,5L,2L,5L,8L,9L,9L,3L,3L,6L,0L,0L,8L,1L,5L,8L,6L,6L,3L,3L,6L,5L,6L,7L,5L,7L,6L,5L,6L,1L,9L,0L,9L,5L,1L,9L,3L,7L,6L,7L,1L,7L,2L,9L,8L,5L,0L,6L,5L,9L,5L,2L,9L,9L,3L,1L,1L,0L,0L,7L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019952Inst : IEnumerable<long>
{
public static readonly long[] Value=A019952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019952.Bytes);
public long this[int i]=>Value[i];

public static A019952Inst Instance=new A019952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019951
{
public static readonly long[] Value={ 1L,3L,2L,7L,0L,4L,4L,8L,2L,1L,6L,2L,0L,4L,1L,0L,0L,3L,7L,1L,5L,9L,4L,7L,2L,5L,7L,4L,0L,8L,6L,9L,3L,2L,4L,1L,9L,9L,0L,6L,0L,4L,1L,2L,9L,5L,5L,8L,7L,6L,2L,3L,0L,1L,6L,2L,0L,7L,7L,3L,5L,6L,8L,2L,5L,1L,5L,9L,1L,6L,3L,4L,0L,3L,0L,2L,6L,0L,2L,8L,9L,8L,6L,9L,2L,4L,9L,6L,3L,3L,6L,7L,6L,5L,4L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019951Inst : IEnumerable<long>
{
public static readonly long[] Value=A019951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019951.Bytes);
public long this[int i]=>Value[i];

public static A019951Inst Instance=new A019951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019950
{
public static readonly long[] Value={ 1L,2L,7L,9L,9L,4L,1L,6L,3L,2L,1L,9L,3L,0L,7L,8L,7L,8L,0L,3L,1L,1L,0L,2L,9L,8L,4L,7L,5L,7L,1L,9L,9L,1L,1L,9L,2L,1L,2L,3L,1L,5L,1L,8L,8L,5L,2L,7L,0L,4L,5L,9L,3L,8L,0L,7L,0L,0L,2L,9L,1L,0L,9L,6L,1L,4L,0L,4L,2L,2L,0L,1L,5L,7L,8L,2L,3L,3L,6L,3L,3L,9L,2L,8L,5L,8L,4L,2L,0L,4L,3L,8L,9L,2L,4L,4L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019950Inst : IEnumerable<long>
{
public static readonly long[] Value=A019950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019950.Bytes);
public long this[int i]=>Value[i];

public static A019950Inst Instance=new A019950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019949
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,9L,7L,1L,5L,6L,5L,3L,5L,0L,5L,1L,3L,9L,8L,5L,5L,6L,1L,7L,4L,6L,9L,5L,3L,7L,5L,9L,3L,5L,1L,4L,0L,0L,5L,3L,6L,2L,5L,5L,8L,4L,0L,7L,7L,9L,7L,6L,5L,3L,6L,4L,2L,1L,2L,5L,9L,2L,0L,8L,8L,4L,3L,7L,5L,7L,3L,0L,1L,3L,4L,7L,7L,4L,0L,2L,1L,4L,1L,2L,3L,1L,2L,8L,7L,0L,4L,0L,6L,4L,3L,5L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019949Inst : IEnumerable<long>
{
public static readonly long[] Value=A019949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019949.Bytes);
public long this[int i]=>Value[i];

public static A019949Inst Instance=new A019949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019892
{
public static readonly long[] Value={ 9L,9L,2L,5L,4L,6L,1L,5L,1L,6L,4L,1L,3L,2L,2L,0L,3L,4L,9L,8L,0L,0L,6L,1L,5L,8L,9L,3L,3L,0L,5L,8L,4L,1L,0L,9L,0L,4L,3L,6L,5L,2L,8L,7L,7L,4L,0L,6L,8L,2L,8L,2L,3L,2L,2L,3L,5L,5L,5L,3L,5L,7L,6L,0L,1L,0L,0L,9L,7L,4L,7L,1L,6L,8L,7L,0L,1L,2L,1L,9L,2L,9L,5L,9L,0L,9L,2L,8L,4L,8L,3L,5L,0L,4L,0L,9L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019892Inst : IEnumerable<long>
{
public static readonly long[] Value=A019892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019892.Bytes);
public long this[int i]=>Value[i];

public static A019892Inst Instance=new A019892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019891
{
public static readonly long[] Value={ 9L,9L,0L,2L,6L,8L,0L,6L,8L,7L,4L,1L,5L,7L,0L,3L,1L,5L,0L,8L,3L,7L,7L,4L,8L,6L,7L,3L,4L,4L,8L,5L,0L,7L,5L,9L,2L,5L,1L,0L,8L,9L,7L,9L,3L,7L,6L,8L,8L,8L,6L,5L,0L,0L,0L,8L,9L,7L,1L,4L,1L,2L,7L,6L,0L,0L,9L,9L,5L,8L,1L,7L,7L,2L,9L,3L,3L,6L,4L,5L,4L,9L,8L,9L,9L,1L,8L,6L,1L,6L,7L,5L,9L,6L,4L,9L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019891Inst : IEnumerable<long>
{
public static readonly long[] Value=A019891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019891.Bytes);
public long this[int i]=>Value[i];

public static A019891Inst Instance=new A019891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019890
{
public static readonly long[] Value={ 9L,8L,7L,6L,8L,8L,3L,4L,0L,5L,9L,5L,1L,3L,7L,7L,2L,6L,1L,9L,0L,0L,4L,0L,2L,4L,7L,6L,9L,3L,4L,3L,7L,2L,6L,0L,7L,5L,8L,4L,0L,6L,8L,6L,1L,5L,8L,9L,8L,8L,0L,4L,3L,4L,9L,2L,3L,9L,0L,4L,8L,0L,1L,6L,3L,8L,0L,7L,2L,9L,3L,5L,9L,6L,9L,7L,1L,2L,7L,3L,5L,7L,1L,1L,9L,6L,3L,0L,3L,7L,9L,9L,9L,8L,8L,6L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019890Inst : IEnumerable<long>
{
public static readonly long[] Value=A019890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019890.Bytes);
public long this[int i]=>Value[i];

public static A019890Inst Instance=new A019890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019889
{
public static readonly long[] Value={ 9L,8L,4L,8L,0L,7L,7L,5L,3L,0L,1L,2L,2L,0L,8L,0L,5L,9L,3L,6L,6L,7L,4L,3L,0L,2L,4L,5L,8L,9L,5L,2L,3L,0L,1L,3L,6L,7L,0L,6L,4L,3L,2L,5L,1L,7L,1L,9L,8L,4L,2L,4L,1L,8L,7L,9L,0L,0L,2L,5L,7L,5L,2L,3L,5L,5L,8L,2L,7L,5L,9L,9L,9L,4L,3L,0L,3L,6L,2L,3L,9L,2L,7L,4L,6L,7L,8L,4L,1L,0L,0L,5L,6L,1L,1L,9L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019889Inst : IEnumerable<long>
{
public static readonly long[] Value=A019889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019889.Bytes);
public long this[int i]=>Value[i];

public static A019889Inst Instance=new A019889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019888
{
public static readonly long[] Value={ 9L,8L,1L,6L,2L,7L,1L,8L,3L,4L,4L,7L,6L,6L,3L,9L,5L,3L,4L,9L,6L,5L,0L,4L,8L,9L,9L,8L,1L,8L,1L,4L,0L,8L,1L,9L,3L,1L,8L,2L,5L,3L,3L,0L,4L,6L,2L,9L,4L,7L,2L,8L,9L,7L,0L,2L,5L,4L,5L,6L,9L,4L,9L,6L,0L,1L,1L,6L,9L,1L,4L,4L,3L,2L,6L,1L,0L,9L,8L,0L,3L,1L,1L,1L,9L,6L,4L,0L,2L,3L,1L,0L,7L,3L,9L,8L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019888Inst : IEnumerable<long>
{
public static readonly long[] Value=A019888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019888.Bytes);
public long this[int i]=>Value[i];

public static A019888Inst Instance=new A019888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019887
{
public static readonly long[] Value={ 9L,7L,8L,1L,4L,7L,6L,0L,0L,7L,3L,3L,8L,0L,5L,6L,3L,7L,9L,2L,8L,5L,6L,6L,7L,4L,7L,8L,6L,9L,5L,9L,9L,5L,3L,2L,4L,5L,9L,7L,3L,7L,8L,0L,8L,8L,6L,2L,6L,7L,7L,1L,0L,7L,8L,8L,5L,1L,7L,7L,6L,6L,3L,6L,4L,0L,5L,9L,6L,8L,3L,3L,1L,2L,0L,0L,9L,5L,1L,2L,1L,9L,9L,9L,7L,5L,8L,5L,2L,5L,4L,5L,4L,7L,8L,5L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019887Inst : IEnumerable<long>
{
public static readonly long[] Value=A019887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019887.Bytes);
public long this[int i]=>Value[i];

public static A019887Inst Instance=new A019887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019886
{
public static readonly long[] Value={ 9L,7L,4L,3L,7L,0L,0L,6L,4L,7L,8L,5L,2L,3L,5L,2L,2L,8L,5L,3L,9L,6L,9L,4L,4L,8L,0L,0L,8L,8L,2L,6L,8L,8L,3L,3L,0L,0L,5L,1L,2L,0L,9L,8L,8L,9L,4L,4L,5L,6L,7L,9L,4L,4L,5L,9L,7L,9L,7L,2L,2L,2L,2L,6L,6L,8L,5L,8L,6L,9L,9L,0L,0L,3L,2L,4L,3L,0L,4L,2L,7L,0L,2L,0L,5L,8L,7L,3L,4L,5L,1L,9L,4L,8L,9L,7L,6L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019886Inst : IEnumerable<long>
{
public static readonly long[] Value=A019886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019886.Bytes);
public long this[int i]=>Value[i];

public static A019886Inst Instance=new A019886Inst();

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