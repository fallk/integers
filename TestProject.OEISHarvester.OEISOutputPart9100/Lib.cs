using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A136912
{
public static readonly long[] Value={ 0L,5L,25L,26L,50L,75L,76L,225L,250L,255L,260L,265L,266L,275L,500L,505L,525L,526L,725L,726L,750L,755L,760L,775L,2250L,2500L,2505L,2550L,2600L,2650L,2660L,2750L,2766L,2775L,5000L,5005L,5025L,5026L,5050L,5075L,5076L,5250L,5260L,5265L,7075L,7225L,7250L,7260L,7500L,7525L,7550L,7600L,7750L,22500L,25000L,25005L,25025L,25050L,25500L,25505L,26000L,26005L,26500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136912Inst : IEnumerable<long>
{
public static readonly long[] Value=A136912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136912.Bytes);
public long this[int i]=>Value[i];

public static A136912Inst Instance=new A136912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136911
{
public static readonly long[] Value={ 0L,5L,25L,50L,225L,250L,255L,500L,505L,2250L,2500L,2550L,5000L,5005L,5025L,5050L,22500L,25000L,25005L,25025L,25500L,25505L,50000L,50005L,50025L,50050L,50225L,50250L,50255L,50500L,225000L,250000L,250005L,250050L,250250L,255000L,255050L,256255L,500000L,500005L,500025L,500050L,500225L,500250L,500255L,500500L,500505L,502250L,502500L,502550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136911Inst : IEnumerable<long>
{
public static readonly long[] Value=A136911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136911.Bytes);
public long this[int i]=>Value[i];

public static A136911Inst Instance=new A136911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136910
{
public static readonly long[] Value={ 0L,5L,50L,500L,505L,5000L,5005L,5050L,50000L,50005L,50050L,50500L,500000L,500005L,500050L,500500L,500505L,505000L,5000000L,5000005L,5000050L,5000500L,5000505L,5005000L,5005050L,5050000L,5050005L,50000000L,50000005L,50000050L,50000500L,50000505L,50005000L,50005005L,50005050L,50050000L,50050500L,50500000L,50500005L,50500050L,500000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136910Inst : IEnumerable<long>
{
public static readonly long[] Value=A136910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136910.Bytes);
public long this[int i]=>Value[i];

public static A136910Inst Instance=new A136910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136909
{
public static readonly long[] Value={ 0L,2L,20L,22L,200L,202L,220L,222L,288L,298L,498L,2000L,2002L,2020L,2022L,2200L,2202L,2220L,2880L,2980L,2998L,4980L,4998L,20000L,20002L,20020L,20022L,20200L,20220L,20222L,22000L,22002L,22020L,22200L,22202L,28800L,28998L,29800L,29980L,29998L,44998L,48998L,49800L,49980L,49998L,89498L,200000L,200002L,200020L,200022L,200200L,200202L,200220L,200222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136909Inst : IEnumerable<long>
{
public static readonly long[] Value=A136909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136909.Bytes);
public long this[int i]=>Value[i];

public static A136909Inst Instance=new A136909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136908
{
public static readonly long[] Value={ 0L,2L,20L,22L,200L,202L,220L,2000L,2002L,2020L,2022L,2200L,2202L,20000L,20002L,20020L,20022L,20200L,20220L,22000L,22002L,22020L,200000L,200002L,200020L,200022L,200200L,200202L,200220L,202000L,202002L,202200L,220000L,220002L,220020L,220200L,2000000L,2000002L,2000020L,2000022L,2000200L,2000202L,2000220L,2002000L,2002020L,2002200L,2020000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136908Inst : IEnumerable<long>
{
public static readonly long[] Value=A136908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136908.Bytes);
public long this[int i]=>Value[i];

public static A136908Inst Instance=new A136908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136907
{
public static readonly long[] Value={ 0L,2L,7L,20L,27L,47L,70L,97L,200L,270L,470L,497L,700L,970L,997L,2000L,2700L,4700L,4970L,4997L,7000L,9700L,9970L,9997L,20000L,22247L,27000L,44747L,44777L,47000L,49700L,49777L,49970L,49997L,70000L,97000L,99700L,99970L,99997L,200000L,222470L,270000L,447470L,447770L,470000L,497000L,497770L,499297L,499700L,499777L,499970L,499997L,700000L,704997L,970000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136907Inst : IEnumerable<long>
{
public static readonly long[] Value=A136907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136907.Bytes);
public long this[int i]=>Value[i];

public static A136907Inst Instance=new A136907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136906
{
public static readonly long[] Value={ 0L,2L,20L,22L,28L,88L,200L,202L,220L,278L,280L,448L,472L,478L,878L,880L,2000L,2002L,2020L,2022L,2200L,2202L,2780L,2800L,2878L,4480L,4720L,4780L,8780L,8800L,20000L,20002L,20020L,20022L,20200L,20220L,22000L,22002L,22020L,27800L,28000L,28780L,44800L,47200L,47202L,47800L,84878L,87800L,88000L,88022L,200000L,200002L,200020L,200022L,200200L,200202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136906Inst : IEnumerable<long>
{
public static readonly long[] Value=A136906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136906.Bytes);
public long this[int i]=>Value[i];

public static A136906Inst Instance=new A136906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136905
{
public static readonly long[] Value={ 0L,2L,20L,64L,200L,264L,492L,640L,964L,2000L,2064L,2640L,4902L,4920L,4992L,6400L,9640L,20000L,20602L,20640L,20992L,24992L,26400L,49020L,49200L,49902L,49920L,49992L,64000L,96400L,200000L,206020L,206400L,209920L,209992L,222402L,246962L,249920L,249992L,264000L,490200L,492000L,494262L,494462L,494662L,499002L,499020L,499200L,499902L,499920L,499992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136905Inst : IEnumerable<long>
{
public static readonly long[] Value=A136905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136905.Bytes);
public long this[int i]=>Value[i];

public static A136905Inst Instance=new A136905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136904
{
public static readonly long[] Value={ 0L,2L,8L,20L,22L,68L,80L,200L,202L,220L,262L,668L,680L,800L,2000L,2002L,2020L,2022L,2200L,2202L,2620L,6668L,6680L,6800L,8000L,8262L,20000L,20002L,20020L,20022L,20200L,20220L,20602L,22000L,22002L,22020L,24622L,26200L,66668L,66680L,66800L,68000L,80000L,82620L,200000L,200002L,200020L,200022L,200200L,200202L,200220L,202000L,202002L,202200L,206020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136904Inst : IEnumerable<long>
{
public static readonly long[] Value=A136904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136904.Bytes);
public long this[int i]=>Value[i];

public static A136904Inst Instance=new A136904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136855
{
public static readonly long[] Value={ 0L,1L,4L,10L,40L,100L,400L,1000L,1051L,4000L,4051L,6416L,6451L,6454L,10000L,10510L,40000L,40510L,64160L,64510L,64540L,100000L,100501L,100504L,105100L,400000L,400501L,405100L,641600L,645100L,645400L,664116L,664466L,664504L,1000000L,1005010L,1005040L,1051000L,1051454L,1054116L,4000000L,4001451L,4005010L,4051000L,4051551L,4056546L,4056551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136855Inst : IEnumerable<long>
{
public static readonly long[] Value=A136855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136855.Bytes);
public long this[int i]=>Value[i];

public static A136855Inst Instance=new A136855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136854
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,10000L,100000L,100501L,1000000L,1005010L,10000000L,10005001L,10050100L,100000000L,100050010L,100501000L,1000000000L,1000050001L,1000500100L,1005010000L,10000000000L,10000500010L,10005001000L,10050100000L,100000000000L,100000500001L,100005000100L,100050010000L,100501000000L,1000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136854Inst : IEnumerable<long>
{
public static readonly long[] Value=A136854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136854.Bytes);
public long this[int i]=>Value[i];

public static A136854Inst Instance=new A136854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136853
{
public static readonly long[] Value={ 0L,1L,3L,10L,30L,100L,300L,1000L,3000L,10000L,30000L,100000L,300000L,1000000L,3000000L,10000000L,30000000L,100000000L,300000000L,1000000000L,3000000000L,10000000000L,30000000000L,100000000000L,300000000000L,1000000000000L,3000000000000L,10000000000000L,30000000000000L,100000000000000L,300000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136853Inst : IEnumerable<long>
{
public static readonly long[] Value=A136853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136853.Bytes);
public long this[int i]=>Value[i];

public static A136853Inst Instance=new A136853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136852
{
public static readonly long[] Value={ 0L,1L,3L,9L,10L,30L,33L,90L,99L,100L,109L,300L,303L,330L,333L,900L,901L,990L,999L,1000L,1009L,1090L,3000L,3003L,3030L,3033L,3300L,3303L,3330L,3333L,8991L,9000L,9001L,9010L,9391L,9900L,9990L,9999L,10000L,10009L,10090L,10099L,10900L,10901L,11803L,30000L,30003L,30030L,30033L,30300L,30330L,31833L,33000L,33003L,33030L,33300L,33303L,33330L,33333L,89891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136852Inst : IEnumerable<long>
{
public static readonly long[] Value=A136852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136852.Bytes);
public long this[int i]=>Value[i];

public static A136852Inst Instance=new A136852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136851
{
public static readonly long[] Value={ 3L,7L,13L,23L,37L,59L,97L,107L,241L,251L,613L,911L,937L,983L,997L,1223L,1381L,1499L,1621L,1979L,2281L,2399L,2521L,2663L,2677L,3299L,3361L,3623L,3637L,3671L,3697L,3803L,3889L,3911L,4273L,4451L,4729L,4787L,4909L,5003L,5821L,5927L,6229L,6791L,6793L,6827L,6829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136851Inst : IEnumerable<long>
{
public static readonly long[] Value=A136851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136851.Bytes);
public long this[int i]=>Value[i];

public static A136851Inst Instance=new A136851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136850
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,13L,19L,30L,31L,60L,63L,100L,103L,130L,190L,199L,300L,301L,306L,310L,369L,600L,603L,630L,1000L,1003L,1030L,1300L,1900L,1990L,1999L,3000L,3001L,3006L,3010L,3060L,3100L,3690L,6000L,6003L,6030L,6300L,10000L,10003L,10030L,10300L,10301L,13000L,19000L,19900L,19990L,19999L,30000L,30001L,30006L,30010L,30060L,30100L,30103L,30600L,31000L,31131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136850Inst : IEnumerable<long>
{
public static readonly long[] Value=A136850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136850.Bytes);
public long this[int i]=>Value[i];

public static A136850Inst Instance=new A136850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136849
{
public static readonly long[] Value={ 0L,1L,6L,10L,60L,100L,600L,1000L,6000L,8131L,10000L,10301L,10631L,10801L,31801L,60000L,60306L,81310L,100000L,103010L,103131L,106310L,108010L,116881L,136631L,318010L,600000L,603060L,813100L,1000000L,1003001L,1008001L,1030100L,1031310L,1063100L,1080100L,1080801L,1086881L,1168810L,1366310L,1366881L,3168381L,3180100L,6000000L,6003006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136849Inst : IEnumerable<long>
{
public static readonly long[] Value=A136849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136849.Bytes);
public long this[int i]=>Value[i];

public static A136849Inst Instance=new A136849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136848
{
public static readonly long[] Value={ 0L,1L,6L,10L,60L,100L,131L,600L,1000L,1310L,6000L,10000L,10301L,10376L,11731L,13100L,60000L,61376L,100000L,103010L,103131L,103760L,106631L,117310L,131000L,600000L,603076L,603131L,613760L,1000000L,1003001L,1030100L,1031076L,1031310L,1037306L,1037600L,1066310L,1077776L,1173076L,1173100L,1310000L,1331076L,3336731L,3337306L,3371376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136848Inst : IEnumerable<long>
{
public static readonly long[] Value=A136848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136848.Bytes);
public long this[int i]=>Value[i];

public static A136848Inst Instance=new A136848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136847
{
public static readonly long[] Value={ 0L,1L,6L,10L,60L,100L,600L,1000L,6000L,10000L,10301L,60000L,100000L,103010L,103131L,600000L,1000000L,1003001L,1030100L,1031310L,6000000L,10000000L,10030010L,10301000L,10313100L,60000000L,100000000L,100030001L,100300100L,103010000L,103131000L,600000000L,1000000000L,1000300010L,1003001000L,1030100000L,1031310000L,6000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136847Inst : IEnumerable<long>
{
public static readonly long[] Value=A136847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136847.Bytes);
public long this[int i]=>Value[i];

public static A136847Inst Instance=new A136847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136846
{
public static readonly long[] Value={ 0L,1L,3L,10L,30L,100L,300L,1000L,3000L,10000L,10503L,30000L,30501L,100000L,105030L,300000L,305010L,550501L,550503L,1000000L,1005003L,1050300L,1055003L,3000000L,3005001L,3050100L,3055001L,5505010L,5505030L,10000000L,10050030L,10151503L,10503000L,10550030L,10550503L,10950503L,30000000L,30050010L,30151503L,30501000L,30550010L,30550501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136846Inst : IEnumerable<long>
{
public static readonly long[] Value=A136846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136846.Bytes);
public long this[int i]=>Value[i];

public static A136846Inst Instance=new A136846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136845
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,10000L,58151L,100000L,550501L,581510L,1000000L,5505010L,5815100L,5818151L,10000000L,55050100L,55055001L,58151000L,58181510L,100000000L,183031501L,550501000L,550550010L,555005001L,581510000L,581815100L,1000000000L,1000550501L,1005055001L,1830315010L,3180155001L,3318358151L,5505010000L,5505500100L,5505550001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136845Inst : IEnumerable<long>
{
public static readonly long[] Value=A136845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136845.Bytes);
public long this[int i]=>Value[i];

public static A136845Inst Instance=new A136845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136844
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,10000L,100000L,130501L,550501L,1000000L,1305010L,5505010L,7553501L,10000000L,10550501L,13050100L,55050100L,55055001L,57533501L,57733501L,73055001L,75535010L,100000000L,105505010L,130501000L,131531501L,550501000L,550550010L,575335010L,575355001L,577335010L,730550010L,755350100L,757033751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136844Inst : IEnumerable<long>
{
public static readonly long[] Value=A136844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136844.Bytes);
public long this[int i]=>Value[i];

public static A136844Inst Instance=new A136844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136843
{
public static readonly long[] Value={ 0L,1L,6L,10L,56L,60L,100L,551L,560L,600L,1000L,1056L,1066L,1156L,3656L,5506L,5510L,5600L,6000L,10000L,10301L,10560L,10656L,10660L,11560L,36056L,36560L,55056L,55060L,55100L,56000L,60000L,100000L,100551L,100656L,103010L,103131L,105506L,105600L,105666L,106551L,106560L,106600L,115566L,115600L,316331L,360560L,365600L,550501L,550560L,550600L,551000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136843Inst : IEnumerable<long>
{
public static readonly long[] Value=A136843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136843.Bytes);
public long this[int i]=>Value[i];

public static A136843Inst Instance=new A136843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136842
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,10000L,100000L,550501L,1000000L,5505010L,10000000L,55050100L,55055001L,100000000L,550501000L,550550010L,1000000000L,1000550501L,1005055001L,5505010000L,5505500100L,10000000000L,10005505010L,10050550010L,55050100000L,55055001000L,100000000000L,100000550501L,100055050100L,100505500100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136842Inst : IEnumerable<long>
{
public static readonly long[] Value=A136842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136842.Bytes);
public long this[int i]=>Value[i];

public static A136842Inst Instance=new A136842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136841
{
public static readonly long[] Value={ 0L,1L,3L,10L,30L,100L,300L,1000L,1049L,1393L,3000L,10000L,10490L,10493L,13930L,30000L,33903L,44049L,100000L,100499L,104900L,104930L,109499L,139300L,300000L,339030L,440490L,1000000L,1004990L,1004993L,1049000L,1049300L,1094990L,1393000L,3000000L,3390300L,4404900L,10000000L,10004999L,10049900L,10049930L,10490000L,10493000L,10909143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136841Inst : IEnumerable<long>
{
public static readonly long[] Value=A136841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136841.Bytes);
public long this[int i]=>Value[i];

public static A136841Inst Instance=new A136841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136840
{
public static readonly long[] Value={ 0L,1L,10L,38L,100L,380L,1000L,1141L,1188L,3441L,3800L,10000L,10401L,11410L,11880L,18188L,33188L,33441L,34410L,38000L,100000L,104010L,114100L,118800L,181880L,331880L,334410L,344100L,380000L,1000000L,1004001L,1040100L,1141000L,1188000L,1818800L,3318800L,3344100L,3344848L,3441000L,3441048L,3800000L,10000000L,10040010L,10188441L,10401000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136840Inst : IEnumerable<long>
{
public static readonly long[] Value=A136840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136840.Bytes);
public long this[int i]=>Value[i];

public static A136840Inst Instance=new A136840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136807
{
public static readonly BigInteger[] Value={ 1L,4L,256L,589824L,86973087744L,1282470362637926400L,BigInteger.Parse("2723154477021188283432960000"),BigInteger.Parse("1133321924829207204666583887642624000000"),BigInteger.Parse("120746421332702772771144114237731253721340313600000000") };
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
public class A136807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136807Inst Instance=new A136807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136806
{
public static readonly long[] Value={ 3L,5L,6L,7L,10L,11L,12L,14L,20L,22L,23L,24L,27L,28L,29L,31L,39L,40L,41L,43L,44L,45L,46L,47L,48L,51L,54L,56L,57L,58L,59L,61L,62L,63L,65L,67L,73L,75L,78L,80L,82L,83L,85L,86L,88L,89L,90L,91L,92L,94L,95L,96L,99L,101L,102L,105L,108L,111L,112L,113L,114L,116L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136806Inst : IEnumerable<long>
{
public static readonly long[] Value=A136806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136806.Bytes);
public long this[int i]=>Value[i];

public static A136806Inst Instance=new A136806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136805
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,9L,13L,15L,16L,17L,18L,19L,21L,25L,26L,30L,32L,33L,34L,35L,36L,37L,38L,42L,49L,50L,52L,53L,55L,60L,64L,66L,68L,69L,70L,71L,72L,74L,76L,77L,79L,81L,84L,87L,93L,97L,98L,100L,103L,104L,106L,107L,109L,110L,115L,117L,120L,121L,123L,128L,129L,132L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136805Inst : IEnumerable<long>
{
public static readonly long[] Value=A136805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136805.Bytes);
public long this[int i]=>Value[i];

public static A136805Inst Instance=new A136805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136804
{
public static readonly long[] Value={ 3L,5L,6L,7L,10L,12L,14L,19L,20L,24L,27L,28L,33L,37L,38L,39L,40L,41L,43L,45L,47L,48L,51L,53L,54L,55L,56L,63L,65L,66L,69L,71L,74L,75L,76L,77L,78L,80L,82L,83L,85L,86L,87L,90L,91L,93L,94L,96L,97L,101L,102L,103L,105L,106L,107L,108L,109L,110L,112L,115L,119L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136804Inst : IEnumerable<long>
{
public static readonly long[] Value=A136804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136804.Bytes);
public long this[int i]=>Value[i];

public static A136804Inst Instance=new A136804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136803
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,9L,11L,13L,15L,16L,17L,18L,21L,22L,23L,25L,26L,29L,30L,31L,32L,34L,35L,36L,42L,44L,46L,49L,50L,52L,57L,58L,59L,60L,61L,62L,64L,67L,68L,70L,72L,73L,79L,81L,84L,88L,89L,92L,95L,98L,99L,100L,104L,111L,113L,114L,116L,117L,118L,120L,121L,122L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136803Inst : IEnumerable<long>
{
public static readonly long[] Value=A136803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136803.Bytes);
public long this[int i]=>Value[i];

public static A136803Inst Instance=new A136803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136802
{
public static readonly long[] Value={ 10L,14L,22L,26L,34L,38L,46L,51L,58L,62L,69L,74L,82L,86L,94L,99L,106L,111L,122L,129L,134L,146L,155L,158L,166L,172L,178L,183L,194L,206L,218L,226L,232L,237L,249L,254L,262L,267L,274L,278L,291L,302L,309L,314L,326L,334L,346L,351L,358L,362L,371L,376L,382L,386L,394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136802Inst : IEnumerable<long>
{
public static readonly long[] Value=A136802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136802.Bytes);
public long this[int i]=>Value[i];

public static A136802Inst Instance=new A136802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136801
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,17L,29L,31L,23L,37L,41L,43L,47L,11L,53L,37L,61L,43L,67L,73L,31L,79L,83L,43L,89L,61L,97L,103L,109L,113L,29L,79L,83L,127L,131L,89L,137L,139L,97L,151L,103L,157L,163L,167L,173L,13L,179L,181L,53L,47L,191L,193L,197L,199L,101L,139L,211L,109L,17L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136801Inst : IEnumerable<long>
{
public static readonly long[] Value=A136801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136801.Bytes);
public long this[int i]=>Value[i];

public static A136801Inst Instance=new A136801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136800
{
public static readonly long[] Value={ 3L,3L,3L,5L,5L,3L,3L,5L,5L,5L,3L,5L,3L,5L,7L,3L,3L,3L,13L,3L,5L,9L,5L,5L,3L,5L,5L,9L,3L,11L,11L,3L,3L,5L,9L,5L,5L,5L,5L,3L,9L,13L,3L,3L,13L,5L,9L,3L,5L,7L,5L,5L,3L,5L,7L,3L,7L,9L,9L,5L,3L,5L,7L,3L,3L,11L,7L,3L,7L,3L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136800Inst : IEnumerable<long>
{
public static readonly long[] Value=A136800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136800.Bytes);
public long this[int i]=>Value[i];

public static A136800Inst Instance=new A136800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136799
{
public static readonly long[] Value={ 10L,16L,22L,28L,36L,40L,46L,52L,58L,66L,70L,78L,82L,88L,96L,100L,106L,112L,126L,130L,136L,148L,156L,162L,166L,172L,178L,190L,196L,210L,222L,226L,232L,238L,250L,256L,262L,268L,276L,280L,292L,306L,310L,316L,330L,336L,346L,352L,358L,366L,372L,378L,382L,388L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136799Inst : IEnumerable<long>
{
public static readonly long[] Value=A136799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136799.Bytes);
public long this[int i]=>Value[i];

public static A136799Inst Instance=new A136799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136798
{
public static readonly long[] Value={ 8L,14L,20L,24L,32L,38L,44L,48L,54L,62L,68L,74L,80L,84L,90L,98L,104L,110L,114L,128L,132L,140L,152L,158L,164L,168L,174L,182L,194L,200L,212L,224L,230L,234L,242L,252L,258L,264L,272L,278L,284L,294L,308L,314L,318L,332L,338L,350L,354L,360L,368L,374L,380L,384L,390L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136798Inst : IEnumerable<long>
{
public static readonly long[] Value=A136798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136798.Bytes);
public long this[int i]=>Value[i];

public static A136798Inst Instance=new A136798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136797
{
public static readonly BigInteger[] Value={ 2L,8L,96L,2048L,64000L,2654208L,137682944L,8589934592L,626913312768L,52428800000000L,4944974716076032L,519400496868360192L,BigInteger.Parse("60134924074807721984"),BigInteger.Parse("7609328110443312447488") };
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
public class A136797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136797Inst Instance=new A136797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136796
{
public static readonly BigInteger[] Value={ 2L,16L,288L,8192L,320000L,15925248L,963780608L,68719476736L,5642219814912L,524288000000000L,54394721876836352L,6232805962420322304L,BigInteger.Parse("781754012972500385792"),BigInteger.Parse("106530593546206374264832"),BigInteger.Parse("15672832819200000000000000"),BigInteger.Parse("2475880078570760549798248448") };
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
public class A136796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136796Inst Instance=new A136796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136795
{
public static readonly long[] Value={ 2L,6L,20L,112L,662L,4596L,34032L,268280L,2201634L,18679362L,162611904L,1446148032L,13090979394L,120303384120L,1119971272340L,10544483234056L,100261309326082L,961692928106614L,9296529143261548L,90497666895840376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136795Inst : IEnumerable<long>
{
public static readonly long[] Value=A136795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136795.Bytes);
public long this[int i]=>Value[i];

public static A136795Inst Instance=new A136795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136794
{
public static readonly long[] Value={ 2L,8L,52L,376L,2998L,25256L,222128L,2013680L,18691522L,176743160L,1696546848L,16488151400L,161919802562L,1604274741608L,16016845623764L,160977882238968L,1627406260427490L,16537733701226936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136794Inst : IEnumerable<long>
{
public static readonly long[] Value=A136794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136794.Bytes);
public long this[int i]=>Value[i];

public static A136794Inst Instance=new A136794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136793
{
public static readonly BigInteger[] Value={ 4L,16L,104L,752L,5996L,50512L,444256L,4027360L,37383044L,353486320L,3393093696L,32976302800L,323839605124L,3208549483216L,32033691247528L,321955764477936L,3254812520854980L,33075467402453872L,337670437247448728L,3461635652745799136L,BigInteger.Parse("35620112071990294784") };
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
public class A136793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136793Inst Instance=new A136793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136792
{
public static readonly long[] Value={ 1L,4L,17L,70L,297L,1342L,6519L,34006L,189647L,1125100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136792Inst : IEnumerable<long>
{
public static readonly long[] Value=A136792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136792.Bytes);
public long this[int i]=>Value[i];

public static A136792Inst Instance=new A136792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136743
{
public static readonly long[] Value={ 2L,4L,3L,5L,1L,1L,5L,2L,5L,6L,5L,5L,3L,2L,1L,2L,5L,3L,6L,6L,3L,6L,3L,6L,1L,2L,6L,1L,5L,6L,6L,6L,4L,4L,1L,6L,4L,5L,6L,4L,1L,1L,5L,5L,2L,1L,6L,3L,4L,5L,6L,7L,4L,6L,1L,1L,6L,4L,7L,6L,6L,6L,3L,7L,1L,2L,6L,1L,5L,2L,1L,7L,6L,3L,7L,1L,1L,5L,3L,5L,8L,5L,1L,2L,4L,6L,2L,1L,6L,3L,6L,7L,4L,7L,4L,1L,2L,2L,6L,1L,6L,6L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136743Inst : IEnumerable<long>
{
public static readonly long[] Value=A136743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136743.Bytes);
public long this[int i]=>Value[i];

public static A136743Inst Instance=new A136743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136742
{
public static readonly long[] Value={ 6L,210L,110L,2730L,17L,19L,10626L,26L,26970L,39270L,54834L,74046L,2162L,51L,53L,55L,195054L,3782L,287430L,342930L,5402L,474474L,6806L,635970L,89L,91L,830490L,97L,1061106L,1190910L,1330890L,1481430L,14042L,15006L,127L,2196870L,17822L,2627934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136742Inst : IEnumerable<long>
{
public static readonly long[] Value=A136742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136742.Bytes);
public long this[int i]=>Value[i];

public static A136742Inst Instance=new A136742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136741
{
public static readonly BigInteger[] Value={ 1L,3L,22L,250L,3810L,72492L,1649634L,43626510L,1313526375L,44332221175L,1657043432088L,67929461003560L,3029864359322346L,146058681728370600L,7566706624571096610L,BigInteger.Parse("419220650458638848514"),BigInteger.Parse("24733868801871384287055") };
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
public class A136741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136741Inst Instance=new A136741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136740
{
public static readonly long[] Value={ 2L,3L,5L,7L,34522712143931L,17L,437L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136740Inst : IEnumerable<long>
{
public static readonly long[] Value=A136740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136740.Bytes);
public long this[int i]=>Value[i];

public static A136740Inst Instance=new A136740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136739
{
public static readonly long[] Value={ 0L,12L,25L,35L,12L,65L,32L,20L,30L,85L,42L,16L,91L,115L,21L,32L,12L,217L,108L,16L,209L,45L,10L,777L,45L,138L,20L,172L,55L,125L,282L,27L,14L,57L,132L,12L,65L,30L,589L,236L,198L,68L,18L,108L,28L,268L,442L,24L,355L,225L,80L,20L,52L,55L,1053L,32L,172L,332L,36L,765L,93L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136739Inst : IEnumerable<long>
{
public static readonly long[] Value=A136739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136739.Bytes);
public long this[int i]=>Value[i];

public static A136739Inst Instance=new A136739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136738
{
public static readonly long[] Value={ 2L,8L,13L,17L,8L,57L,19L,17L,14L,37L,40L,13L,25L,49L,17L,29L,8L,205L,46L,13L,39L,37L,8L,93L,41L,56L,13L,88L,35L,33L,98L,23L,12L,53L,79L,9L,57L,24L,67L,120L,76L,65L,16L,43L,17L,136L,74L,17L,145L,79L,77L,12L,45L,25L,1029L,23L,49L,168L,26L,77L,89L,122L,8L,48L,27L,95L,254L,13L,201L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136738Inst : IEnumerable<long>
{
public static readonly long[] Value=A136738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136738.Bytes);
public long this[int i]=>Value[i];

public static A136738Inst Instance=new A136738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136737
{
public static readonly long[] Value={ 1L,1L,1L,4L,2L,1L,30L,9L,3L,1L,335L,69L,15L,4L,1L,4984L,769L,118L,22L,5L,1L,92652L,11346L,1317L,178L,30L,6L,1L,2065146L,208914L,19311L,1995L,250L,39L,7L,1L,53636520L,4613976L,352636L,29126L,2820L,335L,49L,8L,1L,1589752230L,118840164L,7722840L,528097L,41061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136737Inst : IEnumerable<long>
{
public static readonly long[] Value=A136737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136737.Bytes);
public long this[int i]=>Value[i];

public static A136737Inst Instance=new A136737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136736
{
public static readonly BigInteger[] Value={ 1L,25L,343L,729L,25L,256L,1220703125L,729L,2401L,6859L,441L,343L,31381059609L,15625L,64L,3375L,25L,1296L,BigInteger.Parse("9903520314283042199192993792"),343L,8650415919381337933L,144L,25L,BigInteger.Parse("1699133621328831977374894383159"),256L };
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
public class A136736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136736Inst Instance=new A136736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136735
{
public static readonly long[] Value={ 2L,10L,21L,27L,10L,32L,65L,27L,28L,57L,42L,21L,99L,75L,16L,45L,10L,72L,248L,21L,221L,24L,10L,741L,32L,328L,35L,90L,28L,161L,196L,20L,14L,40L,795L,15L,32L,30L,609L,122L,488L,99L,18L,143L,55L,138L,460L,49L,219L,365L,117L,14L,147L,39L,184L,27L,246L,170L,50L,817L,64L,1246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136735Inst : IEnumerable<long>
{
public static readonly long[] Value=A136735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136735.Bytes);
public long this[int i]=>Value[i];

public static A136735Inst Instance=new A136735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136734
{
public static readonly long[] Value={ 2L,7L,11L,13L,7L,27L,41L,23L,13L,23L,40L,17L,29L,29L,13L,41L,7L,65L,158L,17L,45L,19L,8L,75L,29L,208L,23L,47L,17L,51L,55L,17L,12L,37L,691L,11L,27L,24L,77L,63L,308L,95L,16L,71L,35L,71L,86L,37L,77L,149L,113L,9L,135L,17L,171L,19L,86L,87L,38L,103L,61L,982L,8L,96L,48L,65L,142L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136734Inst : IEnumerable<long>
{
public static readonly long[] Value=A136734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136734.Bytes);
public long this[int i]=>Value[i];

public static A136734Inst Instance=new A136734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136733
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,18L,7L,3L,1L,170L,43L,12L,4L,1L,2220L,403L,76L,18L,5L,1L,37149L,5188L,711L,118L,25L,6L,1L,758814L,85569L,9054L,1107L,170L,33L,7L,1L,18301950L,1725291L,147471L,13986L,1605L,233L,42L,8L,1L,508907970L,41145705L,2938176L,225363L,20171L,2220L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136733Inst : IEnumerable<long>
{
public static readonly long[] Value=A136733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136733.Bytes);
public long this[int i]=>Value[i];

public static A136733Inst Instance=new A136733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136732
{
public static readonly BigInteger[] Value={ 1L,3L,9L,43L,324L,3510L,50528L,913377L,19918602L,509040779L,14918466255L,493115508126L,18143982947900L,735340631600946L,32542320101428755L,1561227609244084205L,BigInteger.Parse("80700623119099359600"),BigInteger.Parse("4470904603875492038790") };
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
public class A136732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136732Inst Instance=new A136732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136731
{
public static readonly BigInteger[] Value={ 1L,2L,5L,23L,175L,1935L,28432L,523290L,11587072L,299942890L,8886126540L,296438370794L,10993731095695L,448604373236731L,19971257117211555L,963142501803505255L,BigInteger.Parse("50015707804752012825"),BigInteger.Parse("2782336529985704607295") };
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
public class A136731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136731Inst Instance=new A136731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136730
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,9L,5L,3L,1L,70L,23L,9L,4L,1L,795L,175L,43L,14L,5L,1L,11961L,1935L,324L,70L,20L,6L,1L,224504L,28432L,3510L,527L,105L,27L,7L,1L,5051866L,523290L,50528L,5624L,795L,149L,35L,8L,1L,132523155L,11587072L,913377L,79553L,8396L,1140L,203L,44L,9L,1L,3969912160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136730Inst : IEnumerable<long>
{
public static readonly long[] Value=A136730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136730.Bytes);
public long this[int i]=>Value[i];

public static A136730Inst Instance=new A136730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136729
{
public static readonly BigInteger[] Value={ 1L,1L,5L,49L,701L,13177L,306821L,8520289L,274808525L,10095533833L,416131518293L,19017974164465L,954399901374749L,52173428322993433L,3085965087129209381L,BigInteger.Parse("196360349627069553793"),BigInteger.Parse("13374490368820471936109"),BigInteger.Parse("970904530181260115741737") };
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
public class A136729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136729.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136729Inst Instance=new A136729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136728
{
public static readonly BigInteger[] Value={ 1L,1L,4L,31L,349L,5146L,93799L,2036161L,51283894L,1470035101L,47250248569L,1683031711516L,65800765032589L,2801364476781781L,129003301751229364L,6389120632590635971L,BigInteger.Parse("338644807090096148809"),BigInteger.Parse("19126604338708282552186") };
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
public class A136728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136728Inst Instance=new A136728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136679
{
public static readonly long[] Value={ 0L,0L,0L,9L,0L,16L,24L,45L,56L,48L,80L,137L,96L,144L,128L,315L,192L,302L,288L,425L,312L,400L,440L,621L,544L,528L,728L,969L,672L,704L,840L,1451L,880L,960L,984L,2021L,1152L,1296L,1248L,1901L,1440L,1504L,1680L,2569L,2024L,1936L,2024L,3387L,2400L,2524L,2240L,3561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136679Inst : IEnumerable<long>
{
public static readonly long[] Value=A136679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136679.Bytes);
public long this[int i]=>Value[i];

public static A136679Inst Instance=new A136679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136678
{
public static readonly long[] Value={ 1L,2L,-1L,2L,-4L,1L,2L,-9L,6L,-1L,1L,-16L,20L,-8L,1L,0L,-24L,50L,-35L,10L,-1L,-2L,-32L,104L,-112L,54L,-12L,1L,-4L,-38L,190L,-293L,210L,-77L,14L,-1L,-7L,-40L,314L,-664L,659L,-352L,104L,-16L,1L,-10L,-35L,478L,-1349L,1772L,-1286L,546L,-135L,18L,-1L,-14L,-20L,677L,-2512L,4234L,-3992L,2274L,-800L,170L,-20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136678Inst : IEnumerable<long>
{
public static readonly long[] Value=A136678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136678.Bytes);
public long this[int i]=>Value[i];

public static A136678Inst Instance=new A136678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136677
{
public static readonly BigInteger[] Value={ 1L,63L,45991L,2942695L,45982595359L,5109066151L,601081707598999L,38469080386820311L,BigInteger.Parse("252396118308232060471"),BigInteger.Parse("252395862211967012407"),BigInteger.Parse("447134922152359540530757327"),BigInteger.Parse("447134770212444455649757327") };
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
public class A136677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136677Inst Instance=new A136677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136676
{
public static readonly BigInteger[] Value={ 1L,31L,7565L,241837L,755989457L,755889457L,12705011703799L,406547611705943L,98792790681344149L,98791774426324117L,BigInteger.Parse("15910615688635928566967"),BigInteger.Parse("15910549913780913466967"),BigInteger.Parse("5907492176026179821253778331") };
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
public class A136676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136676Inst Instance=new A136676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136675
{
public static readonly BigInteger[] Value={ 1L,7L,197L,1549L,195353L,194353L,66879079L,533875007L,14436577189L,14420574181L,19209787242911L,19197460851911L,42198121495296467L,6025866788581781L,6027847576222613L,48209723660000029L,BigInteger.Parse("236907853607882606477") };
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
public class A136675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136675Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136675.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136675Inst Instance=new A136675Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136674
{
public static readonly long[] Value={ 1L,2L,-1L,1L,-4L,1L,0L,-8L,6L,-1L,-1L,-12L,19L,-8L,1L,-2L,-15L,44L,-34L,10L,-1L,-3L,-16L,84L,-104L,53L,-12L,1L,-4L,-14L,140L,-258L,200L,-76L,14L,-1L,-5L,-8L,210L,-552L,605L,-340L,103L,-16L,1L,-6L,3L,288L,-1056L,1562L,-1209L,532L,-134L,18L,-1L,-7L,20L,363L,-1848L,3575L,-3640L,2170L,-784L,169L,-20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136674Inst : IEnumerable<long>
{
public static readonly long[] Value=A136674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136674.Bytes);
public long this[int i]=>Value[i];

public static A136674Inst Instance=new A136674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136673
{
public static readonly long[] Value={ 2L,1L,1L,2L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136673Inst : IEnumerable<long>
{
public static readonly long[] Value=A136673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136673.Bytes);
public long this[int i]=>Value[i];

public static A136673Inst Instance=new A136673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136672
{
public static readonly long[] Value={ 1L,2L,-1L,4L,-4L,1L,6L,-11L,6L,-1L,8L,-24L,22L,-8L,1L,10L,-45L,62L,-37L,10L,-1L,12L,-76L,147L,-128L,56L,-12L,1L,14L,-119L,308L,-366L,230L,-79L,14L,-1L,16L,-176L,588L,-912L,770L,-376L,106L,-16L,1L,18L,-249L,1044L,-2046L,2222L,-1443L,574L,-137L,18L,-1L,20L,-340L,1749L,-4224L,5720L,-4732L,2485L,-832L,172L,-20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136672Inst : IEnumerable<long>
{
public static readonly long[] Value=A136672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136672.Bytes);
public long this[int i]=>Value[i];

public static A136672Inst Instance=new A136672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136671
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,17L,37L,81L,177L,388L,850L,1864L,4088L,8966L,19664L,43128L,94591L,207464L,455026L,997999L,2188891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136671Inst : IEnumerable<long>
{
public static readonly long[] Value=A136671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136671.Bytes);
public long this[int i]=>Value[i];

public static A136671Inst Instance=new A136671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136670
{
public static readonly BigInteger[] Value={ 0L,1L,23L,532L,12310L,284861L,6591880L,152540668L,3529896712L,81684254837L,1890230234120L,43741236852957L,1012202517391875L,23423067337090791L,542026001764509598L,12542857105806790317UL,BigInteger.Parse("290250401022346296890") };
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
public class A136670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136670Inst Instance=new A136670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136669
{
public static readonly BigInteger[] Value={ 5L,11L,59L,359L,5039L,55439L,1441439L,BigInteger.Parse("135483209545341953934626770390607999"),BigInteger.Parse("21406347108164028721671029721716063999"),BigInteger.Parse("6223083124956116561507895939157782409673929631999"),BigInteger.Parse("78232234099885463677928129398618807521962436643076243437332696602750813193299417065162966120702842438719999") };
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
public class A136669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136669Inst Instance=new A136669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136668
{
public static readonly long[] Value={ 1L,0L,1L,-2L,0L,2L,0L,-11L,0L,8L,8L,0L,-74L,0L,48L,0L,119L,0L,-632L,0L,384L,-48L,0L,1634L,0L,-6608L,0L,3840L,0L,-1409L,0L,24032L,0L,-81984L,0L,46080L,384L,0L,-32798L,0L,389312L,0L,-1178496L,0L,645120L,0L,18825L,0L,-741056L,0L,6966848L,0L,-19270656L,0L,10321920L,-3840L,0L,666830L,0L,-17232128L,0L,137188224L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136668Inst : IEnumerable<long>
{
public static readonly long[] Value=A136668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136668.Bytes);
public long this[int i]=>Value[i];

public static A136668Inst Instance=new A136668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136667
{
public static readonly long[] Value={ 0L,1L,0L,-1L,-3L,0L,4L,0L,-1L,1L,0L,-25L,0L,10L,0L,-1L,-63L,0L,144L,0L,-97L,0L,18L,0L,-1L,1L,0L,-1089L,0L,924L,0L,-262L,0L,28L,0L,-1L,-2303L,0L,8352L,0L,-9489L,0L,3576L,0L,-574L,0L,40L,0L,-1L,1L,0L,-77841L,0L,103230L,0L,-49291L,0L,10548L,0L,-1099L,0L,54L,0L,-1L,-147455L,0L,748800L,0L,-1215585L,0L,699630L,0L,-188043L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136667Inst : IEnumerable<long>
{
public static readonly long[] Value=A136667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136667.Bytes);
public long this[int i]=>Value[i];

public static A136667Inst Instance=new A136667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136666
{
public static readonly long[] Value={ 0L,0L,2L,16L,0L,8L,0L,56L,0L,24L,512L,0L,176L,0L,64L,0L,1632L,0L,512L,0L,160L,18432L,0L,4992L,0L,1408L,0L,384L,0L,57984L,0L,14656L,0L,3712L,0L,896L,786432L,0L,177792L,0L,41472L,0L,9472L,0L,2048L,0L,2480640L,0L,529920L,0L,113664L,0L,23552L,0L,4608L,39321600L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136666Inst : IEnumerable<long>
{
public static readonly long[] Value=A136666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136666.Bytes);
public long this[int i]=>Value[i];

public static A136666Inst Instance=new A136666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136665
{
public static readonly long[] Value={ 1L,0L,1L,-2L,0L,2L,0L,-7L,0L,4L,8L,0L,-22L,0L,8L,0L,51L,0L,-64L,0L,16L,-48L,0L,234L,0L,-176L,0L,32L,0L,-453L,0L,916L,0L,-464L,0L,64L,384L,0L,-2778L,0L,3240L,0L,-1184L,0L,128L,0L,4845L,0L,-13800L,0L,10656L,0L,-2944L,0L,256L,-3840L,0L,37470L,0L,-60000L,0L,33152L,0L,-7168L,0L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136665Inst : IEnumerable<long>
{
public static readonly long[] Value=A136665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136665.Bytes);
public long this[int i]=>Value[i];

public static A136665Inst Instance=new A136665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136664
{
public static readonly long[] Value={ 1L,0L,2L,8L,0L,4L,0L,20L,0L,8L,128L,0L,48L,0L,16L,0L,352L,0L,112L,0L,32L,3072L,0L,928L,0L,256L,0L,64L,0L,8928L,0L,2368L,0L,576L,0L,128L,98304L,0L,24960L,0L,5888L,0L,1280L,0L,256L,0L,296448L,0L,67584L,0L,14336L,0L,2816L,0L,512L,3932160L,0L,863232L,0L,178176L,0L,34304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136664Inst : IEnumerable<long>
{
public static readonly long[] Value=A136664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136664.Bytes);
public long this[int i]=>Value[i];

public static A136664Inst Instance=new A136664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136599
{
public static readonly long[] Value={ 1L,-3L,0L,5L,0L,0L,-7L,0L,0L,0L,9L,0L,0L,0L,0L,-14L,9L,0L,-15L,0L,0L,34L,0L,0L,0L,-27L,0L,0L,-15L,0L,33L,0L,0L,0L,0L,0L,-22L,0L,0L,0L,0L,0L,0L,45L,0L,-14L,-15L,0L,25L,0L,0L,-86L,0L,0L,0L,66L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,42L,0L,0L,0L,-63L,0L,0L,-75L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136599Inst : IEnumerable<long>
{
public static readonly long[] Value=A136599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136599.Bytes);
public long this[int i]=>Value[i];

public static A136599Inst Instance=new A136599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136598
{
public static readonly long[] Value={ 5L,0L,0L,-3L,0L,5L,3L,0L,-8L,-3L,5L,11L,3L,-13L,-14L,2L,24L,17L,-15L,-38L,-15L,39L,55L,0L,-77L,-70L,39L,132L,70L,-116L,-202L,-31L,248L,272L,-85L,-450L,-303L,333L,722L,218L,-783L,-1025L,115L,1505L,1243L,-898L,-2530L,-1128L,2403L,3773L,230L,-4933L,-4901L,2173L,8706L,5131L,-7106L,-13607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136598Inst : IEnumerable<long>
{
public static readonly long[] Value=A136598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136598.Bytes);
public long this[int i]=>Value[i];

public static A136598Inst Instance=new A136598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136597
{
public static readonly BigInteger[] Value={ 1L,-6L,85L,-1350L,26341L,-603246L,15887845L,-473148150L,15723174181L,-576826897086L,23157022930405L,-1009818279438150L,47533643556874021L,-2402218856253008526L,BigInteger.Parse("129730266330534913765"),BigInteger.Parse("-7455932648513351731350"),BigInteger.Parse("454377365410347843373861") };
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
public class A136597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136597.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136597Inst Instance=new A136597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136596
{
public static readonly BigInteger[] Value={ 1L,-3L,31L,-375L,5911L,-113463L,2571031L,-67170855L,1987919671L,-65731585623L,2401646633431L,-96089053104135L,4178215255335031L,-196193483904124983L,9894077286353278231UL,BigInteger.Parse("-533334378459657706215"),BigInteger.Parse("30602112192036616407991") };
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
public class A136596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136596Inst Instance=new A136596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136595
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,7L,-3L,1L,0L,-61L,31L,-6L,1L,0L,751L,-375L,85L,-10L,1L,0L,-11821L,5911L,-1350L,185L,-15L,1L,0L,226927L,-113463L,26341L,-3710L,350L,-21L,1L,0L,-5142061L,2571031L,-603246L,87381L,-8610L,602L,-28L,1L,0L,134341711L,-67170855L,15887845L,-2346330L,240051L,-17766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136595Inst : IEnumerable<long>
{
public static readonly long[] Value=A136595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136595.Bytes);
public long this[int i]=>Value[i];

public static A136595Inst Instance=new A136595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136594
{
public static readonly long[] Value={ 1L,1L,2L,8L,26L,70L,820L,5152L,20316L,388712L,3666188L,17298908L,501805832L,6256792412L,33844737292L,1353617016078L,20960708128068L,137741948419428L,6588092586831028L,121860622573650906L,924837580461274556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136594Inst : IEnumerable<long>
{
public static readonly long[] Value=A136594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136594.Bytes);
public long this[int i]=>Value[i];

public static A136594Inst Instance=new A136594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136593
{
public static readonly BigInteger[] Value={ 1L,6L,-25L,-135L,1834L,-3668L,-110692L,1339020L,-1181664L,-164709864L,2206092096L,395662176L,-463716547776L,7029335571840L,8900411569920L,-2265668505227520L,38689597829053440L,92447263589921280L,BigInteger.Parse("-17785648201625856000"),BigInteger.Parse("338957966532455424000") };
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
public class A136593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136593Inst Instance=new A136593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136592
{
public static readonly BigInteger[] Value={ 1L,3L,-13L,-10L,394L,-2016L,-5076L,170064L,-1155024L,-5005440L,193724640L,-1656720000L,-10280355840L,465087087360L,-4804977542400L,-39012996556800L,2035558551398400L,-24660231399014400L,-248246498826547200L,14713557956794368000UL };
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
public class A136592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136592Inst Instance=new A136592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136591
{
public static readonly BigInteger[] Value={ 1L,1L,-4L,6L,24L,-240L,720L,5040L,-80640L,362880L,3628800L,-79833600L,479001600L,6227020800L,-174356582400L,1307674368000L,20922789888000L,-711374856192000L,6402373705728000L,121645100408832000L,-4865804016353280000L,BigInteger.Parse("51090942171709440000") };
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
public class A136591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136591Inst Instance=new A136591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136590
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,-4L,3L,1L,0L,6L,-13L,6L,1L,0L,24L,-10L,-25L,10L,1L,0L,-240L,394L,-135L,-35L,15L,1L,0L,720L,-2016L,1834L,-525L,-35L,21L,1L,0L,5040L,-5076L,-3668L,5089L,-1400L,-14L,28L,1L,0L,-80640L,170064L,-110692L,14364L,9849L,-3024L,42L,36L,1L,0L,362880L,-1155024L,1339020L,-672400L,118125L,12873L,-5670L,150L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136590Inst : IEnumerable<long>
{
public static readonly long[] Value=A136590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136590.Bytes);
public long this[int i]=>Value[i];

public static A136590Inst Instance=new A136590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136589
{
public static readonly BigInteger[] Value={ 1L,2L,6L,44L,345L,4182L,53571L,905144L,16154550L,349976610L,8015743483L,211987872516L,5925745900685L,185188128471374L,6108604964499810L,220403394009702384L,8375181440031684305L,BigInteger.Parse("342816825221831030490") };
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
public class A136589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136589.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136589Inst Instance=new A136589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136588
{
public static readonly BigInteger[] Value={ 1L,1L,2L,21L,124L,1880L,20046L,391419L,6195288L,147481299L,3121373690L,87790122816L,2329580861268L,75790954533385L,2415630777959686L,89478235732836705L,3323789119614522416L,BigInteger.Parse("138402773923330655700") };
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
public class A136588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136588.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136588Inst Instance=new A136588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136587
{
public static readonly long[] Value={ 2L,-2L,1L,1L,6L,0L,-8L,0L,1L,-48L,-5L,87L,1L,-20L,0L,1L,392L,0L,-984L,0L,346L,0L,-35L,0L,1L,-3840L,33L,12645L,-14L,-6090L,1L,938L,0L,-54L,0L,1L,46032L,0L,-187338L,0L,114745L,0L,-23813L,0L,2070L,0L,-77L,0L,1L,-645120L,-279L,3133935L,185L,-2336040L,-27L,611415L,1L,-71280L,0L,3993L,0L,-104L,0L,1L,10322304L,0L,-58438830L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136587Inst : IEnumerable<long>
{
public static readonly long[] Value=A136587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136587.Bytes);
public long this[int i]=>Value[i];

public static A136587Inst Instance=new A136587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136586
{
public static readonly long[] Value={ 0L,0L,1L,-1L,0L,1L,0L,-4L,0L,1L,6L,0L,-8L,0L,1L,0L,28L,0L,-13L,0L,1L,-40L,0L,78L,0L,-19L,0L,1L,0L,-246L,0L,171L,0L,-26L,0L,1L,336L,0L,-888L,0L,325L,0L,-34L,0L,1L,0L,2616L,0L,-2455L,0L,561L,0L,-43L,0L,1L,-3456L,0L,11670L,0L,-5745L,0L,903L,0L,-53L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136586Inst : IEnumerable<long>
{
public static readonly long[] Value=A136586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136586.Bytes);
public long this[int i]=>Value[i];

public static A136586Inst Instance=new A136586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136585
{
public static readonly long[] Value={ 2L,4L,5L,6L,9L,20L,33L,35L,42L,44L,57L,68L,104L,114L,117L,119L,145L,174L,279L,301L,310L,322L,345L,376L,410L,430L,517L,533L,590L,649L,740L,777L,976L,1159L,1537L,1590L,2345L,2412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136585Inst : IEnumerable<long>
{
public static readonly long[] Value=A136585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136585.Bytes);
public long this[int i]=>Value[i];

public static A136585Inst Instance=new A136585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136584
{
public static readonly BigInteger[] Value={ 1L,1L,3L,31L,1327L,170211L,68333813L,89675072255L,397525147082217L,6103188627225900995L,BigInteger.Parse("331088233835064606501621"),BigInteger.Parse("64490029272314754165301653295"),BigInteger.Parse("45679131008965219349145151231118965") };
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
public class A136584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136584Inst Instance=new A136584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136503
{
public static readonly BigInteger[] Value={ 1L,-4L,26L,-308L,6959L,-306888L,26732904L,-4628215312L,1597488685120L,-1101039613155676L,1516536435306750724L,BigInteger.Parse("-4175994577753360618608"),BigInteger.Parse("22993788379965461938093352"),BigInteger.Parse("-253190775338116964702467771168") };
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
public class A136503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136503Inst Instance=new A136503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136502
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-2L,1L,-7L,7L,-4L,1L,44L,-44L,26L,-8L,1L,-516L,516L,-308L,100L,-16L,1L,11622L,-11622L,6959L,-2296L,392L,-32L,1L,-512022L,512022L,-306888L,101754L,-17712L,1552L,-64L,1L,44588536L,-44588536L,26732904L,-8877272L,1554404L,-139104L,6176L,-128L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136502Inst : IEnumerable<long>
{
public static readonly long[] Value=A136502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136502.Bytes);
public long this[int i]=>Value[i];

public static A136502Inst Instance=new A136502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136501
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,0L,1L,4L,1L,0L,0L,6L,8L,1L,0L,0L,4L,28L,16L,1L,0L,0L,1L,56L,120L,32L,1L,0L,0L,0L,70L,560L,496L,64L,1L,0L,0L,0L,56L,1820L,4960L,2016L,128L,1L,0L,0L,0L,28L,4368L,35960L,41664L,8128L,256L,1L,0L,0L,0L,8L,8008L,201376L,635376L,341376L,32640L,512L,1L,0L,0L,0L,1L,11440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136501Inst : IEnumerable<long>
{
public static readonly long[] Value=A136501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136501.Bytes);
public long this[int i]=>Value[i];

public static A136501Inst Instance=new A136501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136500
{
public static readonly long[] Value={ 3L,5L,11L,15L,17L,19L,22L,24L,29L,32L,35L,40L,45L,49L,52L,57L,62L,64L,66L,68L,73L,75L,80L,82L,87L,89L,92L,94L,98L,101L,103L,105L,110L,113L,116L,121L,123L,128L,131L,133L,135L,140L,143L,145L,147L,152L,157L,163L,167L,170L,172L,175L,181L,185L,187L,190L,192L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136500Inst : IEnumerable<long>
{
public static readonly long[] Value=A136500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136500.Bytes);
public long this[int i]=>Value[i];

public static A136500Inst Instance=new A136500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136499
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,9L,10L,12L,13L,14L,16L,18L,20L,21L,23L,25L,26L,27L,28L,30L,31L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,50L,51L,53L,54L,55L,56L,58L,59L,60L,61L,63L,65L,67L,69L,70L,71L,72L,74L,76L,77L,78L,79L,81L,83L,84L,85L,86L,88L,90L,91L,93L,95L,96L,97L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136499Inst : IEnumerable<long>
{
public static readonly long[] Value=A136499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136499.Bytes);
public long this[int i]=>Value[i];

public static A136499Inst Instance=new A136499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136498
{
public static readonly long[] Value={ 2L,7L,9L,11L,14L,20L,25L,29L,31L,36L,38L,40L,42L,45L,49L,52L,55L,57L,61L,64L,67L,73L,78L,80L,82L,85L,90L,95L,100L,105L,107L,112L,115L,117L,121L,123L,128L,130L,135L,141L,143L,146L,150L,152L,157L,159L,164L,166L,168L,170L,173L,177L,179L,182L,185L,189L,194L,199L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136498Inst : IEnumerable<long>
{
public static readonly long[] Value=A136498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136498.Bytes);
public long this[int i]=>Value[i];

public static A136498Inst Instance=new A136498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136497
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,8L,10L,12L,13L,15L,16L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,30L,32L,33L,34L,35L,37L,39L,41L,43L,44L,46L,47L,48L,50L,51L,53L,54L,56L,58L,59L,60L,62L,63L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L,79L,81L,83L,84L,86L,87L,88L,89L,91L,92L,93L,94L,96L,97L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136497Inst : IEnumerable<long>
{
public static readonly long[] Value=A136497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136497.Bytes);
public long this[int i]=>Value[i];

public static A136497Inst Instance=new A136497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136496
{
public static readonly long[] Value={ 2L,6L,8L,11L,15L,19L,21L,25L,27L,30L,34L,36L,39L,43L,47L,49L,52L,56L,60L,62L,66L,68L,71L,75L,79L,81L,85L,87L,90L,94L,96L,99L,103L,107L,109L,113L,115L,118L,122L,124L,127L,131L,135L,137L,140L,144L,148L,150L,154L,156L,159L,163L,165L,168L,172L,176L,178L,181L,185L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136496Inst : IEnumerable<long>
{
public static readonly long[] Value=A136496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136496.Bytes);
public long this[int i]=>Value[i];

public static A136496Inst Instance=new A136496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136495
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,10L,12L,13L,14L,16L,17L,18L,20L,22L,23L,24L,26L,28L,29L,31L,32L,33L,35L,37L,38L,40L,41L,42L,44L,45L,46L,48L,50L,51L,53L,54L,55L,57L,58L,59L,61L,63L,64L,65L,67L,69L,70L,72L,73L,74L,76L,77L,78L,80L,82L,83L,84L,86L,88L,89L,91L,92L,93L,95L,97L,98L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136495Inst : IEnumerable<long>
{
public static readonly long[] Value=A136495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136495.Bytes);
public long this[int i]=>Value[i];

public static A136495Inst Instance=new A136495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136494
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,6L,6L,4L,4L,6L,4L,6L,6L,24L,24L,12L,12L,12L,12L,12L,12L,24L,12L,12L,12L,24L,12L,24L,24L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136494Inst : IEnumerable<long>
{
public static readonly long[] Value=A136494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136494.Bytes);
public long this[int i]=>Value[i];

public static A136494Inst Instance=new A136494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136493
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,0L,-1L,3L,0L,0L,1L,-4L,1L,2L,0L,-1L,5L,-3L,-5L,1L,1L,1L,-6L,6L,8L,-5L,-2L,1L,-1L,7L,-10L,-10L,14L,4L,-4L,0L,1L,-8L,15L,10L,-29L,-4L,12L,0L,0L,-1L,9L,-21L,-7L,50L,-4L,-30L,4L,4L,0L,1L,-10L,28L,0L,-76L,28L,61L,-20L,-15L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136493Inst : IEnumerable<long>
{
public static readonly long[] Value=A136493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136493.Bytes);
public long this[int i]=>Value[i];

public static A136493Inst Instance=new A136493Inst();

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