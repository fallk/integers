using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A157505
{
public static readonly long[] Value={ 1476L,2934L,4392L,5850L,7308L,8766L,10224L,11682L,13140L,14598L,16056L,17514L,18972L,20430L,21888L,23346L,24804L,26262L,27720L,29178L,30636L,32094L,33552L,35010L,36468L,37926L,39384L,40842L,42300L,43758L,45216L,46674L,48132L,49590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157505Inst : IEnumerable<long>
{
public static readonly long[] Value=A157505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157505.Bytes);
public long this[int i]=>Value[i];

public static A157505Inst Instance=new A157505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157506
{
public static readonly long[] Value={ 13447L,53137L,119071L,211249L,329671L,474337L,645247L,842401L,1065799L,1315441L,1591327L,1893457L,2221831L,2576449L,2957311L,3364417L,3797767L,4257361L,4743199L,5255281L,5793607L,6358177L,6948991L,7566049L,8209351L,8878897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157506Inst : IEnumerable<long>
{
public static readonly long[] Value=A157506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157506.Bytes);
public long this[int i]=>Value[i];

public static A157506Inst Instance=new A157506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157507
{
public static readonly long[] Value={ 79L,320L,723L,1288L,2015L,2904L,3955L,5168L,6543L,8080L,9779L,11640L,13663L,15848L,18195L,20704L,23375L,26208L,29203L,32360L,35679L,39160L,42803L,46608L,50575L,54704L,58995L,63448L,68063L,72840L,77779L,82880L,88143L,93568L,99155L,104904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157507Inst : IEnumerable<long>
{
public static readonly long[] Value=A157507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157507.Bytes);
public long this[int i]=>Value[i];

public static A157507Inst Instance=new A157507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157508
{
public static readonly long[] Value={ 1440L,2898L,4356L,5814L,7272L,8730L,10188L,11646L,13104L,14562L,16020L,17478L,18936L,20394L,21852L,23310L,24768L,26226L,27684L,29142L,30600L,32058L,33516L,34974L,36432L,37890L,39348L,40806L,42264L,43722L,45180L,46638L,48096L,49554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157508Inst : IEnumerable<long>
{
public static readonly long[] Value=A157508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157508.Bytes);
public long this[int i]=>Value[i];

public static A157508Inst Instance=new A157508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157509
{
public static readonly long[] Value={ 12799L,51841L,117127L,208657L,326431L,470449L,640711L,837217L,1059967L,1308961L,1584199L,1885681L,2213407L,2567377L,2947591L,3354049L,3786751L,4245697L,4730887L,5242321L,5779999L,6343921L,6934087L,7550497L,8193151L,8862049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157509Inst : IEnumerable<long>
{
public static readonly long[] Value=A157509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157509.Bytes);
public long this[int i]=>Value[i];

public static A157509Inst Instance=new A157509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157510
{
public static readonly long[] Value={ 1020L,2020L,3020L,4020L,5020L,6020L,7020L,8020L,9020L,10020L,11020L,12020L,13020L,14020L,15020L,16020L,17020L,18020L,19020L,20020L,21020L,22020L,23020L,24020L,25020L,26020L,27020L,28020L,29020L,30020L,31020L,32020L,33020L,34020L,35020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157510Inst : IEnumerable<long>
{
public static readonly long[] Value=A157510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157510.Bytes);
public long this[int i]=>Value[i];

public static A157510Inst Instance=new A157510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157511
{
public static readonly long[] Value={ 5201L,20401L,45601L,80801L,126001L,181201L,246401L,321601L,406801L,502001L,607201L,722401L,847601L,982801L,1128001L,1283201L,1448401L,1623601L,1808801L,2004001L,2209201L,2424401L,2649601L,2884801L,3130001L,3385201L,3650401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157511Inst : IEnumerable<long>
{
public static readonly long[] Value=A157511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157511.Bytes);
public long this[int i]=>Value[i];

public static A157511Inst Instance=new A157511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157512
{
public static readonly long[] Value={ 2L,8L,16L,26L,38L,52L,70L,90L,112L,136L,162L,190L,220L,252L,286L,324L,364L,406L,450L,496L,544L,594L,646L,700L,756L,814L,874L,936L,1002L,1070L,1140L,1212L,1286L,1362L,1440L,1520L,1602L,1686L,1772L,1860L,1950L,2042L,2136L,2232L,2330L,2432L,2536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157512Inst : IEnumerable<long>
{
public static readonly long[] Value=A157512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157512.Bytes);
public long this[int i]=>Value[i];

public static A157512Inst Instance=new A157512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157513
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,5L,37L,38L,5L,14L,177L,390L,187L,14L,42L,806L,3065L,3175L,874L,42L,132L,3566L,20742L,37260L,22254L,3958L,132L,429L,15485L,127575L,351821L,365433L,141442L,17548L,429L,1430L,66373L,734332L,2876886L,4597444L,3100670L,839068L,76627L,1430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157513Inst : IEnumerable<long>
{
public static readonly long[] Value=A157513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157513.Bytes);
public long this[int i]=>Value[i];

public static A157513Inst Instance=new A157513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157514
{
public static readonly long[] Value={ 24L,98L,222L,396L,620L,894L,1218L,1592L,2016L,2490L,3014L,3588L,4212L,4886L,5610L,6384L,7208L,8082L,9006L,9980L,11004L,12078L,13202L,14376L,15600L,16874L,18198L,19572L,20996L,22470L,23994L,25568L,27192L,28866L,30590L,32364L,34188L,36062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157514Inst : IEnumerable<long>
{
public static readonly long[] Value=A157514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157514.Bytes);
public long this[int i]=>Value[i];

public static A157514Inst Instance=new A157514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157515
{
public static readonly long[] Value={ 980L,1980L,2980L,3980L,4980L,5980L,6980L,7980L,8980L,9980L,10980L,11980L,12980L,13980L,14980L,15980L,16980L,17980L,18980L,19980L,20980L,21980L,22980L,23980L,24980L,25980L,26980L,27980L,28980L,29980L,30980L,31980L,32980L,33980L,34980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157515Inst : IEnumerable<long>
{
public static readonly long[] Value=A157515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157515.Bytes);
public long this[int i]=>Value[i];

public static A157515Inst Instance=new A157515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157516
{
public static readonly long[] Value={ 4801L,19601L,44401L,79201L,124001L,178801L,243601L,318401L,403201L,498001L,602801L,717601L,842401L,977201L,1122001L,1276801L,1441601L,1616401L,1801201L,1996001L,2200801L,2415601L,2640401L,2875201L,3120001L,3374801L,3639601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157516Inst : IEnumerable<long>
{
public static readonly long[] Value=A157516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157516.Bytes);
public long this[int i]=>Value[i];

public static A157516Inst Instance=new A157516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157517
{
public static readonly long[] Value={ 7L,13L,7L,-11L,-41L,-83L,-137L,-203L,-281L,-371L,-473L,-587L,-713L,-851L,-1001L,-1163L,-1337L,-1523L,-1721L,-1931L,-2153L,-2387L,-2633L,-2891L,-3161L,-3443L,-3737L,-4043L,-4361L,-4691L,-5033L,-5387L,-5753L,-6131L,-6521L,-6923L,-7337L,-7763L,-8201L,-8651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157517Inst : IEnumerable<long>
{
public static readonly long[] Value=A157517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157517.Bytes);
public long this[int i]=>Value[i];

public static A157517Inst Instance=new A157517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157518
{
public static readonly long[] Value={ 6L,104L,104L,908L,1818L,908L,5298L,16560L,16560L,5298L,23261L,105510L,158768L,105510L,23261L,82603L,522325L,1086904L,1086904L,522325L,82603L,249245L,2125965L,5916957L,7962500L,5916957L,2125965L,249245L,661751L,7394811L,26917679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157518Inst : IEnumerable<long>
{
public static readonly long[] Value=A157518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157518.Bytes);
public long this[int i]=>Value[i];

public static A157518Inst Instance=new A157518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157519
{
public static readonly long[] Value={ 1L,6L,30L,150L,726L,3510L,16734L,79518L,375246L,1766382L,8278638L,38721366L,180556206L,840524742L,3903866526L,18106798830L,83832778110L,387690560718L,1790330065854L,8259528315558L,38059497518214L,175228328442174L,805959153119262L,3704270575724550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157519Inst : IEnumerable<long>
{
public static readonly long[] Value=A157519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157519.Bytes);
public long this[int i]=>Value[i];

public static A157519Inst Instance=new A157519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157520
{
public static readonly long[] Value={ 3L,1L,2L,1L,3L,1L,1L,1L,5L,1L,2L,1L,8L,1L,4L,3L,3L,1L,9L,4L,9L,5L,9L,4L,5L,2L,6L,2L,12L,5L,1L,1L,13L,4L,9L,1L,12L,3L,31L,1L,3L,2L,6L,3L,63L,3L,27L,4L,13L,2L,44L,9L,41L,6L,78L,3L,25L,3L,35L,3L,47L,1L,37L,8L,24L,1L,40L,3L,20L,1L,73L,1L,107L,26L,39L,2L,24L,1L,119L,27L,73L,47L,2L,1L,14L,5L,31L,5L,64L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157520Inst : IEnumerable<long>
{
public static readonly long[] Value=A157520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157520.Bytes);
public long this[int i]=>Value[i];

public static A157520Inst Instance=new A157520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157521
{
public static readonly long[] Value={ 0L,1L,-1L,3L,0L,-3L,11L,9L,-9L,-11L,50L,80L,0L,-80L,-50L,274L,650L,400L,-400L,-650L,-274L,1764L,5544L,6300L,0L,-6300L,-5544L,-1764L,13068L,51156L,82908L,44100L,-44100L,-82908L,-51156L,-13068L,109584L,513792L,1072512L,1016064L,0L,-1016064L,-1072512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157521Inst : IEnumerable<long>
{
public static readonly long[] Value=A157521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157521.Bytes);
public long this[int i]=>Value[i];

public static A157521Inst Instance=new A157521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157522
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,3L,1L,3L,1L,1L,3L,2L,2L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,4L,2L,2L,4L,3L,1L,1L,3L,5L,3L,1L,3L,5L,3L,1L,1L,3L,5L,4L,2L,2L,4L,5L,3L,1L,1L,3L,5L,5L,3L,1L,3L,5L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157522Inst : IEnumerable<long>
{
public static readonly long[] Value=A157522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157522.Bytes);
public long this[int i]=>Value[i];

public static A157522Inst Instance=new A157522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157523
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,15L,15L,1L,1L,37L,95L,37L,1L,1L,82L,463L,463L,82L,1L,1L,173L,1910L,3799L,1910L,173L,1L,1L,356L,7096L,25672L,25672L,7096L,356L,1L,1L,723L,24645L,150994L,260519L,150994L,24645L,723L,1L,1L,1458L,81499L,804875L,2259903L,2259903L,804875L,81499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157523Inst : IEnumerable<long>
{
public static readonly long[] Value=A157523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157523.Bytes);
public long this[int i]=>Value[i];

public static A157523Inst Instance=new A157523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157524
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,3L,5L,5L,5L,7L,6L,6L,7L,8L,6L,9L,11L,10L,9L,10L,11L,11L,11L,14L,13L,15L,21L,22L,19L,20L,19L,20L,19L,20L,21L,18L,21L,23L,20L,22L,23L,27L,29L,27L,33L,30L,27L,29L,31L,32L,36L,38L,35L,35L,39L,37L,35L,34L,41L,43L,46L,47L,42L,40L,39L,42L,46L,46L,53L,52L,45L,46L,50L,50L,56L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157524Inst : IEnumerable<long>
{
public static readonly long[] Value=A157524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157524.Bytes);
public long this[int i]=>Value[i];

public static A157524Inst Instance=new A157524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157525
{
public static readonly long[] Value={ 0L,1L,-1L,3L,0L,-3L,11L,3L,-3L,-11L,50L,20L,0L,-20L,-50L,274L,130L,40L,-40L,-130L,-274L,1764L,924L,420L,0L,-420L,-924L,-1764L,13068L,7308L,3948L,1260L,-1260L,-3948L,-7308L,-13068L,109584L,64224L,38304L,18144L,0L,-18144L,-38304L,-64224L,-109584L,1026576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157525Inst : IEnumerable<long>
{
public static readonly long[] Value=A157525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157525.Bytes);
public long this[int i]=>Value[i];

public static A157525Inst Instance=new A157525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157526
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,15L,18L,3L,105L,150L,45L,945L,1575L,675L,45L,10395L,19845L,11025L,1575L,135135L,291060L,198450L,44100L,1575L,2027025L,4864860L,3929310L,1190700L,99225L,34459425L,91216125L,85135050L,32744250L,4465125L,99225L,654729075L,1895268375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157526Inst : IEnumerable<long>
{
public static readonly long[] Value=A157526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157526.Bytes);
public long this[int i]=>Value[i];

public static A157526Inst Instance=new A157526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157527
{
public static readonly long[] Value={ 46489L,46889L,48649L,48869L,64489L,64849L,68449L,68489L,84649L,84869L,88469L,444869L,448969L,449689L,468499L,468869L,468889L,468899L,469849L,486449L,486869L,486949L,488689L,489689L,489869L,496849L,496889L,498469L,498689L,644489L,644869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157527Inst : IEnumerable<long>
{
public static readonly long[] Value=A157527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157527.Bytes);
public long this[int i]=>Value[i];

public static A157527Inst Instance=new A157527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157528
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,6L,8L,6L,1L,1L,8L,12L,12L,8L,1L,1L,10L,16L,18L,16L,10L,1L,1L,12L,20L,24L,24L,20L,12L,1L,1L,14L,24L,30L,32L,30L,24L,14L,1L,1L,16L,28L,36L,40L,40L,36L,28L,16L,1L,1L,18L,32L,42L,48L,50L,48L,42L,32L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157528Inst : IEnumerable<long>
{
public static readonly long[] Value=A157528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157528.Bytes);
public long this[int i]=>Value[i];

public static A157528Inst Instance=new A157528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157529
{
public static readonly long[] Value={ 22L,33L,44L,55L,66L,77L,88L,99L,110L,202L,220L,303L,312L,321L,330L,404L,413L,422L,440L,505L,514L,532L,550L,606L,615L,624L,633L,642L,651L,660L,707L,716L,725L,734L,752L,770L,808L,817L,826L,835L,844L,862L,871L,880L,909L,918L,927L,936L,945L,954L,963L,972L,981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157529Inst : IEnumerable<long>
{
public static readonly long[] Value=A157529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157529.Bytes);
public long this[int i]=>Value[i];

public static A157529Inst Instance=new A157529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157530
{
public static readonly BigInteger[] Value={ 1L,-25L,-84L,28225L,87780L,-27300625L,-253662444L,446239101425L,1381600765860L,-782034696115375L,-12105874572307404L,16752057282523369075UL,BigInteger.Parse("155592248850573820740"),BigInteger.Parse("-127228945675668708881125"),BigInteger.Parse("-2757289375759334783192364"),BigInteger.Parse("20812238806709306159302482625") };
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
public class A157530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157530Inst Instance=new A157530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157531
{
public static readonly long[] Value={ 2L,3L,3L,7L,10L,7L,21L,29L,29L,21L,71L,86L,106L,86L,71L,253L,277L,352L,352L,277L,253L,925L,960L,1149L,1324L,1149L,960L,925L,3433L,3481L,3873L,4657L,4657L,3873L,3481L,3433L,12871L,12934L,13654L,16006L,17770L,16006L,13654L,12934L,12871L,48621L,48701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157531Inst : IEnumerable<long>
{
public static readonly long[] Value=A157531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157531.Bytes);
public long this[int i]=>Value[i];

public static A157531Inst Instance=new A157531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157532
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157532Inst : IEnumerable<long>
{
public static readonly long[] Value=A157532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157532.Bytes);
public long this[int i]=>Value[i];

public static A157532Inst Instance=new A157532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157533
{
public static readonly long[] Value={ 108649L,140869L,168409L,184609L,904861L,906481L,946801L,968041L,1016489L,1041869L,1048609L,1061849L,1064689L,1068409L,1068491L,1084469L,1084609L,1086469L,1089461L,1098469L,1108469L,1146809L,1184069L,1406689L,1406849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157533Inst : IEnumerable<long>
{
public static readonly long[] Value=A157533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157533.Bytes);
public long this[int i]=>Value[i];

public static A157533Inst Instance=new A157533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157534
{
public static readonly long[] Value={ 1L,3L,6L,30L,135L,441L,1183L,2871L,6660L,15070L,33231L,70863L,145236L,285390L,537930L,974746L,1703043L,2878101L,4719220L,7529340L,11718861L,17834223L,26591841L,38918025L,55995550L,79317576L,110749653L,152600581L,207702930L,279504060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157534Inst : IEnumerable<long>
{
public static readonly long[] Value=A157534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157534.Bytes);
public long this[int i]=>Value[i];

public static A157534Inst Instance=new A157534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157535
{
public static readonly long[] Value={ 1L,3L,18L,70L,285L,1533L,7084L,29604L,116385L,419815L,1385142L,4278066L,12678757L,36517950L,102364200L,278451568L,733599079L,1872496417L,4639365470L,11183927650L,26287242751L,60341512253L,135432776524L,297482865100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157535Inst : IEnumerable<long>
{
public static readonly long[] Value=A157535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157535.Bytes);
public long this[int i]=>Value[i];

public static A157535Inst Instance=new A157535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157536
{
public static readonly long[] Value={ 1L,3L,6L,110L,1095L,7161L,37919L,182367L,860400L,3893395L,17126571L,73368945L,300879670L,1173812745L,4380376770L,15753693858L,54909242667L,186135465987L,614751720490L,1979351435670L,6214975736739L,19042979887371L,57000797449509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157536Inst : IEnumerable<long>
{
public static readonly long[] Value=A157536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157536.Bytes);
public long this[int i]=>Value[i];

public static A157536Inst Instance=new A157536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157537
{
public static readonly long[] Value={ 1L,3L,42L,310L,1965L,12621L,86828L,614664L,4137255L,24696507L,135776850L,704076594L,3499379975L,16814719845L,78438871176L,355384933088L,1560604589541L,6638708644299L,27407266803082L,110092581701214L,431253742334877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157537Inst : IEnumerable<long>
{
public static readonly long[] Value=A157537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157537.Bytes);
public long this[int i]=>Value[i];

public static A157537Inst Instance=new A157537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157538
{
public static readonly long[] Value={ 1L,3L,18L,210L,2565L,32193L,299299L,2161092L,14903940L,101124595L,666560697L,4246100664L,25977358680L,152079371640L,852145833870L,4596664464916L,24033240110143L,122242188808411L,605721155611160L,2925464857935060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157538Inst : IEnumerable<long>
{
public static readonly long[] Value=A157538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157538.Bytes);
public long this[int i]=>Value[i];

public static A157538Inst Instance=new A157538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157539
{
public static readonly long[] Value={ 1L,9L,54L,430L,5265L,51471L,471996L,4601556L,43269345L,363940555L,2806131702L,20371562718L,141703205917L,953199973950L,6225689789880L,39490548010664L,242779946083425L,1445870078850825L,8356848826556090L,46996171775421630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157539Inst : IEnumerable<long>
{
public static readonly long[] Value=A157539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157539.Bytes);
public long this[int i]=>Value[i];

public static A157539Inst Instance=new A157539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157540
{
public static readonly long[] Value={ 1L,3L,6L,430L,8775L,114681L,1213471L,11685663L,110201400L,997307245L,8767514811L,75092781699L,615909156954L,4807634283375L,35885733707970L,258099905201634L,1799253706774203L,12198525957520155L,80576646822300850L,518883888358457370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157540Inst : IEnumerable<long>
{
public static readonly long[] Value=A157540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157540.Bytes);
public long this[int i]=>Value[i];

public static A157540Inst Instance=new A157540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157541
{
public static readonly long[] Value={ 1L,3L,54L,610L,7575L,124005L,1721692L,21584676L,254430555L,2752913955L,27276416970L,252510790038L,2245919946361L,19423497389310L,163254969718200L,1331429118674408L,10524020807274019L,80607360684092143L,599129356328684230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157541Inst : IEnumerable<long>
{
public static readonly long[] Value=A157541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157541.Bytes);
public long this[int i]=>Value[i];

public static A157541Inst Instance=new A157541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157542
{
public static readonly long[] Value={ 1L,3L,42L,930L,17685L,265041L,3668483L,44840097L,529728300L,5955342987L,65311345275L,699155920398L,7170690213960L,69964606094670L,652763403442422L,5868431782886486L,51137730082075059L,433379839761592641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157542Inst : IEnumerable<long>
{
public static readonly long[] Value=A157542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157542.Bytes);
public long this[int i]=>Value[i];

public static A157542Inst Instance=new A157542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157543
{
public static readonly long[] Value={ 1L,3L,66L,1330L,19815L,310023L,4512844L,69146820L,1023450345L,13538157655L,163977086526L,1870633964706L,20447484311345L,216134818489905L,2218284360150120L,22111545640638832L,213615563307370209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157543Inst : IEnumerable<long>
{
public static readonly long[] Value=A157543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157543.Bytes);
public long this[int i]=>Value[i];

public static A157543Inst Instance=new A157543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157544
{
public static readonly long[] Value={ 1L,3L,18L,770L,20805L,522753L,9593507L,138576324L,1907158560L,25880343115L,341234146077L,4348150676532L,53202598238062L,622919366722485L,6980872709154870L,75312434538456228L,787522030868617855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157544Inst : IEnumerable<long>
{
public static readonly long[] Value=A157544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157544.Bytes);
public long this[int i]=>Value[i];

public static A157544Inst Instance=new A157544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157545
{
public static readonly long[] Value={ 1L,9L,90L,1570L,32775L,596253L,10391500L,188323164L,3295910835L,51520770235L,737464758030L,9942564439314L,128439149539155L,1604475021960825L,19461485770566600L,229260099669952384L,2617537416673754961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157545Inst : IEnumerable<long>
{
public static readonly long[] Value=A157545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157545.Bytes);
public long this[int i]=>Value[i];

public static A157545Inst Instance=new A157545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157546
{
public static readonly long[] Value={ 1L,9L,54L,1290L,47385L,1080891L,19941831L,335927439L,5541820740L,87714576070L,1349748111657L,20228679068676L,290345411571852L,3966279413712840L,51810189395306490L,652108043960695984L,7955418278826810531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157546Inst : IEnumerable<long>
{
public static readonly long[] Value=A157546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157546.Bytes);
public long this[int i]=>Value[i];

public static A157546Inst Instance=new A157546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157547
{
public static readonly BigInteger[] Value={ 1L,3L,126L,2170L,37335L,921333L,21967484L,466292604L,9161931075L,164162481681L,2705726857350L,41747317681290L,619096670144225L,8923605271290360L,124998845674120920L,1699006653803990456L,BigInteger.Parse("22382667992161145863") };
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
public class A157547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157547.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157547Inst Instance=new A157547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157548
{
public static readonly BigInteger[] Value={ 1L,3L,6L,1710L,70215L,1835001L,38831135L,747772191L,14106580920L,255318883105L,4489013718651L,76895304533697L,1261399140060514L,19692099463166235L,293975822555447490L,4228706577830551202L,BigInteger.Parse("58957940194082852859") };
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
public class A157548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157548.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157548Inst Instance=new A157548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157549
{
public static readonly BigInteger[] Value={ 1L,3L,102L,2730L,73965L,1747893L,39747932L,941571576L,21552984495L,440593787755L,8246912787894L,145396398912414L,2456171567279885L,40123597587869565L,636426718791995640L,9804070912688974376UL,BigInteger.Parse("146378210616014587821") };
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
public class A157549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157549Inst Instance=new A157549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157550
{
public static readonly BigInteger[] Value={ 1L,3L,54L,1830L,68175L,2604105L,72741487L,1575681348L,32584952460L,663445574880L,13119864945495L,250743317040879L,4601891725568592L,80821202263252920L,1358608769903073690L,BigInteger.Parse("21985893765384549032"),BigInteger.Parse("344851090651019364715") };
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
public class A157550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157550Inst Instance=new A157550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157551
{
public static readonly BigInteger[] Value={ 1L,9L,114L,3810L,103185L,2729181L,69340908L,1835068068L,46949243445L,1072699180795L,22440539853666L,442180822802082L,8348531623530553L,152424934237053765L,2702148696449820840L,BigInteger.Parse("46523455154624265192") };
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
public class A157551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157551.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157551Inst Instance=new A157551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157552
{
public static readonly BigInteger[] Value={ 1L,3L,42L,3410L,143445L,4303761L,117586819L,2875510809L,67804504560L,1524258428187L,33435072500775L,715914503534022L,14685555146992730L,286576099225123995L,5347457520977926782L,BigInteger.Parse("96148425385860533358") };
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
public class A157552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157552Inst Instance=new A157552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157553
{
public static readonly BigInteger[] Value={ 1L,9L,162L,3010L,100035L,3757383L,119414988L,3493064772L,95851672965L,2417802179815L,55917688232274L,1207875284200806L,25067626930769059L,505877445756815265L,9921228112937485800UL,BigInteger.Parse("188795923012791958280") };
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
public class A157553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157553Inst Instance=new A157553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157554
{
public static readonly BigInteger[] Value={ 1L,3L,66L,3990L,178335L,6510483L,190667659L,5047394427L,131071431060L,3262733109790L,78872812374741L,1857536871457917L,41896936373100900L,899337065318075790L,BigInteger.Parse("18460566561637223550"),BigInteger.Parse("365127965985604164628") };
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
public class A157554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157554Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157554.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157554.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157554Inst Instance=new A157554Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157555
{
public static readonly BigInteger[] Value={ 1L,3L,150L,5070L,182175L,5887791L,180232444L,5773910724L,178835952285L,4946264437455L,125256800641170L,2987737855296558L,68285219070825029L,1509200139206357640L,BigInteger.Parse("32387266774022554680"),BigInteger.Parse("675011623200542959496") };
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
public class A157555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157555.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157555Inst Instance=new A157555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157556
{
public static readonly BigInteger[] Value={ 1L,3L,18L,3010L,166725L,8371713L,307008163L,8869151172L,244109996040L,6625340217595L,174712060895757L,4452494561526960L,108958868923534266L,2551477805087525055L,BigInteger.Parse("57187304932168982070"),BigInteger.Parse("1233918981730653994884") };
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
public class A157556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157556Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157556.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157556Inst Instance=new A157556Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157557
{
public static readonly BigInteger[] Value={ 1L,3L,222L,7810L,245715L,7887621L,271336828L,9598223664L,323149486005L,9653120522639L,265199107509930L,6875831133411318L,170878889034103705L,4105071237469192095L,BigInteger.Parse("95749849725794169816"),BigInteger.Parse("2169082695217727013712") };
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
public class A157557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157557Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157557.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157557.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157557Inst Instance=new A157557Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157558
{
public static readonly BigInteger[] Value={ 1L,9L,90L,4710L,294975L,12521313L,439040875L,13748247801L,422094067740L,12416563759270L,354721205123505L,9872974834469253L,263171856408106464L,6676220201317388190L,BigInteger.Parse("161958493217535635430"),BigInteger.Parse("3785772107967822217382") };
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
public class A157558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157558Inst Instance=new A157558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157559
{
public static readonly BigInteger[] Value={ 1L,3L,162L,5470L,204405L,10044237L,418371436L,15735232164L,556455670755L,18061671242945L,536877862194894L,14910514196745102L,397858116730316515L,10322446421549098305UL,BigInteger.Parse("260281325962170069480"),BigInteger.Parse("6368185576937692717552") };
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
public class A157559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157559.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157559Inst Instance=new A157559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157560
{
public static readonly BigInteger[] Value={ 1L,9L,54L,4730L,384345L,17551611L,639200583L,21540673143L,709364141280L,22449552443395L,690983408959437L,20713553342449344L,594627688939323130L,16245942354519666285UL,BigInteger.Parse("424430686079103349170"),BigInteger.Parse("10684143371864906288080") };
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
public class A157560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157560.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157560Inst Instance=new A157560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157561
{
public static readonly BigInteger[] Value={ 1L,3L,186L,8710L,366285L,14870583L,574288652L,23199133896L,906030228645L,31596296548135L,1008864177035154L,30341990819899122L,874376529563919655L,BigInteger.Parse("24366254356588107705"),BigInteger.Parse("659305049442735042120"),BigInteger.Parse("17325808811806633829408") };
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
public class A157561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157561.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157561Inst Instance=new A157561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157562
{
public static readonly BigInteger[] Value={ 1L,3L,126L,6510L,336015L,19347993L,928126199L,34039360092L,1173329179500L,39563049010881L,1301454506052525L,41455087636231074L,1268529094022948940L,BigInteger.Parse("37131123353064641460"),BigInteger.Parse("1040240395936575811890"),BigInteger.Parse("28055696919876575091824") };
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
public class A157562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157562Inst Instance=new A157562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157563
{
public static readonly BigInteger[] Value={ 1L,9L,198L,9930L,447345L,19373781L,801643164L,34613610228L,1445069106945L,53870000270295L,1838679236576886L,59112727361906010L,1820954720583759943L,BigInteger.Parse("54244177130219463765"),BigInteger.Parse("1568969312068377795960"),BigInteger.Parse("44074283494841644862536") };
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
public class A157563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157563.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157563Inst Instance=new A157563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157564
{
public static readonly BigInteger[] Value={ 1L,3L,6L,6830L,561735L,29360121L,1242596383L,47858305311L,1805644314360L,65361758855305L,2298374956416891L,78740814179665443L,2583344854373884146L,BigInteger.Parse("80658838456091971635"),BigInteger.Parse("2408249945284962451650"),BigInteger.Parse("69283128843699421305698") };
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
public class A157564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157564.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157564Inst Instance=new A157564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157565
{
public static readonly BigInteger[] Value={ 1L,3L,198L,9310L,376485L,22631679L,1141749532L,52484724372L,2266995222285L,89935056097975L,3267564223225962L,110915350947910158L,3617265650971040159L,BigInteger.Parse("114705568549182973950"),BigInteger.Parse("3535047653641613917560"),BigInteger.Parse("105710505247924746059104") };
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
public class A157565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157565.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157565Inst Instance=new A157565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157566
{
public static readonly BigInteger[] Value={ 1L,3L,102L,8190L,665685L,36705753L,1679350127L,68733531189L,2760184991340L,106183264044550L,3966764429800029L,144378604643078598L,5032695166253713140L,BigInteger.Parse("166954292511159130110"),BigInteger.Parse("5296343179095984782250"),BigInteger.Parse("161894623559389026065130") };
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
public class A157566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157566.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157566Inst Instance=new A157566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157567
{
public static readonly BigInteger[] Value={ 1L,9L,378L,13330L,689715L,30934071L,1463659596L,72481823352L,3407856306435L,142400570465307L,5478965101306950L,198874787418398598L,6919440283487706065L,BigInteger.Parse("232730571288134765160"),BigInteger.Parse("7599816260357477794632"),BigInteger.Parse("241028324482889751669040") };
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
public class A157567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157567Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157567.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157567Inst Instance=new A157567Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157568
{
public static readonly BigInteger[] Value={ 1L,3L,54L,6710L,552975L,42285705L,2331601391L,101037868356L,4170874974720L,169800684016755L,6716524310262195L,256753303252023825L,9424676123728329646UL,BigInteger.Parse("331044899193112524525"),BigInteger.Parse("11129765080736905244370"),BigInteger.Parse("360217055543666912443944") };
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
public class A157568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157568Inst Instance=new A157568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157569
{
public static readonly BigInteger[] Value={ 1L,9L,234L,13330L,759255L,39386151L,1941592492L,100065421116L,4986199986795L,221853806154915L,9037873481632974L,346801773380423010L,12750860059402207015UL,BigInteger.Parse("453349862010556020825"),BigInteger.Parse("15650738757439717731720") };
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
public class A157569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157569Inst Instance=new A157569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157570
{
public static readonly BigInteger[] Value={ 1L,9L,114L,11430L,928665L,57312801L,2929653363L,133959064275L,6012597282660L,258520740868390L,10793900036914731L,439085564014381089L,17106142080255638592UL,BigInteger.Parse("634240156516816014270"),BigInteger.Parse("22487281301691416873070") };
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
public class A157570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157570Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157570.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157570.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157570Inst Instance=new A157570Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157571
{
public static readonly BigInteger[] Value={ 1L,9L,270L,10990L,622725L,43526469L,2629049500L,142957923228L,7300452572415L,342254197570615L,14695487432860410L,589524950365892190L,BigInteger.Parse("22721530823371062501"),BigInteger.Parse("851515705898338365990"),BigInteger.Parse("31013728074479042288280") };
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
public class A157571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157571Inst Instance=new A157571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157572
{
public static readonly BigInteger[] Value={ 1L,3L,42L,13330L,1149525L,68923281L,3762973571L,184036492377L,8678968080840L,390210773279547L,17118756925603575L,733096379424490302L,BigInteger.Parse("30076017737894907870"),BigInteger.Parse("1173815703627064565445"),BigInteger.Parse("43806372065182513944702") };
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
public class A157572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157572Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157572.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157572Inst Instance=new A157572Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157573
{
public static readonly BigInteger[] Value={ 1L,3L,246L,17230L,1034445L,59305701L,3243926588L,185256960120L,10229264210745L,504340200498475L,22766981281651398L,968060807776968126L,BigInteger.Parse("39440547846380819957"),BigInteger.Parse("1553885734839506217555"),BigInteger.Parse("59443252831855326838200") };
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
public class A157573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157573Inst Instance=new A157573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157574
{
public static readonly BigInteger[] Value={ 1L,9L,162L,9030L,900315L,78905043L,5045283243L,254993728356L,12275288985060L,582690164112595L,26896406705910159L,1199420057394958074L,BigInteger.Parse("51363567523493108520"),BigInteger.Parse("2104956036291257002350"),BigInteger.Parse("82564460378872392399390") };
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
public class A157574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157574Inst Instance=new A157574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157575
{
public static readonly BigInteger[] Value={ 1L,9L,258L,18070L,1193265L,71833671L,4116288204L,246535687044L,14276990551185L,738244819092055L,34951581964536930L,1558650106287998802L,BigInteger.Parse("66599892238284898857"),BigInteger.Parse("2751910251508099981950"),BigInteger.Parse("110408459890796284831080") };
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
public class A157575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157575Inst Instance=new A157575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157576
{
public static readonly BigInteger[] Value={ 1L,3L,66L,14630L,1446495L,105717843L,6111518987L,323657828739L,16777260176400L,835056998169955L,40377792647031081L,1902059925519314067L,BigInteger.Parse("85804943707548960986"),BigInteger.Parse("3683698658760163764945"),BigInteger.Parse("151229533594426205964390") };
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
public class A157576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157576Inst Instance=new A157576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157577
{
public static readonly BigInteger[] Value={ 1L,3L,378L,18910L,992325L,74527005L,5338966892L,339980231676L,20037272191665L,1077068920503015L,53256851208061050L,2465137614876120834L,BigInteger.Parse("109671118311748056245"),BigInteger.Parse("4742369931941953806600"),BigInteger.Parse("199288535032516918383432") };
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
public class A157577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157577Inst Instance=new A157577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157578
{
public static readonly BigInteger[] Value={ 1L,3L,150L,15210L,1639575L,123643611L,7614820759L,421492526271L,22902703731540L,1192049263269315L,60248523072916695L,2966823784716819963L,BigInteger.Parse("139916416171825355244"),BigInteger.Parse("6279781745619795030660"),BigInteger.Parse("269526833541639073889370") };
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
public class A157578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157578Inst Instance=new A157578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157579
{
public static readonly BigInteger[] Value={ 1L,3L,294L,21630L,1556655L,102426933L,6421722076L,420393758436L,26609856588945L,1503958534048245L,77827209776501394L,3793522397195559678L,BigInteger.Parse("177172760525971961023"),BigInteger.Parse("8001788984919141620040"),BigInteger.Parse("350900981113969220953080") };
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
public class A157579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157579Inst Instance=new A157579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157580
{
public static readonly BigInteger[] Value={ 1L,3L,18L,11970L,1334085L,133955073L,9824277155L,567625941444L,31246085767560L,1696086845812315L,89452573267087437L,4559354532659814420L,BigInteger.Parse("223147765159835078290"),BigInteger.Parse("10450853058701142231795"),BigInteger.Parse("468478402281324084911670") };
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
public class A157580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157580Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157580.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157580Inst Instance=new A157580Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157581
{
public static readonly BigInteger[] Value={ 1L,15L,390L,21010L,1806015L,123582921L,7932838172L,541388995092L,35637846633315L,2098170095389555L,113237331813959034L,5754386605886291022L,BigInteger.Parse("280189305372079613419"),BigInteger.Parse("13193562175797681608910"),BigInteger.Parse("603200922513642478421880") };
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
public class A157581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157581Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157581.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157581.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157581Inst Instance=new A157581Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157582
{
public static readonly BigInteger[] Value={ 1L,3L,222L,23430L,2211435L,165640041L,11463980983L,700674124347L,41384377023300L,2326405435793384L,127560765651968055L,6827700441824422953L,BigInteger.Parse("350130844722624976920"),BigInteger.Parse("17081201454932094454170"),BigInteger.Parse("796830250007891403178002") };
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
public class A157582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157582Inst Instance=new A157582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157583
{
public static readonly BigInteger[] Value={ 1L,3L,306L,19110L,1405335L,127596189L,10056226796L,714714066732L,47739604854315L,2926869332706055L,164336205885920178L,8620987583406297606L,BigInteger.Parse("434508999474316043459"),BigInteger.Parse("21294115220098361584440"),BigInteger.Parse("1014206441760046027667880") };
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
public class A157583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157583Inst Instance=new A157583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157584
{
public static readonly BigInteger[] Value={ 1L,9L,90L,17270L,2392575L,203322273L,14072688875L,881578169937L,54028224275760L,3177868465756435L,181594395820598805L,10109617693345774539UL,BigInteger.Parse("538976083520642296074"),BigInteger.Parse("27345902242485061861185"),BigInteger.Parse("1326768997661185039512750") };
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
public class A157584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157584Inst Instance=new A157584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157585
{
public static readonly BigInteger[] Value={ 1L,3L,330L,27570L,2233965L,165759111L,11709395180L,864416336904L,61700500723635L,3932420281395045L,229474040212588578L,12613127103936869874UL,BigInteger.Parse("664285970637825836755"),BigInteger.Parse("33831654295810674426165"),BigInteger.Parse("1673010760008675643666440") };
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
public class A157585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157585Inst Instance=new A157585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157586
{
public static readonly BigInteger[] Value={ 1L,3L,162L,16410L,1839645L,210928977L,17676193171L,1148671947972L,71262995700540L,4352863891098140L,258238261126722129L,14806140740844716211UL,BigInteger.Parse("815211282605034375060"),BigInteger.Parse("42951699550186642926270"),BigInteger.Parse("2166061193994862365099390") };
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
public class A157586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157586.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157586Inst Instance=new A157586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157587
{
public static readonly BigInteger[] Value={ 1L,3L,462L,41230L,2595765L,186323823L,13994329244L,1089068168952L,80599569668955L,5296880405561547L,320164718544367950L,18262041337319290446UL,BigInteger.Parse("998477188502752352485"),BigInteger.Parse("52770671879708445120045"),BigInteger.Parse("2707901917377956941817496") };
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
public class A157587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157587Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157587.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157587.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157587Inst Instance=new A157587Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157588
{
public static readonly BigInteger[] Value={ 1L,9L,54L,18490L,3080025L,281083131L,20455480647L,1378645284663L,90798695826120L,5747081242763245L,353783429708291517L,BigInteger.Parse("21210677666294419836"),BigInteger.Parse("1217797507802900629878"),BigInteger.Parse("66543379957754376544455") };
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
public class A157588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157588.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157588Inst Instance=new A157588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157589
{
public static readonly BigInteger[] Value={ 1L,9L,342L,26670L,1960515L,199230213L,17543249724L,1392949344564L,103992753869385L,7125947800456375L,447172658110001142L,BigInteger.Parse("26218227869348323614"),BigInteger.Parse("1476897053364550626991"),BigInteger.Parse("80893894777513364496600") };
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
public class A157589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157589.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157589Inst Instance=new A157589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157590
{
public static readonly BigInteger[] Value={ 1L,3L,186L,26130L,3296565L,312282243L,24263695547L,1693530847881L,116031418602660L,7614709044887230L,485263665372726339L,BigInteger.Parse("30129597082995141381"),BigInteger.Parse("1791597506670518058876"),BigInteger.Parse("101387984322685789268190") };
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
public class A157590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157590Inst Instance=new A157590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157591
{
public static readonly BigInteger[] Value={ 1L,3L,354L,35410L,3079815L,254391501L,20017977868L,1645049437956L,130713839323245L,9274041450918255L,602446992143570574L,BigInteger.Parse("36862449524697504786"),BigInteger.Parse("2161188475320550751257"),BigInteger.Parse("122528449769743353508305") };
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
public class A157591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157591Inst Instance=new A157591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157592
{
public static readonly BigInteger[] Value={ 1L,3L,126L,23870L,2725455L,314174553L,29749465207L,2182715679324L,150186806030400L,10125676123572801L,666260841650613825L,BigInteger.Parse("42448715774998807794"),BigInteger.Parse("2597948199840416316530"),BigInteger.Parse("152089661374768398565935") };
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
public class A157592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157592Inst Instance=new A157592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157593
{
public static readonly BigInteger[] Value={ 1L,9L,378L,37830L,3403815L,290684541L,23648592268L,2009304033948L,165069279069345L,12108533607540535L,813240975212887518L,BigInteger.Parse("51447280837022648370"),BigInteger.Parse("3118521194576489150631"),BigInteger.Parse("182797738828031587273965") };
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
public class A157593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157593Inst Instance=new A157593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157594
{
public static readonly BigInteger[] Value={ 1L,9L,198L,29790L,4026105L,406849401L,33869423679L,2526809359383L,185063876167860L,12982668662313075L,884404700588788401L,BigInteger.Parse("58698938381426781945"),BigInteger.Parse("3731136219706944217260"),BigInteger.Parse("225710021147180429934270") };
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
public class A157594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157594Inst Instance=new A157594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157595
{
public static readonly BigInteger[] Value={ 1L,9L,486L,26230L,2658825L,303936255L,29022562044L,2546840675268L,209628417451815L,15863225333113455L,1100628488842991790L,BigInteger.Parse("71323826984704710078"),BigInteger.Parse("4440654868991991482287"),BigInteger.Parse("268844012960749492143465") };
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
public class A157595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157595Inst Instance=new A157595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157596
{
public static readonly BigInteger[] Value={ 1L,3L,6L,27310L,4493895L,469762041L,39763084319L,3062924462367L,231122336887800L,16732612596774745L,1176767971442596731L,BigInteger.Parse("80630592887297229153"),BigInteger.Parse("5290690279278336041746"),BigInteger.Parse("330378602282944731759075") };
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
public class A157596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157596Inst Instance=new A157596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157597
{
public static readonly BigInteger[] Value={ 1L,9L,630L,48670L,4293525L,358348053L,32224041500L,2966406894648L,259556693304825L,20157653282906667L,1439903350550159550L,BigInteger.Parse("97064374251531230622"),BigInteger.Parse("6271845201623139087495"),BigInteger.Parse("391742584864070048279685") };
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
public class A157597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157597.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157597Inst Instance=new A157597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157598
{
public static readonly BigInteger[] Value={ 1L,3L,198L,27930L,3388365L,475265259L,48238917727L,3831384879156L,290324159283540L,21674347016566915L,1571698374562433667L,BigInteger.Parse("110138942653526323056"),BigInteger.Parse("7411777323163714916688"),BigInteger.Parse("477289870722013730288040") };
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
public class A157598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157598.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157598Inst Instance=new A157598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157599
{
public static readonly BigInteger[] Value={ 1L,9L,402L,44230L,4512465L,423267831L,37803628716L,3527887213476L,318332583745245L,25647872392849575L,1892012326768856754L,BigInteger.Parse("131465592083214083058"),BigInteger.Parse("8752726227773492626389"),BigInteger.Parse("563521423775802944905950") };
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
public class A157599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157599Inst Instance=new A157599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157600
{
public static readonly BigInteger[] Value={ 1L,3L,102L,30030L,5399445L,596031513L,53828636911L,4407428497293L,353304900193680L,27176309595536035L,2030727740280136689L,BigInteger.Parse("147839184902264090742"),BigInteger.Parse("10306962174706523122706"),BigInteger.Parse("683847390057269455279395") };
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
public class A157600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157600Inst Instance=new A157600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157601
{
public static readonly BigInteger[] Value={ 1L,3L,450L,35490L,3461325L,429808743L,45598808332L,4382814679428L,396120762708465L,32858020705796385L,2495992345644237990L,BigInteger.Parse("177151945927883401410"),BigInteger.Parse("12079996873394323662971"),BigInteger.Parse("800952129262668313107765") };
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
public class A157601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157601Inst Instance=new A157601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157602
{
public static readonly BigInteger[] Value={ 1L,9L,378L,39990L,6207435L,649615491L,61839617931L,5291171373321L,436429418237100L,34318546032095787L,2635382197485052125L,BigInteger.Parse("197482663359487272702"),BigInteger.Parse("14177933118661639661880"),BigInteger.Parse("968391907322785974064260") };
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
public class A157602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157602Inst Instance=new A157602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157603
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,11L,5L,1L,1L,1L,1L,16L,6L,1L,1L,1L,1L,42L,22L,7L,1L,1L,1L,1L,1L,64L,29L,8L,1L,1L,1L,1L,1L,163L,93L,37L,9L,1L,1L,1L,1L,1L,1L,256L,130L,46L,10L,1L,1L,1L,1L,1L,1L,638L,386L,176L,56L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157603Inst : IEnumerable<long>
{
public static readonly long[] Value=A157603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157603.Bytes);
public long this[int i]=>Value[i];

public static A157603Inst Instance=new A157603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157604
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,11L,16L,17L,22L,27L,29L,36L,37L,42L,43L,52L,57L,59L,66L,67L,72L,77L,82L,87L,95L,99L,101L,106L,107L,112L,125L,129L,136L,137L,148L,149L,156L,161L,166L,171L,178L,179L,190L,191L,196L,197L,210L,221L,226L,227L,232L,237L,239L,250L,253L,262L,267L,269L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157604Inst : IEnumerable<long>
{
public static readonly long[] Value=A157604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157604.Bytes);
public long this[int i]=>Value[i];

public static A157604Inst Instance=new A157604Inst();

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